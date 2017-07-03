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
    type UnionDefinition = {typeName: string; children: seq<ConstructorDefinition>}
    type RecordDefinition = |Constructor of ConstructorDefinition | Union of UnionDefinition


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
        |> Seq.map (fun (k, v) ->  match Seq.length v  with 
                                   |1 -> RecordDefinition.Constructor (Seq.head v)                          
                                   |_ -> RecordDefinition.Union {typeName=k; children=v}
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
        match record with
        | Constructor c -> c.constructorParams |> requiredForConstructor
        | Union u -> u.children |> Seq.map (fun c -> c.constructorParams) |> Seq.collect requiredForConstructor |> Seq.distinct
       
     
    let sorted (src:RecordDefinition[]) =
        let rec sorted (source:RecordDefinition[]) (result:RecordDefinition[]) (knownTypes:string[]) = 
            let allTypesAlreadyKnown (record: RecordDefinition)  = 
                record |> requiredTypes |> Seq.forall (fun t -> Seq.contains t knownTypes)
                   
                
            let typeNames records = 
                let recordTypeName r = 
                    match r with
                    |Constructor c -> c.typeName
                    |Union u -> u.typeName
                records |> Array.map recordTypeName
                
            let readyRecords  = source |> Array.filter allTypesAlreadyKnown 
            let notReadyRecords  = source |> Array.filter (fun r -> not (allTypesAlreadyKnown(r)))
            
            match Seq.length source with
            |0 -> result
            |_ -> sorted notReadyRecords (Array.append result readyRecords) (Array.append knownTypes (typeNames readyRecords))
            
        sorted src Array.empty<RecordDefinition> Array.empty<string>
          
          
          

    
       
       
 
  
      

  //  let a = constructors

