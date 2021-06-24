do printfn "Program çalışmaya başladı"

// .... Program kodunuz
let kare x = x * x
printfn "2'nin karesi = %d" (kare 2)


module Modül1 =
    printfn "Modül çalışmaya baladı"
    let kare x = x * x
    printfn "Modül çalışması tamamlandı"

do printfn "Program sonlandı"

let b = 13
do if b = 13 then "Good" else "Bad" |> ignore