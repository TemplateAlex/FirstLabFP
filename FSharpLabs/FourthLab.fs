module FourthLab

let FirstTask() =
    let list = [1..4]
    let secondList = [for elem in list do yield pown elem 2];
    let thirdList = [for elem in list do yield pown elem 3];
    let mutable sumSecondDegreeList = 0;
    let mutable sumThirdDegreeList = 0;

    for i = 0 to list.Length - 1 do
        sumSecondDegreeList <- sumSecondDegreeList + secondList[i];
        sumThirdDegreeList <- sumThirdDegreeList + thirdList[i];

    printfn "%A" secondList;
    printfn "%A" thirdList;
    printfn "%d %d" sumSecondDegreeList sumThirdDegreeList

let SecondTask() =
    let menListAges: list<double> = [25; 37; 48; 60];
    let womenListAges: list<double> = [28; 43];

    let averageAgesMen = List.average menListAges;
    let averageAgesWomen = List.average womenListAges;
    printfn "%A %A" averageAgesMen averageAgesWomen

let ThirdTask() =
    let listOklad: list<float> = [float(10); float(11); 12.5; float(15); float(13); 7.5];
    let newListOklad: list<float> = [for elem in listOklad do (float(elem) * float(1.15))];
    printfn "%A" newListOklad;

let FourthTask() =
    let firstArrOfCandys: list<double> = [10; 3; 7; 0];
    let averageCandys = List.average firstArrOfCandys;

    for elem in firstArrOfCandys do
        if (averageCandys - elem > 0) then
            let result = averageCandys - elem;
            printfn "Give: %A" result
        else
            let result = elem - averageCandys;
            printfn "Take: %A" result;

let FifthTask() =
    let list = [1 .. 20];

    let newList = [for elem in list do
                        if elem % 2 = 0 then
                            pown elem 2
                        else
                            elem]

    printfn "%A" newList

let SixthTask() =
    let list = [1 .. 20]

    let newList = [for elem in list do
                        if elem % 4 = 0 then
                            elem]
    printfn "%A" newList;

let SeventhTask() = 
    let mutable counter = 0;

    let list = [1 .. 20];

    for elem in list do
        if elem % 3 = 0 then
            counter <- counter + 1

    let result = list.Length - counter;
    printfn "%A" result;

let EighthTask() =
    let list = ['a'; 'b'; 'c'; 'd'];
    let secondList = ['e'; 'f'; 'g'];
    let thirdList = ['h'; 'i'];
    let generalList = list @ secondList @ thirdList;
    printfn "%A" generalList;

let NinethTask() =
    let listOfThree = [for elem in [1 .. 20] do
                        if elem % 3 = 0 then
                            pown elem 2];
    let listOfFive = [for elem in [1 .. 20] do
                        if elem % 5 = 0 then
                            pown elem 3]
    let list = listOfThree @ listOfFive;
    printfn "%A" list;

let TenthTask() =
    let list = [1 .. 5];
    printfn "%A" list.Length;
    printfn "%A" list.Head;
    printfn "%A" list.Tail;
    printfn "%A" (list.Item(1));
    printfn "%A" list.IsEmpty;
