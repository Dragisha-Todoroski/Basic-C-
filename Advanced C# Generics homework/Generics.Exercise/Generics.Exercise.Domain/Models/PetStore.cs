using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exercise.Domain.Models
{
    public class PetStore<T> where T : Pet
    {
        private List<T> _list { get; set; } = new List<T>();

        public void PrintsPets()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void Insert(T item)
        {
            _list.Add(item);
        }

        public void BuyPet(string name)
        {
            T item = _list.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                Console.WriteLine("No such pet exists!");
            }
            else
            {
                _list.Remove(item);
                Console.WriteLine($"{item.Name} has been successfully bought! Good choice!! :)\nPets left:");
                foreach (T pet in _list)
                {
                    Console.WriteLine(pet.Name);
                }
            }
        }
    }
}
