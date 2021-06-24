printfn "First member: %A" (fst(23, 30))
printfn "Second member: %A" (snd(23, 30))

printfn "First member: %A" (fst("Hello", "World!"))
printfn "Second member: %A" (snd("Hello", "World!"))

let nameTuple = ("Zara", "Ali")

printfn "First Name: %A" (fst nameTuple)
printfn "Second Name: %A" (snd nameTuple)