using ClassesObjects.Exercise2.Classes;
using System.Xml.Linq;

//Create a class Dog
//Add properties: Name, race, color
//The dog needs to have an Eat method that returns
//message: The dog is now eating. A Play method returning a
//message : The dog is now playing. and a ChaseTail method
//that returns a message: Dog is now chasing its tail.
//The user needs to create the dog object by inputs and then
//given an option to choose one of the actions mentioned
//above.

Console.WriteLine("Enter dog name:");
string dogNameInput = Console.ReadLine();
Console.WriteLine("Enter dog race:");
string dogRaceInput = Console.ReadLine();
Console.WriteLine("Enter dog color:");
string dogColorInput = Console.ReadLine();

Dog dog = new Dog(dogNameInput, dogRaceInput, dogColorInput);

Console.WriteLine("Type one of these:\n'Eat'\n'Play'\n'ChaseTail'");

string activityChoice = Console.ReadLine().ToLower();

switch (activityChoice)
{
    case "eat":
        Console.WriteLine(dog.Eat());
        break;
    case "play":
        Console.WriteLine(dog.Play());
        break;
    case "chasetail":
        Console.WriteLine(dog.ChaseTail());
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}