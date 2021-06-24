// the function returns the larger value between two
// arguments

let max num1 num2 : int32 =
   // function body
   if(num1>num2)then
      num1
   else
      num2

let res = max 39 52
printfn " Max Value: %d " res