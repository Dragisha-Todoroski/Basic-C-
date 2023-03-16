using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects.Task1.Classes
{
    public class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonalDetails()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
