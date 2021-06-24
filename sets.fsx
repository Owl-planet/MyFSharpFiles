(* creating sets *)
let set1 = Set.empty.Add(3).Add(5).Add(7). Add(9)
printfn"The new set: %A" set1

let weekdays = Set.ofList ["mon"; "tues"; "wed"; "thurs"; "fri"]
printfn "The list set: %A" weekdays

let set2 = Set.ofSeq [ 1 .. 2.. 10 ]
printfn "The sequence set: %A" set2