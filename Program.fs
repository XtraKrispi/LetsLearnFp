// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open TypeProviders

let moves = getPokemonInfo "pikachu" |> Async.RunSynchronously

printfn "%A" moves


let suppliers = blah ()

printfn "%A" suppliers
