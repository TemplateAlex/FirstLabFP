module SecondLab

let FirstTask() = 
    for i = 5 to 17 do
        let result = pown i 2 - 1;
        printfn "%d" result;

let SecondTask() =
    for i = 10 to 20 do
        if i % 2 = 0 then
            let result = pown i 2;
            printfn "%d" result;

let ThirdTask() =
    let mutable checker = true
    while checker do
        let rand = new System.Random();
        let x = rand.Next(1, 28);
        if x = 17 then checker <- false;
        
        printfn "%d" x;

let FourthTask() =
    for i = 1 to 3 do
        let x = (i + 1) * 2;
        let y = 3 * pown i 2;

        printfn "x = %d; y = %d" x y;

let FifthTask() =
    printfn "Write number of iterations of loop:"
    let f = System.Convert.ToInt32(System.Console.ReadLine());

    for i = 1 to f do
        let resultSecondDegree = pown i 2;
        let resultThirdDegree = pown i 3;
        printfn "Second degree: %d Third degree: %d" resultSecondDegree resultThirdDegree;

let SixthTask() = 
    for elem in 'А'..'Я' do
        printfn "%c" elem;

let SeventhTask() =
    let x = 3;
    let y = 2;
    let firstWall = (x + y) * 2;
    let lastWall = (x * y) * 3;

    for i = firstWall to lastWall do
        printfn "%d" i

let EighthTask() =
    for i = 100 downto 80 do
        let result = pown (i * 5) 2;
        printfn "%d" result;

let NinethTask() =
    let mutable x = 0;
    let mutable result = 0;
    for i = 1 to 50 do
        if (x = 3) then
            result <- i * 8;
        else 
            result <- i

        if x % 4 = 0 then
            x <- 0;

        x <- x + 1;
        printfn "%d" result

let TenthTask() =
    for x = 1 to 10 do
        let result = pown x 2 + 2 * x - 3;
        printfn "%d" result;


        


