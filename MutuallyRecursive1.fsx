(* 03_3_13.fsx *)

// -------------------  HATALI TANIM  ------------------- 
(* 
    Aşağıdaki karşılıklı öz yinelemeli fonksiyon tanımı.
    hatalıdır. Derleyici bu fonksiyonların tanımını 
    derlemez hata verir.
*)

// A fonksiyonu
let A() = 
    B()

// B fonksiyonu
let B() = 
    A()

(*
Karşılıklı Öz Yinelemeli Fonksiyonlar
Bazı fonksiyonlar kontrollü bir şekilde ve karşılıklı olarak birbirini çağırabilir. Bu tür fonksiyonlara karşılıklı öz yinelemeli (mutually recursive) fonksiyonlar denir.

F#’da dosyaların ve dosyalar içindeki fonksiyon, tip ve modül tanımlarının sırası önemlidir. Örneğin, bir fonksiyonun başka bir fonksiyon tarafından çağırılabilmesi için çağırıldığı kod satırından önce tanımlanmış olması gerekir. Aşağıdaki örneğimizde A fonksiyonu içindeki B() çağırısı geçersizdir, çünkü B fonksiyonu o noktada henüz tanımlı değildir.
*)