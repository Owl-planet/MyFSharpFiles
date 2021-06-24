let collectTesting inputS =
   String.collect (fun c -> sprintf "%c " c) inputS
printfn "%s" (collectTesting "Happy New Year!")

// String.collect : String.collect işlevi, 
// karakterleri, giriş dizesinin karakterlerinin 
// her birine belirli bir işlevi uygulamanın ve elde 
// edilen dizeleri birleştirmenin sonuçları olan yeni bir dize oluşturur.

(* Analiz : 

collectTesting adında bir fonksiyon oluşturuldu ve inputS adında bir parametre alıyor.
String.collect özelliği kullanılmış ve karşısında ilk çalışacak anonymous fonksiyon yazılmış,
c adında bir parametre alıyor, 

*)