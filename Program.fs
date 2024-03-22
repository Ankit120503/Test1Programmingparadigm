// For more information see https://aka.ms/fsharp-console-apps
printfn "Federal Income Tax"
open System


let earnings = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let highIncome = earnings |> List.filter (fun x -> x > 100000)

let TaxCalculation (earnings:int) =
    match earnings with
    | s when s < 49020 -> earnings + 20000
    | s when s >= 49020 && s <= 100000 -> int(float(s) * 0.2)
    | _ -> int(float(earnings) * 0.3)

let taxAmounts = earnings |> List.map TaxCalculation

let sumMediumEarnings = earnings |> List.filter (fun x -> x >= 50000 && x <= 100000) |> List.sum

printfn "High-income earnings: $%A" (List.map string highIncome)
printfn "Taxes for all earnings: $%A" (List.map string taxAmounts)
printfn "Sum of earnings between $50,000 and $100,000: $%d" sumMediumEarnings

// Tail Recursion

let rec CalculateSumOf3 n acc =
    match n with
    | 0 -> acc
    | _ -> CalculateSumOf3 (n - 3) (acc + n)

// Example 
let result = CalculateSumOf3 27 0
printfn "Sum of multiples of 3 up to 27: %d" result
