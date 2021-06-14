let rec length = function
    | [] -> 0
    | x::xs -> 1 + length xs

let rec factorial n =
    if n < 2 then  
        1
    else
        n * factorial (n - 1)

let rec recursion n =
    if n > 3 then
        3
     else
        printfn "%i" n
        recursion <| n + 1

7.
    |> sin
    |> ((*)2.)

let (^) x y = x ** y

[1;2;3;4]
    |> List.filter (fun i -> i % 2 = 0)
    |> List.map ((*)2)
    |> List.sum

let minus1 x = x - 1
let times2 = (*) 2
times2 << minus1 <| 9


let times x y = x * y
times <|| 8 8 
let mul (x:int) (y:int) = x * y
let add (x:int) (y:int) = x + y
let pythagoras (x:int) (y:int) = add << add <|| 22 

