let geçerliDeğer = Some(1)
let geçersizDeğer = None

// Aşağıdaki örnekte Some ve None desen eşleme ile 
// birlikte kullanılmaktadır. 
// Desen eşleme yaparken Some ifadesinin çevrelediği değeri
// kolayca söküp kullanabiliriz
let optionKullanarakEşleme girdi =
   match girdi with
    | Some i -> printfn "Girdi değeri = %d" i
    | None -> printfn "Girdi değer belirtilmemiş"

// Ekrana "Girdi değeri = 42" basılacak.
optionKullanarakEşleme geçerliDeğer

// Ekrana "Girdi değer belirtilmemiş" basılacak.
optionKullanarakEşleme geçersizDeğer