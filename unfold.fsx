let seq1 = Seq.unfold (fun state -> if (state > 20) then None else Some(state, state + 1)) 0
printfn "The sequence seq1 contains numbers from 0 to 20."
for x in seq1 do printf "%d " x
printfn" "

(*
Analiz :
seq1 adında bir değişken, içinde unfold metotu, sonrasında anonim fonksiyon, eğer state büyükse 20'den None döndür, 
değilse state ilk state değeri sonra 1 eklenmiş versiyonu döndür, satate'nin değeri 0'dır.
for döngüsü var, seq1'deki elemanları alıyor ve sonra print ediyor.
*)