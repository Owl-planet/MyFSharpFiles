type VoltageState =
   | High
   | Low

let toggleSwitch = function (* pattern matching input *)
   | High -> Low
   | Low -> High

let main() =
   let on = High
   let off = Low
   let change = toggleSwitch off

   printfn "Switch on state: %A" on
   printfn "Switch off state: %A" off
   printfn "Toggle off: %A" change
   printfn "Toggle the Changed state: %A" (toggleSwitch change)

main()