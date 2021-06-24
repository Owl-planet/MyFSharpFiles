open System
let küp x = 
    x * x * x
printfn "%f" <| [ 1 .. 100 ] |> List.map küp |> List.sum