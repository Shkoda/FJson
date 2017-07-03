namespace Shkoda.Telegram.Client
module Main=
    open System
    open System.IO

    [<EntryPoint>]
    let main args =
        Console.WriteLine("hello")
        let a = Json.records 
                |> Seq.toArray 
                |> Json.sorted 
                |> Json.toStringAll
                
        let createFile (txt : string) =
            use streamWriter = new StreamWriter("../../GeneratedConstructors.fs", false)
            streamWriter.Write(txt)
        printfn "%s" a
        createFile a
             //   |> printf
                //|> Seq.iter (fun c -> printfn "%A\n" c)

       // while true do Console.ReadLine()
        0