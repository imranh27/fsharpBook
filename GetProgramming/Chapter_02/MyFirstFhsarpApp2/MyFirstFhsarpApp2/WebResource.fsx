
open System
open System.Net
open System.Windows.Forms                               



let thesite url = 
    let webClient = new WebClient()
    webClient.DownloadString(Uri url)


let url = "http://fsharp.org"
let website = thesite url

let browser =
    new WebBrowser(ScriptErrorsSuppressed = true,
                   Dock = DockStyle.Fill,
                   DocumentText = website)    
                   
let form = new Form(Text = "Hello from F#!")
form.Controls.Add browser
form.Show()