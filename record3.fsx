open System

type student =
   { Name : string;
      ID : int;
      RegistrationText : string;
      IsRegistered : bool }

let getStudent name id =
   { Name = name; ID = id; RegistrationText = null; IsRegistered = false }

let registerStudent st =
   { st with
      RegistrationText = "Registered";
      IsRegistered = true }

let printStudent msg st =
   printfn "%s: %A" msg st

let main() =
   let preRegisteredStudent = getStudent "Zara" 10
   let postRegisteredStudent = registerStudent preRegisteredStudent
   printStudent "Before Registration: " preRegisteredStudent
   printStudent "After Registration: " postRegisteredStudent

main()