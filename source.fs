open System

let getGreeting name = $"Hello, {name}! Isn't F# great?"

[<EntryPoint>]
let main args = 
    let names = [ "Don"; "Julia"; "Xi" ]

    names
    |> List.map getGreeting
    |> List.iter (fun greeting -> printfn $"{greeting}")

    0