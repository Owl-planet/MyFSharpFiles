let list6 = 
    [ 
        for a in 1 .. 10 do 
            yield (a * a)
    ]
printfn "%A" list6

// 1*1 2*2 3*3 4*4 5*5 6*6 7*7 8*8 9*9 10*10