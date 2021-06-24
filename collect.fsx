let collectTesting inputS =
   String.collect (fun c -> sprintf "%c " c) inputS
printfn "%s" (collectTesting "Happy New Year!")