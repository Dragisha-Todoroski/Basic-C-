using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exercise.Domain.Models
{
    public class Fish : Pet
    {
        public Fish(string name, string type, int age, string color, string size)
        {
            Name = name;
            Type = type;
            Age = age;
            Color = color;
            Size = size;
        }

        public string Color { get; set; }
        public string Size { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} is a {Age} year old {Type} that is {Color} and {Size}cm long";
        }
    }
}
