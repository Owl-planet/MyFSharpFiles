open System
let KelimeAra x y = 
    Console.Write(List.findIndex x y)
KelimeAra (fun x -> x = "bar") ["foo"; "bao"; "bar"; "bar"]