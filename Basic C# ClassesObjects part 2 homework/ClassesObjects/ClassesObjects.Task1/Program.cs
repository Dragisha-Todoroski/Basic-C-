//Create a class Human
//Add properties: FirstName, LastName, Age
//Create a method called GetPersonDetails that returns the full name of the human as well as their age
//Create an object human by asking the user to fill the required information (take first name, last name and age from user input)
//Call the GetPersonDetails method and print the result in the console after the object is created

using ClassesObjects.Task1.Classes;

Console.WriteLine("Enter first name:");
string firstNameInput = Console.ReadLine();

Console.WriteLine("Enter last name:");
string lastNameInput = Console.ReadLine();

Console.WriteLine("Enter age:");
string ageInput = Console.ReadLine();
bool ageInputCheck = int.TryParse(ageInput, out int parsedAgeInput);

if(ageInputCheck && parsedAgeInput >= 0)
{
    Human human = new Human(firstNameInput, lastNameInput, parsedAgeInput);
    Console.WriteLine(human.GetPersonalDetails());
}
else
{
    Console.WriteLine("Parsing failure!");
}