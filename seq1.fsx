(* Sequences *)
let seq1 = seq { 1 .. 10 }

(* ascending order and increment*)
printfn "The Sequence: %A" seq1
let seq2 = seq { 1 .. 5 .. 50 }

(* descending order and decrement*)
printfn "The Sequence: %A" seq2

let seq3 = seq {50 .. -5 .. 0}
printfn "The Sequence: %A" seq3

(* using yield *)
let seq4 = seq { for a in 1 .. 10 do yield a, a*a, a*a*a }
printfn "The Sequence: %A" seq4

let a = 10
let deneme = seq{if a = 10 then "ondur" else "degil"}
printfn "%A" deneme