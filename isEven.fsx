open System
let rec fiba n =
    match n with
    | 0 | 1 -> n
    | n -> fiba (n-1) + fiba (n-2)
Console.Write(fiba 9)