module FirstLab

(* First Task
let rec f (x:int) =
    if (x = 1)
    then
        x
    else x * f ( x- 1)

let value = f 5

printfn "%i" value
*)

(* Second Task
let CountVolume r =
    let result = float (((float(4) * 3.14) * pown r 3)) / float(3)
    result

let a = CountVolume 10;
printfn "%f" a
*)

(* Third Task
let FirstFunction value =
    let result = pown value 2
    result

let SecondFunction value = 
    let result = float(value) * float(3)
    result

let result = 10 |> FirstFunction |> SecondFunction
printfn "%f" result
*)

(* Fourth Task
let countAverage a b c =
    let sum = a + b + c
    let result = float(sum) / float(3)
    result

let result = countAverage 1 2 3
printfn "%f" result
*)

(* Fifth Task
let CountElectricity U R r =
    let sumR = R + r;
    let result = float(U) / float(sumR)
    result

let result = CountElectricity 10 2 3
printfn "%f" result
*)

(*Sixth Task
let FindD a b c =
    let result = pown b 2 - float(4) * a * c
    result

let result = FindD 1 2 1
printfn "%f" result
*)

(* Seventh Task
let FindS a h = 
    let result = a * float(h) / float(2)
    result

let result = FindS 2 4
printfn "%f" result
*)

(* Eighth Task
let ZooFunction bears straus giraffe =
    let result = bears * float(4) + straus * float(2) + giraffe * float(4)
    result

let result = ZooFunction 2 3 1
printfn "%f" result
*)

(* Nineth Task
let FindFiles a b = 
    let result = float(a) / b
    result

let result = FindFiles 521 0.064
printfn "%f" result
*)

let FindVolumeKettle h r =
    let result = 3.14 * pown r 2 * h
    result

let result = FindVolumeKettle 25 7
printfn "%f" result

