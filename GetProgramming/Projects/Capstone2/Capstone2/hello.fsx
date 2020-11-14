open System

while true do
    
    Console.Write("Whats your name? ")
    let input = Console.ReadLine()
    if input = "x" then Environment.Exit 0

    Console.WriteLine(sprintf "so you are called %s?" input)


