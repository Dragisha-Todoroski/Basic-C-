Console.Write("Enter the first number: ");
string firstNum = Console.ReadLine();
bool firstNumToDouble = double.TryParse(firstNum, out double parsedFirstNum); // used double for division with larger second number

Console.Write("Enter the second number: ");
string secondNum = Console.ReadLine();
bool secondNumToDouble = double.TryParse(secondNum, out double parsedSecondNum);

bool loop = true;

while (loop)
{
    Console.Write("Enter the operation: ");
    string operation = Console.ReadLine();

    if (firstNumToDouble && secondNumToDouble)
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine($"The result is: {parsedFirstNum + parsedSecondNum}");
                loop = false;
                break;
            case "-":
                Console.WriteLine($"The result is: {parsedFirstNum - parsedSecondNum}");
                loop = false;
                break;
            case "*":
                Console.WriteLine($"The result is: {parsedFirstNum * parsedSecondNum}");
                loop = false;
                break;
            case "/":
                Console.WriteLine($"The result is: {parsedFirstNum / parsedSecondNum}");
                loop = false;
                break;
            default:
                Console.WriteLine("Incorrect operation");
                break;
        }
    }
}
Console.ReadLine();