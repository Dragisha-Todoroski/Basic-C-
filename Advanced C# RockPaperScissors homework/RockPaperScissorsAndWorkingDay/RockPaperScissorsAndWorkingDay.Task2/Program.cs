using SEDC.Class1.Domain.Models;

RockPaperScissors rockPaperScissors = new RockPaperScissors();

while (true)
{
    Console.WriteLine("Select from options:\n\n1. Play\n2. Stats\n3. Exit");
    string option = Console.ReadLine();

    if (option == "1" || option.Equals("play", StringComparison.CurrentCultureIgnoreCase))
    {
        rockPaperScissors.PlayGame();
    }
    else if (option == "2" || option.Equals("stats", StringComparison.CurrentCultureIgnoreCase))
    {
        rockPaperScissors.Stats();
    }
    else if (option == "3" || option.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Closing game!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}