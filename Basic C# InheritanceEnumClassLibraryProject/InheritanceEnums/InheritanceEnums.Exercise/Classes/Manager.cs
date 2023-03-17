using InheritanceEnumClassLibraryProject.Exercise.Classes;
using InheritanceEnumClassLibraryProject.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEnums.Exercise.Classes
{
    public class Manager : Employee
    {
        public Manager(string firstname, string lastname, double salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Role = Role.Manager;
        }

        private double Bonus { get; set; }

        public double AddBonus(double bonus)
        {
            return Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
