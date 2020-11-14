//Customer
type Customer = 
    { CustomerID : System.Guid
      CustomerName : string}


//Bank account
type Account = 
    { Customer : Customer
      AccountID : System.Guid
      Deposit : decimal
      Withdrawal : decimal
      Balance : decimal}



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

//audit functions
open System.IO
open System


let fileSystemAudit account message =
     let path = @"C:\Users\ihashmi\Source\github\fsharpBook\GetProgrammming\Projects\Capstone2\output"

     let directoryName = account.Customer.CustomerName

     let directoryPath = sprintf "%s\%s" path directoryName

     let directoryExists = Directory.Exists(directoryPath)

     if not directoryExists
         then Directory.CreateDirectory(directoryPath) |> ignore

     let fileName = account.Customer.CustomerID.ToString()

     let fullPath = sprintf "%s\%s.txt" directoryPath fileName

     let textOut = message + Environment.NewLine 

     File.AppendAllText(fullPath, textOut)

 

let consoleAudit account message =
    Console.WriteLine("Account: {0}: {1}", account.AccountID, message)


//Orchestration Function
let auditAs (operationName:string) (audit:Account -> string -> unit) (operation:decimal -> Account -> Account) (amount:decimal) (account:Account) : Account =
    
    let auditMessage = sprintf "%s of %s" operationName (amount.ToString())

    let returnAccount = operation amount account

    audit account auditMessage 
    
    returnAccount







//Testing


//define customer
let Bill = 
    { CustomerID = System.Guid.NewGuid()
      CustomerName = "Bill"}

//define account
let account1 = 
    { Customer = Bill
      AccountID = System.Guid.NewGuid()
      Deposit = 100.1m
      Withdrawal = 0.0m
      Balance = 100.0m
    }


account1.Customer.CustomerName
account1.Balance

account1
|> deposit 100M
|> withdraw 50M





deposit 800m account1

withdraw 400m account1

account1.Balance


fileSystemAudit account1 "Hello2"

consoleAudit account1 "A test message"




account1
|> deposit 100M
|> withdraw 50M

let withdrawWithConsoleAudit = auditAs "withdraw" consoleAudit withdraw
let depositWithConsoleAudit = auditAs "deposit" consoleAudit deposit

account1
|> depositWithConsoleAudit 100M
|> withdrawWithConsoleAudit 50M


open System

Console.Write("Enter name")
let nameIn = Console.ReadLine()

Console.WriteLine( sprintf "you entered %s" nameIn)


while true do
    let input = 
        Console.Write("Enter name: x to exit")
        Console.ReadLine()
  
  
        
    
    

