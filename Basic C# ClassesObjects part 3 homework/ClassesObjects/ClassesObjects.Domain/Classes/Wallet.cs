using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects.Domain.Classes
{
    public class Wallet // the Wallet class is just a helpful simulation of depositing money from your real wallet, as well as withdrawing from your balance and adding it to said wallet. Logically an ATM would not ask us for our wallet cash, nor would that information be kept in the system
    {
        public Wallet(double cash)
        {
            Cash = cash;
        }

        private double Cash { get; set; }

        public double GetCash()
        {
            return Cash;
        }

        public void ChangeCash(double newCash)
        {
            Cash = newCash;
        }
    }
}
