using InheritanceEnumClassLibraryProject.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEnumClassLibraryProject.Exercise.Classes
{
    public class Employee
    {
        public string FirstName { get; set; } = "Unnamed";
        public string LastName { get; set; } = "Unnamed";
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} - Lastname: {LastName} - Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
