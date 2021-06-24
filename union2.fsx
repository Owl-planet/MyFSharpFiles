type Shape =
   // here we store the radius of a circle
   | Circle of float

   // here we store the side length.
   | Square of float

   // here we store the height and width.
   | Rectangle of float * float

let pi = 3.141592654

let area myShape =
   match myShape with
   | Circle radius -> pi * radius * radius
   | Square s -> s * s
   | Rectangle (h, w) -> h * w

let radius = 12.0
let myCircle = Circle(radius)
printfn "Area of circle with radius %g: %g" radius (area myCircle)

let side = 15.0
let mySquare = Square(side)
printfn "Area of square that has side %g: %g" side (area mySquare)

let height, width = 5.0, 8.0
let myRectangle = Rectangle(height, width)
printfn "Area of rectangle with height %g and width %g is %g" height width (area myRectangle)