// Take one string from the input and print its last 5 characters.

Console.WriteLine("Write something.");

string input = Console.ReadLine();
bool inputCheck = double.TryParse(input, out double parsedInput);

if (!inputCheck)
{
    if (input.Length < 5 && input.Length > 0)
    {
        Console.WriteLine("Make sure your text is longer than 4 characters long.");
    }
    else if (input.Length > 4)
    {
        Console.WriteLine(input.Substring(input.Length - 5));
    }
    else
    {
        Console.WriteLine("You didn't enter anything...");
    }
}
else
{
    Console.WriteLine("Please make sure it is NOT a number!");
}

Console.ReadLine();

// I made a validation of every type here