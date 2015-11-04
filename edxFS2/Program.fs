open System
// Hexagonal area formula
let hexarea t: float = (3.0 * Math.Sqrt(3.0) / 2.0) * Math.Pow(t, 2.0)
[<EntryPoint>]
let main argv =
    printf "Please Enter the length of the side of the hexagon: "
    let value = Console.ReadLine() //read value from console - Side Effect
    let f = float value // we parse the value to a float into f
    let calc = hexarea f // we calculate the area with f value
    // display on screen - Side Effect
    printf "The Area of the Hexagon is: %f" calc
    Console.ReadKey()
    0 // return an integer exit code
