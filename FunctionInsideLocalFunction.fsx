
// Fonksiyonların içinde yerel fonksiyonlar tanımlanabilir.
let birArttır x = 
    // Yerel fonksiyon tanımı. 
    // Kabuk fonksiyon olan birArttır'ın parametrelerine erişebilir.
    let birArttırİçFonksiyon() = 
        x + 1

    // Yerel fonksiyonu kabuk fonksiyon içinden kullan.
    birArttırİçFonksiyon()

// Fonksiyonu çağır.
birArttır 2