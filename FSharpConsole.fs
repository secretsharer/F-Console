module Bob
open System
open System.Runtime.InteropServices.ComTypes


let stringInput (input: string): string = Console.ReadLine()

type WhatISay = {
    Question: string
    Yelling: string
    SilentAddress: string
    EverythingElse: string
    WhiteSpace: string
}

// type BobsResponse = {
//     Whatever: string
//     Fine: string
//     Whoa: string
//     Sure: string

// }

let BR = new BobsResponse 
(
    Fine = "Fine. Be that way!"
    Whoa = "Whoa, chill out!"
    Sure = "Sure."

) 


let decideWhichResponse (WhatISay : string) 
     let responseCheck = Enum.GetValues(typeof<WhatISay>) |> Seq.cast<WhatISay>  
      for WhatISay in WhatISay do
       match WhatISay with
        | x when Seq.contains "  ", " ", "", "\t\t\t\t\t\t\t\t\t\t"  x -> bobsResponse.Whatever
        | x when Seq.last.Equals("?") x -> bobsResponse.Sure
        | x when Seq.last.Equals("!") x -> bobsResponse.Whoa
        | x when Seq.contains whatISay.EverythingElse x -> bobsResponse.Whatever
        | _ -> failwith failwith "*******<Teenagers>*******."

     
    let response() = Console.WriteLine(decideWhichResponse)
    
//     *******************************
    
module Leap

let leapYear (year: int) : bool =
   match year with 
    | x when x % 4 <> 0 -> false
    | x when x % 100 = 0 && x % 400 <> 0 -> false
    | x when x % 4 = 0 && x % 100 <> 0 -> true 
    | x when x % 400 = 0 -> true 
    |_-> true
