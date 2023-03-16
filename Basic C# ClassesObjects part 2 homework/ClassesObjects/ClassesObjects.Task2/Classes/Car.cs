using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects.Task2.Classes
{
    public class Car
    {
        public string Model { get; set; } = "Unnamed model";
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Driver.Level * Speed;
        }

        public void RaceCars(Car obj2) // we will call this method on the first car object directly, so there is no need for a parameter
        {
            int car1 = CalculateSpeed();
            int car2 = obj2.CalculateSpeed();

            Console.WriteLine("And they're off!\n");
            Thread.Sleep(3000);
            Console.WriteLine($"Our favorite {Model} is taking the lead quickly. Will this be it folks?!\n");
            Thread.Sleep(3000);
            Console.WriteLine($"Oh my! {obj2.Driver.Name} with their {obj2.Model} is catching up real quick. Closer and Closer! An INCREDIBLE {obj2.Speed} kilometers per hour!\n");
            Thread.Sleep(2500);
            Console.WriteLine($"The finish line is straight ahead!\n");
            Thread.Sleep(1500);

            int rand = new Random().Next(3, 5);
            for (int i = 0; i < rand; i++)
            {
                Console.WriteLine($"{rand - i}...");
                Thread.Sleep(1000);
            }

            Console.WriteLine(car1 > car2 ? $"THE {Model.ToUpper()} HAS DELIVERED {Driver.Name.ToUpper()} THE WORLD CHAMPIONSHIP TITLE AFTER {rand + 15} YEARS OF RACING. A BEAUTIFUL DAY, INDEED!" : car2 > car1 ? $"{obj2.Driver.Name.ToUpper()} HAS WON THE TITLE AND ALL OF THIS TEXT I AM WRITING IS GETTING ANNOYING. WHY DID I ADD THIS I DON'T KNOW!!! {Driver.Name} must be losing it. That {Model} is getting thrashed!" : "PHOTO FINISH!!! IT'S A PHOTO FINISH, LADIES AND GENTLEMEN!!!");
        }
    }
}
