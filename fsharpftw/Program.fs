[<EntryPoint>]
let main argv = 
    let square x = x * x
    
    [1..100] 
      |> List.map square 
      |> printfn "%A"
    
    
    0 // return an integer exit code
