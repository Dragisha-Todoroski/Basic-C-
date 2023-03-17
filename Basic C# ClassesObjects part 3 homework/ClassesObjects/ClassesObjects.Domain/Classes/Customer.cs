using System.Threading.Tasks;

namespace ClassesObjects.Domain.Classes
{
    public class Customer
    {
        public Customer(string firstname, string lastname, Card creditCard, Wallet wallet)
        {
            Firstname = firstname;
            Lastname = lastname;
            Card = creditCard;
            Wallet = wallet;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Card Card { get; set; }
        public Wallet Wallet { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"[{Firstname} {Lastname}]: Number: {Card.Number} PIN: {Card.GetCardPin()}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: {string.Format("{0:C}", Card.GetBalance())}");
        }

        public void CashWithdrawal()
        {
            Console.WriteLine("How much would you like to withdraw?\n\n");
            string withdraw = Console.ReadLine();
            bool withdrawCheck = double.TryParse(withdraw, out double parsedWithdraw);

            if (withdrawCheck)
            {
                if (Card.GetBalance() < parsedWithdraw)
                {
                    Console.WriteLine($"You don't have enough cash to withdraw {string.Format("{0:C}", parsedWithdraw)}. Poor you ;)");
                }
                else if (parsedWithdraw < 0.01)
                {
                    Console.WriteLine("You must withdraw money.");
                }
                else
                {
                    Console.WriteLine($"You withdrew {string.Format("{0:C}", parsedWithdraw)}. You have {string.Format("{0:C}", Card.GetBalance() - parsedWithdraw)} left on your account.");
                    Card.ChangeBalance(Card.GetBalance() - parsedWithdraw);
                    Wallet.ChangeCash(Wallet.GetCash() + parsedWithdraw);
                }
            }
            else
            {
                Console.WriteLine("Please only enter whole numbers.");
            }
        }

        public void CashDeposit()
        {
            Console.WriteLine("How much would you like to deposit?\n\n");
            string deposit = Console.ReadLine();
            bool depositCheck = double.TryParse(deposit, out double parsedDeposit);

            if (depositCheck)
            {
                if (parsedDeposit < 0.01)
                {
                    Console.WriteLine("You must deposit money.");
                }
                else
                {
                    if (parsedDeposit <= Wallet.GetCash())
                    {
                        Card.ChangeBalance(Card.GetBalance() + parsedDeposit);
                        Console.WriteLine($"Balance after deposit: {string.Format("{0:C}", Card.GetBalance())}");
                        Wallet.ChangeCash(Wallet.GetCash() - parsedDeposit);
                    }
                    else
                    {
                        Console.WriteLine($"You only have {string.Format("{0:C}", Wallet.GetCash())} in cash. You need {string.Format("{0:C}", parsedDeposit - Wallet.GetCash())} more.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please only enter whole numbers.");
            }
        }
    }
}
