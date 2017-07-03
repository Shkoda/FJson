namespace Shkoda.Telegram.Client
module Json  =
    open FSharp.Data
    open System

    type JsonSchema = JsonProvider<"../data/schema.json">
    
    let loadJson = JsonSchema.Load("../../data/schema.json")

    type ParamType = 
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
            | _ -> ParamType.TypeName t
         static member Parse (n: string)(t:string) = {name = n; paramType = ConstructorParam.ParseType t}

    
    type ConstructorDefinition = {id:int; predicate:string; typeName:string; layer:int; constructorParams:ConstructorParam[]}
    type RecordDefinition = {typeName: string; children: ConstructorDefinition[]}



    let constructors = 
        loadJson.Constructors 
        |> Seq.map (fun (raw) -> 
            {id = raw.Id;
            predicate = raw.Predicate;
            typeName = raw.Type;
            layer = raw.Layer;constructorParams = raw.Params |> Seq.map (fun p -> ConstructorParam.Parse p.Name p.Type) |> Seq.toArray})
//
    let records  = 
        constructors
        |> Seq.groupBy (fun c -> c.typeName)
        |> Seq.map (fun (k, v) -> {typeName=k; children=Seq.toArray v}
        )
        
          
    let rec GetRequiredTypeName constructorParam = 
       let rec objTypeName paramType = 
          match paramType  with
          | Int | Long | String | Bytes | Double -> None
          | Vector smth -> objTypeName smth
          | TypeName n -> n |> Some
       objTypeName constructorParam.paramType
       
    let rec requiredTypes record =
        let requiredForConstructor p = p |> Seq.choose GetRequiredTypeName |> Seq.distinct
        record.children |> Seq.map (fun c -> c.constructorParams) |> Seq.collect requiredForConstructor |> Seq.distinct
       
     
    let sorted (src:RecordDefinition[]) =
        let rec sorted (source:RecordDefinition[]) (result:RecordDefinition[]) (knownTypes:string[]) = 
            let allTypesAlreadyKnown (record: RecordDefinition)  = 
                record |> requiredTypes |> Seq.forall (fun t -> Seq.contains t knownTypes)
                   
                
            let typeNames records = 
                records |> Array.map (fun r -> r.typeName)
                
            let readyRecords  = source |> Array.filter allTypesAlreadyKnown 
            let notReadyRecords  = source |> Array.filter (fun r -> not (allTypesAlreadyKnown(r)))
            
            match Seq.length source with
            |0 -> result
            |_ -> sorted notReadyRecords (Array.append result readyRecords) (Array.append knownTypes (typeNames readyRecords))
            
        sorted src Array.empty<RecordDefinition> Array.empty<string>
          
          
    type sendMessageTypingAction17 = 
       // new()={}             
        static member Layer = 17
        static member Constructor = 100500
        
     type sendMessageTypingAction23 = 
        {w:int; h:int} with
        static member Layer = 23
        static member Constructor = 200500
        
    type SendMessageAction = |SendMessageTypingAction17 of sendMessageTypingAction17
       
        
    let toString (constructorParams:ConstructorParam[]) = 
        let toString constructorParam = 
            let rec toString paramType = 
                match paramType with
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
        
    let layeredTypeName c = sprintf "%s_%i" c.predicate c.layer
    
    let toStringConstructor (c: ConstructorDefinition) = 
        let typeDefinition = sprintf "\ttype %s = \n" (layeredTypeName c)
        let paramDefinition = toString c.constructorParams
        let constructorDefinition = sprintf "\t\tstatic member Constructor = %i\n" c.id
        let layerDefinition = sprintf "\t\tstatic member Layer = %i\n" c.layer
        
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
         sprintf "namespace Shkoda.Telegram.Client\nmodule GeneratedTypes = \n%s" r
         
           

  //  let a = constructors

