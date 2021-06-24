open System
Console.Write("Yaşınızı giriniz : ")
let yaş = Console.ReadLine() |> int
let mutable listem = []
let hesapla (x) = 
    let mutable cevap = 2021-x:int
    listem <- x :: listem
    printfn "cevap : %i" cevap
    printfn "%A" listem


hesapla yaş