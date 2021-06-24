(* let div x y = x / y
let res = div 20 5
printfn "Result: %d" res

let div x y = x / y
let res = div 20 0
printfn "Result: %d" res *)

let div x y =
   match y with
   | 0 -> None
   | _ -> Some(x/y)

let res : int option = div 20 0
printfn "Result: %A " res