type choice =
   | Yes
   | No

let x = Yes (* creates an instance of choice *)
let y = No (* creates another instance of choice *)
let main() =
   printfn "x: %A" x
   printfn "y: %A" y
main()