let function1 x = x + 1
let function2 x = x * 5
let lastfunction x = x*x
let f = function1 >> function2 >> lastfunction
let res = f 10
printfn "%d" res
