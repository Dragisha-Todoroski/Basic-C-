Console.Write("Enter the first number: ");
string firstNum = Console.ReadLine();
bool firstNumToInt = int.TryParse(firstNum, out int parsedFirstNum);

Console.Write("Enter the second number: ");
string secondNum = Console.ReadLine();
bool secondNumToInt = int.TryParse(secondNum, out int parsedSecondNum);

Console.Write("Enter the third number: ");
string thirdNum = Console.ReadLine();
bool thirdNumToInt = int.TryParse(thirdNum, out int parsedThirdNum);

Console.Write("Enter the fourth number: ");
string fourthNum = Console.ReadLine();
bool fourthNumToInt = int.TryParse(fourthNum, out int parsedFourthNum);

int[] parsedNumArray = new int[] { parsedFirstNum, parsedSecondNum, parsedThirdNum, parsedFourthNum };

if (firstNumToInt && secondNumToInt && thirdNumToInt && fourthNumToInt)
{
    Console.WriteLine($"The average of {parsedFirstNum},{parsedSecondNum},{parsedThirdNum},{parsedFourthNum} is: {parsedNumArray.Average()}");
}
else
{
    Console.WriteLine("One or more of your inputs were not integers!");
}

Console.ReadLine();