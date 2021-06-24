(* Create an empty Map *)
let students =
   Map.empty. (* Creating an empty Map *)
      Add("Zara Ali", "1501").
      Add("Rishita Gupta", "1502").
      Add("Robin Sahoo", "1503").
      Add("Gillian Megan", "1504");;
printfn "Map - students: %A" students

(* Convert a list to Map *)
let capitals =
   [ "Argentina", "Buenos Aires";
      "France ", "Paris";
      "Chili", "Santiago";
      "Malaysia", " Kuala Lumpur";
      "Switzerland", "Bern" ] |> Map.ofList;;
printfn "Map capitals : %A" capitals