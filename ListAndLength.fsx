let pozitifSayılar = [ 1; 2; 3; 4; 5 ] 
let mutable a = 0
while (a <= pozitifSayılar.Length) do
   printfn "cevap: %i" a
   if (a = 3) then
      printfn "Sayı 3'e eşittir."
   a <- a + 1