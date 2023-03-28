using System.Globalization;

namespace SEDC.Class1.Domain.Models
{
    public class RockPaperScissors
    {
        private double PlayerWins { get; set; }
        private double ComputerWins { get; set; }


        private string PlayerChoice()
        {
            Console.WriteLine("[1] Rock\n[2] Paper\n[3]Scissors");
            while (true)
            {
                string playerInput = Console.ReadLine();

                switch (playerInput.ToLower(CultureInfo.CurrentCulture))
                {
                    case "1":
                    case "rock":
                        Console.WriteLine("You picked 'Rock'");
                        return "rock";
                    case "2":
                    case "paper":
                        Console.WriteLine("You picked 'Paper'");
                        return "paper";
                    case "3":
                    case "scissors":
                        Console.WriteLine("You picked 'Scissors'");
                        return "scissors";
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }
            }
        }

        private string ComputerChoice()
        {
            int rand = new Random().Next(0, 3);

            switch (rand)
            {
                case 0:
                    Console.WriteLine("Computer picked 'Rock'");
                    return "rock";
                case 1:
                    Console.WriteLine("Computer picked 'Paper'");
                    return "paper";
                case 2:
                    Console.WriteLine("Computer picked 'Scissors'");
                    return "scissors";
                default:
                    return "Computer malfunction";
            }
        }

        public void PlayGame()
        {
            string playerChoice = PlayerChoice();
            string computerChoice = ComputerChoice();

            if (playerChoice == "rock" && computerChoice == "scissors" || playerChoice == "paper" && computerChoice == "rock" || playerChoice == "scissors" && computerChoice == "paper")
            {
                Console.WriteLine("You Win!\n");
                PlayerWins++;
            }
            else if (playerChoice == "rock" && computerChoice == "paper" || playerChoice == "paper" && computerChoice == "scissors" || playerChoice == "scissors" && computerChoice == "rock")
            {
                Console.WriteLine("You Lose...\n");
                ComputerWins++;
            }
            else
            {
                Console.WriteLine("It's a tie.\n");
            }
            Console.ReadLine();
        }

        public void Stats()
        {
            if (PlayerWins + ComputerWins == 0) // can't divide by zero, would  give NaN%, so we hardcode 0% for this case
            {
                Console.WriteLine($"Stats:\n\n{PlayerWins} wins\n{ComputerWins} losses\n\nWinrate: 0%\n");
            }
            else
            {
                Console.WriteLine($"Stats:\n\n{PlayerWins} wins\n{ComputerWins} losses\n\nWinrate: {Math.Round(PlayerWins / (PlayerWins + ComputerWins) * 100, 2)}%\n");
            }
            Console.ReadLine();
        }
    }
}
