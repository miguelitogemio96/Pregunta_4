open System
    
[<EntryPoint>]
let main argv =
    let lista = [5;2;4;9;1;8;5;11;92;-7]
    let listaPar = [for i in lista do if i%2=0 then i]
    let listaInpar = [for i in lista do if i%2= 1 || i%2= -1 then i]
    for i in listaPar do
        printfn "Par: %i" i
    for i in listaInpar do
        printfn "Inpar: %i" i
    Console.ReadKey() |> ignore
    0 //devolver un código de salida entero