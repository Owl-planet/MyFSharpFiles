open System

type Student = 
    {
       Name : string;
       ID : int;
       RegistrationText : string;
       IsRegistered : bool;
    }

let getStudent name id =
   { Name = name; ID = id; RegistrationText = null; IsRegistered = false }

let registerStudent st =
    {
        st with
            RegistrationText = "Registered";
            IsRegistered = true;
    }

let printStudent msg st =
    printfn "%s : %A" msg st

let preRegisteredStudent = getStudent "Onur" 421
let postRegisteredStudent = registerStudent preRegisteredStudent

let main() =
    printStudent "Before reg : " preRegisteredStudent
    printStudent "After reg : " postRegisteredStudent
main()

let QueryStudent() =
    Console.Write("Öğrenci adını giriniz : ")
    let öğrenci = Console.ReadLine() |> string
    printfn "Sorgulanan öğrenci : %A" öğrenci
    if öğrenci = "Onur" then
        printfn "%A'un ID numarası : %A" öğrenci postRegisteredStudent.ID
    else
        printfn "Öğrenci bulunamadı"
QueryStudent() 