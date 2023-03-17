using InheritanceEnumClassLibraryProject.Exercise.Classes;
using InheritanceEnumClassLibraryProject.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEnums.Exercise.Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstname, string lastname, double successSaleRevenue)
        {
            FirstName = firstname;
            LastName = lastname;
            SuccessSaleRevenue = successSaleRevenue;
            Salary = 500;
            Role = Role.Sales;
        }

        private double SuccessSaleRevenue { get; set; }

        public void AddSuccessRevenue(double rev)
        {
            SuccessSaleRevenue = rev;
        }

        public override double GetSalary()
        {
            int bonus = 0;
            int bonusCheck = SuccessSaleRevenue <= 2000 && SuccessSaleRevenue >= 0 ? bonus += 500 : SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000 ? bonus += 1000 : SuccessSaleRevenue > 5000 ? bonus += 1500 : bonus;
            return Salary + bonusCheck;
        }
    }
}
