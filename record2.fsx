(* defining a record type named website *)
type website =
   { Title : string;
      Url : string }

(* creating some records *)
let homepage = { Title = "TutorialsPoint"; Url = "www.tutorialspoint.com" }
let cpage = { Title = "Learn C"; Url = "www.tutorialspoint.com/cprogramming/index.htm" }
let fsharppage = { Title = "Learn F#"; Url = "www.tutorialspoint.com/fsharp/index.htm" }
let csharppage = { Title = "Learn C#"; Url = "www.tutorialspoint.com/csharp/index.htm" }

(*printing records *)
(printfn "Home Page: Title: %A \n \t URL: %A") homepage.Title homepage.Url
(printfn "C Page: Title: %A \n \t URL: %A") cpage.Title cpage.Url
(printfn "F# Page: Title: %A \n \t URL: %A") fsharppage.Title fsharppage.Url
(printfn "C# Page: Title: %A \n \t URL: %A") csharppage.Title csharppage.Url