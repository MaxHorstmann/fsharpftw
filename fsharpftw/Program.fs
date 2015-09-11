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






    
    
    0 // return an integer exit code
