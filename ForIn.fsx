let list1 = [ 10; 25; 34; 45; 78 ]
for i in list1 do
   printfn "%d" i

// Looping over a sequence.
let seq1 = seq { for i in 1 .. 10 -> (i, i*i) }
for (a, asqr) in seq1 do
   printfn "%d squared is %d" a asqr

(* 
Analiz : 

1. List1 adında array var ve içinde 5 değer var
2. for döngüsünü başlatıyor test değeri i ve list1'e eşittir...
3. i değerini decimal'a atıyor
Liste döndü

4. seq1 adında değiştirelemez bir değer
25
34
45
78
1 squared is 1
2 squared is 4
3 squared is 9
4 squared is 16
5 squared is 25
6 squared is 36
7 squared is 49
8 squared is 64
9 squared is 81
10 squared is 100
(i, i*i)
`her döndüğünde artar 1,2,3,4,5....
ve arttığı değerle değeri çarpar
1x1,2x2,3x3
döngü oluşturmuş a ve asqr şeklinde arsgele değer alıyor bunlar i ve i*i
sonra bunları "..." a asqr şeklinde yazıdırıyor
*)