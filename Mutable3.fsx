open System

type studentData =
   { ID : int;
      mutable IsRegistered : bool;
      mutable RegisteredText : string; }

let getStudent id =
   { ID = id;
      IsRegistered = false;
      RegisteredText = null; }

let registerStudents (students : studentData list) =
   students |> List.iter(fun st ->
      st.IsRegistered <- true
      st.RegisteredText <- sprintf "Registered %s" (DateTime.Now.ToString("hh:mm:ss"))

      Threading.Thread.Sleep(1000) (* Putting thread to sleep for 1 second to simulate processing overhead. *))

let printData (students : studentData list) =
   students |> List.iter (fun x -> printfn "%A" x)

let main() =
   let students = List.init 3 getStudent

   printfn "Before Process:"
   printData students

   printfn "After process:"
   registerStudents students
   printData students

   Console.ReadKey(true) |> ignore

main()