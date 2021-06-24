pozitifSayılar = [1;2;3;4;]
let çiftSayılar liste =
    // çiftMi fonksiyonunu iç fonksiyon olarak tanımla.
    let çiftMi x = x % 2 = 0    

    // filter fonksiyonu List modülü içinde tanımlıdır.
    // filter girdi olarak bir fonksiyon parametresi ve 
    // bu fonksiyonu uygulayacağı listeyi alır.
    List.filter çiftMi liste    

// Fonksiyonu çalıştır.
çiftSayılar pozitifSayılar 