module Auditing

//audit functions
open System.IO
open System
open Capstone2.Domain


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