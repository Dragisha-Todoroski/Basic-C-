string relativePath = @"..\..\..\";
string exerciseFolder = relativePath + @"Exercise\";
string calculationsFile = exerciseFolder + "calculations.txt";

if (!Directory.Exists(exerciseFolder))
{
    Directory.CreateDirectory(exerciseFolder);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Sucessfully created Exercise folder");
    Console.ResetColor();
}

if (!File.Exists(calculationsFile))
{
    File.Create(calculationsFile).Close();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sucessfully created Calculations file");
    Console.ResetColor();
}

string Calculate(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

Console.WriteLine("Enter first number:");
string firstNum = Console.ReadLine();
bool firstNumCheck = int.TryParse(firstNum, out int parsedFirstNum);
Console.WriteLine("Enter second number:");
string secondNum = Console.ReadLine();
bool secondNumCheck = int.TryParse(secondNum, out int parsedSecondNum);

if (firstNumCheck && secondNumCheck)
{
    Console.WriteLine(Calculate(parsedSecondNum, parsedFirstNum));
    using (StreamWriter sw = new StreamWriter(calculationsFile, true))
    {
        sw.WriteLine($"{Calculate(parsedFirstNum, parsedSecondNum)} - {DateTime.Now.ToLocalTime()}");
    }
}
else
{
    Console.WriteLine("Wrong inputs");
}