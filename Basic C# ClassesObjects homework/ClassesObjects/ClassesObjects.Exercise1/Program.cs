//Create a class Human
//Add properties: FirstName, LastName, Age
//Create a method called GetPersonStats that returns the full
//name of the human as well as their age
//Create an object human by asking the user to fill the
//required information
//Call the GetPersonStats method and print the result in the
//console after the object is created

using ClassesObjects.Exercise1.Classes;

Human human = new Human("Arthur", "Morgan", 36);

Console.WriteLine(human.GetPersonStats());