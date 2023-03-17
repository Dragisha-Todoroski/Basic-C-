namespace ClassesObjects.Domain.Classes
{
    public class Card
    {
        public Card(long cNumber, double balance)
        {
            Number = cNumber;
            Balance = balance;
            Pin = GeneratePin();
        }

        public long Number { get; set; }
        private double Balance { get; set; }
        private int Pin { get; set; }

        private int GeneratePin()
        {
            return new Random().Next(1000, 10000);
        }

        public int GetCardPin()
        {
            return Pin;
        }
        
        public double GetBalance()
        {
            return Balance;
        }

        public void ChangeBalance(double newBalance)
        {
            Balance = newBalance;
        }

    }
}
