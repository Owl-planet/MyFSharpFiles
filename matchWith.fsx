let basitDesenEşleme =
   let x = 1
   match x with
    | 1 -> printfn "x'in değer 1"
    | 2 -> printfn "x'in değeri 2"
    // _ simgesi herhangi bir değeri eşlemek için 
    // joker olarak kullanılır
    | _ -> printfn "x'in değeri 1 veya 2 değil" 
