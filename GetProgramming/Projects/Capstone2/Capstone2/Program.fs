open System
open Capstone2.Domain
open Operations


[<EntryPoint>]
let main argv =

    let mutable account = createAccount
    
    let depositWithAudit = deposit |> auditAs "deposit" Auditing.consoleAudit
    let withdrawWithAudit = withdraw |> auditAs "withdraw" Auditing.consoleAudit

    while true do
        
        let action =
            Console.WriteLine()
            printfn "Current balance is £%M" account.Balance
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            Console.ReadLine()

        if action = "x" then Environment.Exit 0

        let amount =
            Console.Write "Amount: "
            Console.ReadLine() |> Decimal.Parse

        account <- 
                if action = "d" then account |> depositWithAudit amount
                elif action = "w" then account |> withdrawWithAudit amount
                else account

    0 // return an integer exit code