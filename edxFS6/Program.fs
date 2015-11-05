open System
let GRatio  = 0.5 + 0.5 * Math.Sqrt 5.0 // golden ratio formula
let buildList  (len: int) = [ // function to build the list with the tuple
    for i = 0 to len-1 do // fill the list with the length provided
        printf "Please enter a number: " // ask for a number
        let number = Console.ReadLine() // read the number
        let number = float number // parse the number
        yield number, number * GRatio // store the number and the product of the number and the golden ratio
    ]
[<EntryPoint>] 
let main argv =
    printf "Please enter the length of your list: "  // ask for list's length
    let listLen =  Console.ReadLine() // read the lenght
    let listLen = int listLen // parse to integer
    let list = buildList listLen // build the list
    for x in list do // loop over the list
        printf "%A" x // print the tuples
    Console.ReadKey() |> ignore // wait for the user
    0 // succesful exit code