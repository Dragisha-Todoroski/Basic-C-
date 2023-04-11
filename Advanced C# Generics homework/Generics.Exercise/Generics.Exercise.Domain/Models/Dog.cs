using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exercise.Domain.Models
{
    public class Dog : Pet
    {
        public Dog(string name, string type, int age, string favouriteFood)
        {
            Name = name;
            Type = type;
            Age = age;
            FavouriteFood = favouriteFood;
        }

        public string FavouriteFood { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} is a {Age} year old {Type} that loves to eat {FavouriteFood}";
        }
    }
}
