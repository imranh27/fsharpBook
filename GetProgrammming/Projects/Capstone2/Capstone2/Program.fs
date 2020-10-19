
open System
open Capstone2.Domain
open Operations


let depositWithAudit = deposit |> auditAs "deposit" Auditing.consoleAudit
let withdrawWithAudit = withdraw |> auditAs "withdraw" Auditing.consoleAudit



[<EntryPoint>]
let main argv =

    let mutable account = createAccount    

    while true do 

        let action = getAction
        if action = "x" then Environment.Exit 0
        let amount = getAmount

        account <- 
            if action = "d" then account |> depositWithAudit amount
            elif action = "w" then account |> withdrawWithAudit amount
            else account

    0 // return an integer exit code
