// Exercise Task 2

//Create a method called NumberStats that accepts a number. This method should:

//Find out if the number is negative or positive

//Find out if the number is odd or even

//Find out if the number is decimal or integer

//After finding all the stats it should print them like this:

//Stats for number: 25

//Positive
//Integer
//Odd
//The number should be entered in the console by the user.

//Bonus: Validate if the user is entering a number

//Bonus: Ask the user to press Y to try again or X to exit

void NumberStats(double number, bool check)
{
    if (check)
    {
        string posiNega = number >= 0 ? "Positive" : "Negative";
        string oddEvenInt = number % 2 == 0 ? "Even" : "Odd";
        string oddEvenDouble = (int)(number * 10) % 2 == 0 ? "Even" : "Odd"; // only works with 1 decimal space (decimals aren't meant to be categorized as even/odd?
        string deciOrInt = number.ToString().Contains(".") ? "Decimal" : "Integer";
        Console.WriteLine($"Stats for number: {number}");
        Console.WriteLine(posiNega);
        Console.WriteLine(deciOrInt == "Integer" ? oddEvenInt : oddEvenDouble);
        Console.WriteLine(deciOrInt);
    }
    else
    {
        Console.WriteLine("Wrong input! Sorry...");
    }
}

void GetUserInput()
{
    int tryAgainCheck = 0;
    while (true)
    {
        if (tryAgainCheck == 0)
        {
            Console.WriteLine("Enter input");
            string input = Console.ReadLine();
            bool inputCheck = double.TryParse(input, out double parsedInput);

            NumberStats(parsedInput, inputCheck);
            Console.WriteLine("Press Y to try again or X to exit");
        }
        tryAgainCheck = 0;
        string inputToContinue = Console.ReadLine().ToLower();
        if (inputToContinue == "x")
        {
            break;
        }
        else if (inputToContinue == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Wrong input. Press Y or X.");
            tryAgainCheck++;
        }
    }
}

GetUserInput();