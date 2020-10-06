// Learn more about F# at http://fsharp.org

open System

let Months = [31; 28; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]

let IsLeap year =
     ((year % 4 = 0) && not (year % 100 = 0) || (year % 400 = 0))

let DaysInMonth =
    30

let CalculateTwoArrays array1 array2 =
    let total = Seq.zip array1 array2 |> Seq.map (fun (x,y) -> x + y)

    total

let CreateAllDaysInAMonth month =
    let days = Months.Item month - 1
    let res = seq { 1 .. days } |> Seq.map( fun x -> sprintf "%02i%02i" x month)
    res

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
