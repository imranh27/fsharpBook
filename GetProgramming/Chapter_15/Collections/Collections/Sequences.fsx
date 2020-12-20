
//Lesson 15.2

//.Net Arrays
let numbersArray = [| 1; 2; 3; 4; 5; 6 |]
numbersArray
let firstNumber = numbersArray.[0]
firstNumber
let firstThreeNumbers = numbersArray.[0 .. 2]
firstThreeNumbers
numbersArray.[0] <- 99
numbersArray

//Lists

let numbers = [ 1; 2; 3; 4; 5; 6 ]
numbers
let numbersQuick = [1 .. 6]
numbersQuick
let head :: tail  = numbers    //deconstruct list in to head and tail
let moreNumbers = 0 :: numbers
moreNumbers
let evenMoreNumbers = moreNumbers @ [ 7 .. 9 ]    //merging lists with @
evenMoreNumbers

let numbers2 = [ 1 .. 10 ]
let timesTwo n = n * 2
let outputImperative = ResizeArray()

for number in numbers2 do
   outputImperative.Add (number |> timesTwo )
   
outputImperative
   
let outputFunctional = numbers2 |> List.map timesTwo
outputFunctional


open System

[ DateTime(2010, 5, 1)
  DateTime(2010, 6, 1)
  DateTime(2010, 6, 12)
  DateTime(2010, 7, 3) ]
|> List.pairwise
|> List.map(fun (a, b) -> b - a)
|> List.map(fun time -> time.TotalDays)

//aggregate functions

let numbers3 = [ 1.0 .. 10.0 ]
let total = numbers3 |> List.sum
let average = numbers3 |> List.average
let max = numbers3 |> List.max
let min = numbers3 |> List.min

let numberOne =
    [ 1 .. 5 ]
    |> List.toArray
    |> Seq.ofArray
    |> Seq.head
    
    
open System.IO

let time = 
    let directory = Directory.GetCurrentDirectory()
    Directory.GetCreationTime directory
    
let directories =
    Directory.GetParent
    
directories
    
