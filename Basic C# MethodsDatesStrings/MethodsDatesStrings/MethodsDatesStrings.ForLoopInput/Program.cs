// exercise relating to previous Loops and Arrays homework (collecting multiple inputs with a for loop instead of inidividual input ReadLines)

int[] intArray = new int[5];
int sum = 0;

Console.WriteLine("Enter 5 numbers!");

for (int i = 0; i < intArray.Length; i++)
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine();
    bool inputCheck = int.TryParse(input, out int parsedInput);

    if(inputCheck)
    {
        Console.WriteLine(parsedInput);
        sum += parsedInput;
    }
    else
    {
        Console.WriteLine("Wrong. Shutting down...");
        break;
    }
}

Console.WriteLine(sum);

Console.ReadLine();