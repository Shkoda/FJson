namespace Shkoda.Telegram.Client
module Json  =
    open FSharp.Data
    open System

    type JsonSchema = JsonProvider<"../data/schema.json">

    let coreSchemaUrl = "https://core.telegram.org/schema/json"
    let endToEndchemaUrl = "https://core.telegram.org/schema/end-to-end-json"
       
    let loadSchema (url: string) = JsonSchema.Load(url)
    let loadConstructors ([<ParamArray>] urls) = 
        urls |> Array.map loadSchema |> Array.map (fun s -> s.Constructors) |> Array.concat
    let loadAllKnownConstructors = loadConstructors ([|coreSchemaUrl; endToEndchemaUrl|])       

    type ParamType = 
    | Bool
    | Int 
    | Long 
    | String 
    | Bytes 
    | Double
    | Vector of ParamType
    | TypeName of string

    type ConstructorParam = {name:string; paramType:ParamType} with      
        static member ParseType (t:string) =
            let VectorType (pt:string) =
                pt.Replace("Vector<", "").Replace(">", "") |> ConstructorParam.ParseType               
                
            match t with
            | "int" -> ParamType.Int
            | "long" -> ParamType.Long
            | "string" -> ParamType.String
            | "bytes" -> ParamType.Bytes
            | "double" -> ParamType.Double
            | txt when txt.StartsWith("Vector") -> ParamType.Vector (VectorType txt)
            | txt when txt.Contains "flag" -> ParamType.Bool
            | _ -> ParamType.TypeName (t.Replace(".", "_"))
                  
        static member Parse (typeName:string) (fieldName:string) = 
            let parsedType = match fieldName with
                                |"flags" -> ParamType.Int 
                                |_ -> ConstructorParam.ParseType typeName
            {name = fieldName; paramType = parsedType}

    
    type ConstructorDefinition = {id:int; predicate:string; typeName:string; layer:int option; constructorParams:ConstructorParam[]}
    type RecordDefinition = {typeName: string; children: ConstructorDefinition[]}

    let parseAllKnownConstructors = 
        let parseConstructorParams (p: JsonSchema.Param[]) = 
            let parseRawParam (p : JsonSchema.Param) = ConstructorParam.Parse p.Type p.Name
            p |> Seq.map parseRawParam |> Seq.toArray
        let parseConstructor (raw : JsonSchema.Constructor) = {
            id = raw.Id;
            predicate = (raw.Predicate.Replace(".", "_"));
            typeName = (raw.Type.Replace(".", "_"));
            layer = raw.Layer;
            constructorParams = parseConstructorParams raw.Params }
        
        loadAllKnownConstructors |> Seq.map parseConstructor

    let records  = 
        parseAllKnownConstructors 
        |> Seq.groupBy (fun c -> c.typeName)
        |> Seq.map (fun (k, v) -> {typeName=k; children=Seq.toArray v})
        
          
    let rec GetRequiredTypeName constructorParam = 
       let rec objTypeName paramType = 
          match paramType  with
          | Int | Long | String | Bytes | Double | Bool -> None
          | Vector smth -> objTypeName smth
          | TypeName n -> n |> Some
       objTypeName constructorParam.paramType
       
    let rec requiredTypes record =
        let requiredForConstructor p = p |> Seq.choose GetRequiredTypeName |> Seq.distinct
        record.children |> Seq.map (fun c -> c.constructorParams) |> Seq.collect requiredForConstructor |> Seq.distinct       
     
    let sorted (src:RecordDefinition[]) =
        let rec sorted (source:RecordDefinition[]) (result:RecordDefinition[]) (knownTypes:string[]) = 
            let areAllTypesAlreadyKnown record = 
                record |> requiredTypes |> Seq.forall (fun t -> Seq.contains t knownTypes)                   
                
            let selectTypeNames records = 
                records |> Array.map (fun r -> r.typeName) |> Array.distinct
                
            let readyRecords  = source |> Array.filter areAllTypesAlreadyKnown 
            let notReadyRecords  = source |> Array.filter (fun r -> not (areAllTypesAlreadyKnown(r)))
                                  
            match (Seq.length source) with
            |0 -> result
            |_ -> sorted notReadyRecords (Array.append result readyRecords) (Array.append knownTypes (selectTypeNames readyRecords))
            
        sorted src Array.empty<RecordDefinition> Array.empty<string>
                 
    let toString (constructorParams:ConstructorParam[]) = 
        let toString constructorParam = 
            let rec toString paramType = 
                match paramType with
                | Bool -> "bool"
                | Int -> "int"
                | Long -> "int64"
                | Double -> "double"
                | Bytes -> "byte[]"
                | String -> "string"
                | Vector smth -> sprintf "Vector<%s>" (toString smth)
                | TypeName t -> t
            sprintf "_%s : %s" constructorParam.name (toString constructorParam.paramType) 
        
        match Array.length constructorParams with
        |0 -> ""
        |_ -> constructorParams |> Array.map (fun c -> (toString c)) |> String.concat "; " |> sprintf "\t\t{%s} with\n" 
        
    let layeredTypeName c =
        let suffix = 
            match c.layer with
            | Some l -> sprintf "_%i" l
            | None -> ""
        sprintf "%s%s" c.predicate suffix
    
    let toStringConstructor (c: ConstructorDefinition) = 
        let typeDefinition = sprintf "\ttype %s = \n" (layeredTypeName c)
        let paramDefinition = toString c.constructorParams
        let constructorDefinition = sprintf "\t\tstatic member Constructor = %i\n" c.id
        let layerDefinition = 
            match c.layer with  
            |Some l -> sprintf "\t\tstatic member Layer = %i\n" l
            |None -> ""
                    
        typeDefinition + paramDefinition + constructorDefinition + layerDefinition
        
    let toStringRecord (r: RecordDefinition) = 
        let firstCharToUpper (str:string) = 
            let u = str.Substring(0,1).ToUpper
            match str with
            | "" -> ""
            | _ -> sprintf "%s%s"  ((str.Substring(0,1)).ToUpper()) (str.Substring(1, str.Length - 1))
        let unionElement (c:ConstructorDefinition) = 
            let name = layeredTypeName c
            sprintf "|%s of %s " (firstCharToUpper name) name
            
        let unionString (unionName: string) (constructors : ConstructorDefinition[]) = 
            let elements = constructors |> Array.map unionElement |> String.concat "\n\t\t"
            sprintf "\ttype %s = \n\t\t%s\n" unionName elements
            
        let constructors = r.children |> Seq.map toStringConstructor |> String.concat "\n"
        let union = unionString r.typeName r.children
        
        sprintf "%s\n%s" constructors union
        
    let toStringAll (records : RecordDefinition[]) = 
         let r = records |> Array.map toStringRecord |> String.concat "\n"
         let txt = sprintf "namespace Shkoda.Telegram.Client\nmodule GeneratedTypes = \n%s" r
         (txt.Replace("\t", "    "))
    
  
