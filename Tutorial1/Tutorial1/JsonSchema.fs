namespace Shkoda.Telegram.Client
module Json  =
    open FSharp.Data
    open System

    type JsonSchema = JsonProvider<"../data/schema.json">
    
    let loadJson = JsonSchema.Load("../data/schema.json")

    type ParamType = 
    | Int 
    | Long 
    | String 
    | Bytes 
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
            | txt when txt.StartsWith("Vector") -> ParamType.Vector (VectorType txt)
            | _ -> ParamType.TypeName t
         static member Parse (n: string)(t:string) = {name = n; paramType = ConstructorParam.ParseType t}


    type ConstructorDefinition = {id:int; predicate:string; typeName:string; layer:int; constructorParams:ConstructorParam[];parent:ConstructorDefinition option}

    let constructors = 
        loadJson.Constructors 
        |> Seq.map (fun (raw) -> 
            {id = raw.Id;
            predicate = raw.Predicate;
            typeName = raw.Type;
            layer = raw.Layer;constructorParams = raw.Params |> Seq.map (fun p -> ConstructorParam.Parse p.Name p.Type) |> Seq.toArray; 
            parent = None})
       

      

    let a = constructors

