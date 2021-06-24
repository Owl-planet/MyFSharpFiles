let a = Set.ofSeq [ 1 ..2.. 20 ]
let b = Set.ofSeq [ 1 ..3 .. 20 ]
let c = Set.intersect a b
let d = Set.union a b
let e = Set.difference a b

printfn "Set a: "
Set.iter (fun x -> printf "%O " x) a
printfn""

printfn "Set b: "
Set.iter (fun x -> printf "%O " x) b
printfn""

printfn "Set c = set intersect of a and b : "
Set.iter (fun x -> printf "%O " x) c
printfn""

printfn "Set d = set union of a and b : "
Set.iter (fun x -> printf "%O " x) d
printfn""

printfn "Set e = set difference of a and b : "
Set.iter (fun x -> printf "%O " x) e
printfn""