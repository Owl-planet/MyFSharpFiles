(* let küplerinToplamı =
   List.sum ( List.map küp [ 1..100 ] )

// Bir fonksiyonun çıktısı sonraki fonksiyona 
// "|>" (ileri aktarım) operatörü ile aktarılır.
// Küplerin toplamı fonksiyonu |> kullanılarak 
// aşağıdaki gibi de yazılabilir


// [1..100] listesini List.map fonksiyonuna 
// ikinci parametresi olarak aktar.
// List.map fonksyonunun birinci parametresi küp fonksiyonudur.
// List.map sonucunu List.sum fonksiyonuna girdi olarak aktar.
let küplerinToplamı2 =
   [ 1 .. 100 ] |> List.map küp |> List.sum   *)

(* let a = 10 |> string |> int
printfn "%i" a *)

let küp x = x * x * x
let küplerinToplamı2 =
   [ 1 .. 100 ] |> List.map küp |> List.sum  
küplerinToplamı2