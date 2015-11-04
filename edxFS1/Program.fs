// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System //importamos la libreria

[<EntryPoint>] // indicamos que aqui inicia el programa
let main argv = 
    Console.Write("Please enter how far you traveled: ") //syso
    let distance = Console.ReadLine() // lee el valor ingresado en la consola
    let distance = float distance // convertimos el valor a un dato tipo float
    Console.Write("Please how much fuiel you used: ")
    let fuel = Console.ReadLine()
    let fuel = float fuel
    let consumption = distance / fuel //creamos la funcion que mide la eficiencia del combustible
    Console.WriteLine("Your car does a distance of " +
        (string consumption) + " per single unit of fuel ")
    Console.ReadKey() // previene que el programa se cierre
    0 // return an integer exit code
