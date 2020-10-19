

//Higher Order Functions

(*
type Customer = { Age : int }

let where filter customers = 
    seq {for customer in customers do
            if filter customer then 
               yield customer}

let customers = [ { Age = 21 }; { Age = 35 }; { Age = 36 } ]

let isOver35 customer = customer.Age > 35

customers |> where isOver35                                 //uses function
customers |> where (fun customer -> customer.Age > 35)      //uses lambda
*)




open System
open System.IO

type Customer = { Age : int }

let printCustomerAge writer Customer = 
    if Customer.Age < 11 then writer "Child"
    elif Customer.Age < 20 then writer "Teenager"
    else writer "Adult"


let Bill = { Age = 25 }  //define a customer
let Bob = { Age = 4}
let Peter = { Age = 17  }

//printCustomerAge Console.WriteLine Bill

let printToConsole = printCustomerAge Console.WriteLine

printToConsole Bill
printToConsole Bob
printToConsole Peter


let writeToFile text = 
    File.WriteAllText(@"C:\Users\ihashmi\Source\github\fsharpBook\GetProgrammming\Chapter_02\MyFirstFhsarpApp2\MyFirstFhsarpApp2\Files\13_3\output.txt",  text)

let printToFile = printCustomerAge writeToFile

printToFile Bill












  