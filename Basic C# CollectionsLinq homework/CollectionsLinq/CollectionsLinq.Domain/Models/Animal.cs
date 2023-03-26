using CollectionsLinq.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLinq.Domain.Models
{
    public class Animal
    {
        public Animal(string name, string color, int age, Gender gender)
        {
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
