
module Operations

open Capstone2.Domain
open System

//define deposit
let deposit amount account = 
    let updatedAccount = 
        {account with
          Deposit = amount
          Balance = account.Balance + amount}
    updatedAccount


//define withdraw
let withdraw amount account =
    if amount > account.Balance
       then account
    else 
        let updatedAccount = 
            {account with
              Withdrawal = amount
              Balance = account.Balance - amount}
        updatedAccount


//Orchestration Function
let auditAs (operationName:string) (audit:Account -> string -> unit) (operation:decimal -> Account -> Account) (amount:decimal) (account:Account) : Account =
    
    let auditMessage = sprintf "%s of %s" operationName (amount.ToString())

    let returnAccount = operation amount account

    audit account auditMessage 
    
    returnAccount


//Build Account
let getName =
    Console.WriteLine("Enter name")
    Console.ReadLine()

let getOpeningBalance = 
    Console.WriteLine("Enter opening Balance")
    Decimal.Parse(Console.ReadLine())


let createAccount = 
    let nameIn = getName
    let openingBalance = getOpeningBalance

    let thisCustomer = 
        { CustomerID = System.Guid.NewGuid()
          CustomerName = getName}

    let thisAccount = 
        { Customer = thisCustomer
          AccountID = System.Guid.NewGuid()
          Deposit = 0m
          Withdrawal = 0m
          Balance = openingBalance
        }

    thisAccount


//Do Stuff
let getAction =
    Console.WriteLine("What do you wish to do? Deposit = d, Withdrawal = w, Exit = x")
    Console.ReadLine()


let getAmount = 
    Console.WriteLine("How much?")
    Decimal.Parse(Console.ReadLine())
