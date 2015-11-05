//// Learn more about F# at http://fsharp.org
//// See the 'F# Tutorial' project for more help.
open System
let checkvalue (argv : string []) : int =
//funcion para checar si el valor se puede convertir a int
    if argv.Length > 0 then      
        let couldparse, consolein = Int32.TryParse(argv.[0])
        if couldparse then consolein
        else
            let canparse, keyin = Int32.TryParse(Console.ReadLine())
            if canparse then keyin
            else 0
    else
        let canparse, keyin = Int32.TryParse(Console.ReadLine())
        if canparse then keyin
        else 0

let fibonacci n = // No es recursiva
    let mutable first = 0
    let mutable second = 1
    let mutable temp = 0
    for index = 1 to n do
        temp <- first + second
        first <- second
        second <- temp
    first

let rec fibonaccirec n = 
// la palabra rec indica al compilador que es recursiva
    if n =  0 then 0
    elif n <= 2 then 1
    else
        fibonaccirec (n - 1) + fibonaccirec (n - 2)

[<EntryPoint>] // entrada de la aplicacion
let main argv = //funcion main
    let input = checkvalue argv // checamos que el valor ingresado sea parseable a int 
    let calc = fibonacci input // usamos el numero para la funcion de fibonacci
    let recalc = fibonaccirec input // usamos en esta ocasion la funcion recursiva
    printf "Calculo No recursivo de fibonacci: %d\nCalculo Recursivo %d"  calc recalc // escribimos el resultado
    Console.ReadKey() // esperamos al usuario
    0 // return an integer exit code
