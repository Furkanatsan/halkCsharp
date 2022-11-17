using Delegation;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//.net 1.1
var evenNumbers = FilterProcess.Filter(numbers, isEven);
//.net 2.0
var oddNumbers = FilterProcess.Filter(numbers,
delegate (int x)
{
    return x % 2 == 1;
});

var multiplyThree = FilterProcess.Filter(numbers, x => x % 3 == 0);
//var evenNumbers = filter(numbers);

showNumbers(evenNumbers);
Console.WriteLine();
showNumbers(oddNumbers);
Console.WriteLine();
showNumbers(multiplyThree);




void showNumbers(int[] array)
{
    //foreach (var item in evenNumbers)
    //{
    //    Console.Write(item + "\t");
    //}

    array.ToList().ForEach(x => Console.Write(x + "\t"));
}

static bool isEven(int number)
{
    return number % 2 == 0;
}