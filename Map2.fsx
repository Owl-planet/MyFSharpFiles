(* Create an empty Map *)
let students =
   Map.empty. (* Creating an empty Map *)
      Add("Zara Ali", "1501").
      Add("Rishita Gupta", "1502").
      Add("Robin Sahoo", "1503").
      Add("Gillian Megan", "1504");;
printfn "Map - students: %A" students

(*Accessing an element using key *)
printfn "%A" students.["Zara Ali"]