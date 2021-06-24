let x = "Değiştirilemez değer"
let mutable y = "Değiştirilebilir değer"
y <- "Yeni değer atama"
printfn "Let : %s | Let mutable : %s | <- : %s" x y y

let mutable num1 = 10
let mutable num2 = 20
let mutable z = num1 + num2
printfn "num1 ve num2'nin toplamı : %i" z
num1 <- 20
z <- num1 + num2
printfn "num1 ve num2'nin toplamı : %i" z