using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects.Exercise2.Classes
{
    public class Dog
    {
        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            return $"{Name} is now eating";
        }
        public string Play()
        {
            return $"{Name} is now playing";
        }
        public string ChaseTail()
        {
            return $"{Name} is now chasing its tail";
        }
    }
}
