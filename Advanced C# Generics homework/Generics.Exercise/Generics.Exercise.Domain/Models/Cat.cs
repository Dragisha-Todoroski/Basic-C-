using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exercise.Domain.Models
{
    public class Cat : Pet
    {
        public Cat(string name, string type, int age, bool lazy, int livesLeft)
        {
            Name = name;
            Type = type;
            Age = age;
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} is a {Age} year old {Type} that is {(Lazy ? "lazy" : "not lazy")}. Only has {LivesLeft} lives left.";
        }
    }
}
