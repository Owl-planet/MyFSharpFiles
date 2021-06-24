open System

type switchstate =
    | On
    | Off
    | Adjustable of float
    
let toggle = function
    | On -> Off
    | Off -> On
    | Adjustable(brightness) ->
        (* Matches any switchstate of type Adjustable. Binds
        the value passed into the constructor to the variable
        'brightness'. Toggles dimness around the halfway point. *)
        let pivot = 0.5
        if brightness <= pivot then
            Adjustable(brightness + pivot)
        else
            Adjustable(brightness - pivot)

let main() =
    let x = On
    let y = Off
    let z = Adjustable(0.25) (* takes a float in constructor *)
    
    printfn "x: %A" x
    printfn "y: %A" y
    printfn "z: %A" z
    printfn "toggle z: %A" (toggle z)
    
    Console.ReadKey(true) |> ignore
    
main()