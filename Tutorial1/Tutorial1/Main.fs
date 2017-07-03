namespace Shkoda.Telegram.Client
module Main=
    open System

    [<EntryPoint>]
    let main args =
        Console.WriteLine("hello")
        let a = Json.records 
                |> Seq.toArray 
                |> Json.sorted 
                |> Seq.iter (fun c -> printfn "%A\n" c)

       // while true do Console.ReadLine()
        0