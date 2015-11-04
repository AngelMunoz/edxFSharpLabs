// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
// formula for the volume of the cylinder
let cilivol (r: float) (h:float) = Math.PI * (Math.Pow(r, 2.0) * h)
[<EntryPoint>]
let main argv = 
    printfn "Please enter the Radius of the Cylinder: " 
    let rad = Console.ReadLine() //read from the console - Side Effect
    let radius  = float rad //parse to float
    printfn "Please enter the Height of the Cylinder: " 
    let hei = Console.ReadLine() // read from the Console - Side Effect
    let height  = float hei // parse to float
    let result = cilivol radius height //calculate
    printf "The Volume of the Cylinder is: %f" result //output to the console - Side Effect
    Console.ReadKey() // Wait for the user to tap out
    0 // return an integer exit code
