let mutable x = 10
let y = 20
let mutable z = x + y

printfn "Original Values:"
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z

printfn "Let us change the value of x"
printfn "Value of z will change too."

x <- 15
z <- x + y

printfn "New Values:"
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z