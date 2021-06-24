let küplerinToplamı =
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
   [ 1 .. 100 ] |> List.map küp |> List.sum  

// "fun" anahtar kelimesini kullanılarak 
// adsız (anonim) fonksiyonlar tanımlanır.
let küplerinToplamı3 =
    // fun x -> x * x * x anonim bir fonksiyon tanımıdır.
   [ 1 .. 100 ] |> List.map (fun x -> x * x * x) |> List.sum
