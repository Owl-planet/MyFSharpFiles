(* Create an empty Map *)
let students =
   Map.empty. (* Creating an empty Map *)
      Add("Zara Ali", "1501").
      Add("Rishita Gupta", "1502").
      Add("Robin Sahoo", "1503").
      Add("Gillian Megan", "1504").
      Add("Shraddha Dubey", "1505").
      Add("Novonil Sarker", "1506").
      Add("Joan Paul", "1507");;
printfn "Map - students: %A" students
printfn "Map - number of students: %d" students.Count

(* finding the registration number of a student*)
let found = students.TryFind "Rishita Gupta"
match found with
| Some x -> printfn "Found %s." x
| None -> printfn "Did not find the specified value."