
//Lesson 18 - Folds

//18.2 imperative sum

open System.Diagnostics.Tracing
let sum inputs =
    let mutable accumulator = 0
    for input in inputs do
        accumulator <- accumulator + input
    accumulator
    
//length of list
let length inputs =
    let mutable accumulator = 0
    for input in inputs do
        accumulator <- accumulator + 1
    accumulator

//Maximum value of list
let maximum inputs =
    let mutable accumulator = 0
    let mutable maxValue = 0
    for input in inputs do
        if maxValue < input
          then maxValue <- input
        accumulator <- accumulator + 1
    maxValue
    
 //Folds
let sum2 inputs =
     Seq.fold
     (fun state input -> state + input)
     0
     inputs
     
let length2 inputs =
    Seq.fold (fun state input -> state + 1 ) 0 inputs
    
let max2 inputs =
    Seq.fold (fun state input -> if state < input then input else state) 0 inputs
    
    
let list = [ 1 ; 2 ; 3 ;  3 ;  3 ; 5 ]

sum2 list
length2 list
max2 list

//making folds more readable
Seq.fold (fun state input -> state + input)  0 inputs
inputs |> Seq.fold(fun state input -> state + input) 0
(0, inputs) ||> Seq.fold(fun state input -> state + input)     //moves input parameters to the right.


//18.3 Composing Functions
open System
type Rule = string -> bool * string

let rules : Rule list =
    [
        fun text -> (text.Split ' ').Length = 3, "Must be three words"
        fun text -> text.Length <= 30, "Max length is 30 characters"
        fun text -> text
                    |> Seq.filter Char.IsLetter
                    |> Seq.forall Char.IsUpper, "All letters must be caps"
    ]
    
//18.10 Using reduce
let buildValidator (rules : Rule list) =
    rules
    |> List.reduce(fun firstRule secondRule ->
        fun word ->                                     
            let passed, error = firstRule word          
            if passed then                              
                let passed, error = secondRule word
                if passed then true, "" else false, error
            else false, error)                          

let validate = buildValidator rules
let word = "HELLO FrOM F#"

validate word

// val it : bool * string = (false, "All letters must be caps")





     
 
 