let averageFour (a, b, c, d) =
   let sum = a + b + c + d
   sum / 4.0

let avg:float = averageFour (4.0, 5.1, 8.0, 12.0)
printfn "Avg of four numbers: %f" avg