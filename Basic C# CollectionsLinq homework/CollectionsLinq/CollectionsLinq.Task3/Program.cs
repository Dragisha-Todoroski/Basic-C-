//Create a class Animal. Each Animal has name, color, age and gender. Use enum for Gender.

//Find the names of all the animals aged 5 or more
//Find all the names of the animals that start with 'A'
//Find all male, brown animals
//Find the first animal whose name is longer than 10 characters

using CollectionsLinq.Domain.Enums;
using CollectionsLinq.Domain.Models;

List<Animal> animals = new List<Animal>()
{
    new Animal("Jacky", "brown", 7, Gender.Female),
    new Animal("Carl", "yellow", 3, Gender.Male),
    new Animal("Washingtons", "brown", 9, Gender.Male),
    new Animal("Bobby", "red", 1, Gender.Female),
    new Animal("Alexandra Woof", "black", 5, Gender.Female),
    new Animal("Charlie", "brown", 4, Gender.Male),
    new Animal("Ant", "red", 7, Gender.Other)
};

List<Animal> animalsAged5OrMore = animals.Where(x => x.Age > 4).ToList();

foreach (Animal animal in animalsAged5OrMore)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();

List<Animal> animalsStartingWithA = animals.Where(x => x.Name.StartsWith("a", StringComparison.CurrentCultureIgnoreCase)).ToList();

foreach (Animal animal in animalsStartingWithA)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();

List<Animal> animalsMaleBrown = animals.Where(x => x.Gender == Gender.Male && x.Color.Equals("brown", StringComparison.CurrentCultureIgnoreCase)).ToList();

foreach (Animal animal in animalsMaleBrown)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine();

Animal firstAnimalOver10Letters = animals.FirstOrDefault(x => x.Name.Length > 10);

if (firstAnimalOver10Letters != null)
{
    Console.WriteLine(firstAnimalOver10Letters.Name);
}
else
{
    Console.WriteLine("Animal not found.");
}