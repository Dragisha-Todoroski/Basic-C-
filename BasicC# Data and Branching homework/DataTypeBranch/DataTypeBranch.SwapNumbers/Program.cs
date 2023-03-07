Console.Write("Input the first number: ");
string firstNum = Console.ReadLine();
bool firstNumToInt = int.TryParse(firstNum, out int parsedFirstNum);

Console.Write("Input the second number: ");
string secondNum = Console.ReadLine();
bool secondNumToInt = int.TryParse(secondNum, out int parsedSecondNum);

if (firstNumToInt && secondNumToInt)
{

    int swapOne = parsedFirstNum;
    int swapTwo = parsedSecondNum;

    parsedFirstNum = swapTwo;
    parsedSecondNum = swapOne;

    Console.WriteLine(parsedFirstNum);
    Console.WriteLine(parsedSecondNum); // version 1
}
else
{
    Console.WriteLine("Bad inputs, buddy ;P");
}

Console.ReadLine();

//(parsedFirstNum, parsedSecondNum) = (parsedSecondNum, parsedFirstNum);

//Console.WriteLine(parsedFirstNum);
//Console.WriteLine(parsedSecondNum); // version 2 (no temporary variables)