module ThirdLab

let FirstTask() = 
    let x = 1;
    let y = 2;
    let z = 3;
    let general = x + y + z;
    let summerGeneral = x + y;
    (general, summerGeneral);

let SecondTask() =
    let firstCoef: double = double(1);
    let secondCoef: double = double(15) * double(firstCoef) / double(10);
    let thirdCoef: double = double(30) * double(firstCoef) / double(10);
    (firstCoef, secondCoef, thirdCoef);

let ThirdTask (firstCandys, firstCake, firstOrange) (secondCandys, secondCake, secondOrange) =
    let candys = firstCandys + secondCandys;
    let cakes = firstCake + secondCake;
    let oranges = firstOrange + secondOrange;
    (candys, cakes, oranges);

let FourthTask() =
    let firstCoordinate = (1, 2);
    let secondCoordinate = (3, 4);

    let newCoordinate: double = sqrt (double(pown (fst firstCoordinate - fst secondCoordinate) 2 + pown (snd firstCoordinate - snd secondCoordinate) 2));
    printfn "%f" newCoordinate;

let FifthTask() =
    let firstCoordinate = (3, 4);
    let secondCoordinate = (0, 0);

    let newCoordinates = sqrt (double((pown(fst firstCoordinate - fst secondCoordinate) 2 + pown(snd firstCoordinate - snd secondCoordinate) 2)));
    printfn "%f" newCoordinates
    
let SixthTask() = 
    let salarys = (5.0, 3.5);
    let taxes = (0.2, 0.05);

    let earnings = (fst salarys * fst taxes, snd salarys * snd taxes)
    earnings

let SeventhTask() =
    let (numberLinesCat, numberLinesTiger, numberLinesZebra) = (5, 20, 25);
    let (lengthBodyCat, lengthBodyTiger, lengthBodyZebra) = (40, 200, 170);

    let banding = (double(numberLinesCat) / double(lengthBodyCat), double(numberLinesTiger) / double(lengthBodyTiger), double(numberLinesZebra) / double(lengthBodyZebra));
    banding

let EighthTask() =
    let (cabbage, carrot, orange) = (3, 1.5, 0.5)
    let general = (double(cabbage) + carrot, orange)
    general

let NinethTask() =
    let nightHours = 6;
    let (coffeeTime, energyDrinkTime) = (1, 3);
    let countDrinks = (nightHours / coffeeTime, nightHours / energyDrinkTime);
    countDrinks;

let TenthTask() =
    let (firstTime, secondTime, thirdTime) = (10, 20, 30);
    let result = firstTime + secondTime + thirdTime;
    printfn "General Time: %A" result;



