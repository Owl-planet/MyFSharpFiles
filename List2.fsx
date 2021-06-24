// Elamanları 1 ile 100 arasında olan ve 1'den itibaren
// 2 artarak oluşturulan sayılar olan liste.
let liste101 = [ 1..2..100 ]
let listem = [1;2;3;4;5;6;]

// :: operatörü var olan listenin başına 
// 0 değerini ekleyerek yeni bir liste oluşturur.
// doğalSayılar listesinin içeriği [0;1;2;3;4;5] olur.
let doğalSayılar = 0 :: listem
printfn "%A" doğalSayılar

// @ operatörü ile iki liste birleştirilip 
// yeni bir liste oluşturulur.
// tamSayılar listesinin içeriği [-5;-4;-3;-2;-1;0;1;2;3;4;5] 
// olur.
let tamSayılar = [ -5; -4; -3; -2; -1 ] @ listem
printfn "%A" tamSayılar

let element = "1"