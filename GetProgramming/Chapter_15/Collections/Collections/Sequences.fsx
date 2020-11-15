
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

