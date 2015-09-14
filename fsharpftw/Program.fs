type Customer = { Id:int; TotalSales:int; Name:string option }    
type Account = { Id:int; Customer:Customer option}


[<EntryPoint>]
let main argv = 
    let square x = x * x
    
    [1..100] 
      |> List.map square 
      |> printfn "%A"

    let foo = 123
    let fooasbyte = byte foo

    let genericfunction x = 
       printfn "%A" x
       

    let keyAccount = { 
        Id=1; 
        Customer=Some({Id=1;TotalSales=400;Name=Some("Foo Bar")})
        }

    match keyAccount.Customer with
        | Some(c) -> printfn "%A" keyAccount.Customer.Value.Name
        | None -> printfn "undefined"

    let customers = [ {Id=1;TotalSales=500;Name=None};{Id=3;TotalSales=1500;Name=None};{Id=4;TotalSales=100;Name=None}  ]

    let findBestCustomer list =
        let innerBestCustomer first rest =
            let action bestSoFar x = if bestSoFar.TotalSales<x.TotalSales then x else bestSoFar
            rest |> List.fold action first
        match list with
        | [] ->
            None
        | first::rest ->
            let max = innerBestCustomer first rest
            Some max

    customers |> findBestCustomer |>  printfn "best customer: %A"       
    
    
   // customers |> List.maxBy (fun x -> x.TotalSales) |> printfn "best customer: %A"

   




     





    
    
    0 // return an integer exit code
