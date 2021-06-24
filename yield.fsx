let rec qq x = 
    seq {yield x ; yield! qq (x + 1) }

printfn "%A" <| qq 1