int[] intArray = new int[6];

Console.Write("Enter integer no.1: ");
string inputInt1 = Console.ReadLine();
bool inputInt1Check = int.TryParse(inputInt1, out int parsedInputInt1);

Console.Write("Enter integer no.2: ");
string inputInt2 = Console.ReadLine();
bool inputInt2Check = int.TryParse(inputInt2, out int parsedInputInt2);

Console.Write("Enter integer no.3: ");
string inputInt3 = Console.ReadLine();
bool inputInt3Check = int.TryParse(inputInt3, out int parsedInputInt3);

Console.Write("Enter integer no.4: ");
string inputInt4 = Console.ReadLine();
bool inputInt4Check = int.TryParse(inputInt4, out int parsedInputInt4);

Console.Write("Enter integer no.5: ");
string inputInt5 = Console.ReadLine();
bool inputInt5Check = int.TryParse(inputInt5, out int parsedInputInt5);

Console.Write("Enter integer no.6: ");
string inputInt6 = Console.ReadLine();
bool inputInt6Check = int.TryParse(inputInt6, out int parsedInputInt6);

if(inputInt1Check && inputInt2Check && inputInt3Check && inputInt4Check && inputInt5Check && inputInt6Check)
{
    int[] parsedInputIntArray = new int[6] { parsedInputInt1, parsedInputInt2, parsedInputInt3, parsedInputInt4, parsedInputInt5, parsedInputInt6 };

    int sum = 0;

    for (int i = 0; i < parsedInputIntArray.Length; i++)
    {
        intArray[i] = parsedInputIntArray[i];

        if (intArray[i] % 2 == 0)
        {
            sum += intArray[i];
        }
    }

    Console.WriteLine($"The result is: {sum}");
}
else
{
    Console.WriteLine("One of these things is not like the other. One of these things just doesn't belong! (or multiple haha)");
}
Console.ReadLine();