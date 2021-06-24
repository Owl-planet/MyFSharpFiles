(* Creating sequences *)
let emptySeq = Seq.empty
let seq1 = Seq.singleton 20

printfn"The singleton sequence:"
printfn "%A " seq1
printfn"The init sequence:"

let seq2 = Seq.init 5 (fun n -> n * 3)
Seq.iter (fun i -> printf "%d " i) seq2
printfn""

(* converting an array to sequence by using cast *)
printfn"The array sequence 1:"
let seq3 = [| 1 .. 10 |] :> seq<int>
Seq.iter (fun i -> printf "%d " i) seq3
printfn""

(* converting an array to sequence by using Seq.ofArray *)
printfn"The array sequence 2:"
let seq4 = [| 2..2.. 20 |] |> Seq.ofArray
Seq.iter (fun i -> printf "%d " i) seq4 