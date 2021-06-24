let applyFunction ( f: int -> int -> int) x y = f x y
let res = applyFunction (fun x y -> x * y ) 5 7
printfn "%d" res