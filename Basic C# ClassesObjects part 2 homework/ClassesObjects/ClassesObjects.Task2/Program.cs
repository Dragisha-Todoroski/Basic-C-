using ClassesObjects.Task2.Classes;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System;
using System.Xml.Linq;
using System.Xml.Schema;

//Make a class Driver. Add properties: Name, Level
//Make a class Car. Add properties: Model, Speed and Driver
//Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
//Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//Make 4 car objects and 4 driver objects.
//Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods
//Test Data:

//Choose a car no.1:
//Hyundai
//Mazda
//Ferrari
//Porsche

//Choose Driver:
//Bob
//Greg
//Jill
//Anne

//Choose a car no.2:
//Hyundai
//Mazda
//Ferrari
//Porsche

//Choose Driver:
//Bob
//Greg
//Jill
//Anne

//Expected Output:
//Car no. 2 was faster.

//BONUS 1: If a user chooses option one for the first car, eliminate that option when the user picks car two.

//BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

//BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.


Car[] cars = new Car[]
{
    new Car() { Model = "Hyundai", Speed = 10 },
    new Car() { Model = "Mazda", Speed = 15 },
    new Car() { Model = "Ferrari", Speed = 20 },
    new Car() { Model = "Porsche", Speed = 25 }
};

Driver[] drivers = new Driver[]
{
    new Driver() { Name = "Bob", Level = 1 },
    new Driver() { Name = "Greg", Level = 2 },
    new Driver() { Name = "Jill", Level = 3 },
    new Driver() { Name = "Anne", Level = 4 }
};
void CarAndDriverList(object[] objArr, string name)
{
    for (int i = 0; i < objArr.Length; i++)
    {
        var propertyValue = objArr[i].GetType().GetProperty(name).GetValue(objArr[i], null);
        Console.WriteLine($"{i + 1}. {propertyValue}");
    }
}

void RemoveArrayElement<T>(ref T[] arr, int index) // all elements starting from the chosen element forwards will take the values of the next element; then the array will get minimized by 1, effectively removing the chosen element from the array permanently
{
    for (int i = index; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    Array.Resize(ref arr, arr.Length - 1);
}

// example steps for easy reference

//int[] intArray = new int[5] { 1, 2, 3, 4, 5 }

//picked intArray[2] // 3

//step 1: intArray[2] = intArray[2 + 1] // {1, 2, 4, 4, 5}

//step 2: intArray[3] = intArray[3 + 1] // {1, 2, 4, 5, 5}

//step 3: Resize Array which removes last element // { 1, 2, 4, 5}

void RestoreArrayElement<T>(ref T[] arr, int index, T element)
{
    Array.Resize(ref arr, arr.Length + 1);
    for (int i = arr.Length - 1; i > index; i--)
    {
        arr[i] = arr[i - 1];
    }
    arr[index] = element;
}

int[] CarAndDriverInput()
{
    CarAndDriverList(cars, "Model");
    Console.WriteLine($"\nSelect Car 1:\n");

    string selectedCar1 = Console.ReadLine();
    bool selectedCar1Check = int.TryParse(selectedCar1, out int parsedSelectedCar1);
    if (!selectedCar1Check || parsedSelectedCar1 < 1 || parsedSelectedCar1 > cars.Length)
    {
        Console.WriteLine("Invalid input for Car 1. Shutting down...");
        return null;
    }
    Car removedCarElement = cars[parsedSelectedCar1 - 1];
    RemoveArrayElement(ref cars, parsedSelectedCar1 - 1);

    CarAndDriverList(cars, "Model");
    Console.WriteLine($"\nSelect Car 2:\n");

    string selectedCar2 = Console.ReadLine();
    bool selectedCar2Check = int.TryParse(selectedCar2, out int parsedSelectedCar2);
    if (!selectedCar2Check || parsedSelectedCar2 < 1 || parsedSelectedCar2 > cars.Length)
    {
        RestoreArrayElement(ref cars, parsedSelectedCar1 - 1, removedCarElement);
        Console.WriteLine("Invalid input for Car 2. Shutting down...");
        return null;
    }
    RestoreArrayElement(ref cars, parsedSelectedCar1 - 1, removedCarElement);

    CarAndDriverList(drivers, "Name");
    Console.WriteLine($"\nSelect Driver 1:\n");

    string selectedDriver1 = Console.ReadLine();
    bool selectedDriver1Check = int.TryParse(selectedDriver1, out int parsedSelectedDriver1);
    if (!selectedDriver1Check || parsedSelectedDriver1 < 1 || parsedSelectedDriver1 > drivers.Length)
    {
        Console.WriteLine("Invalid input for Driver 1. Shutting down...");
        return null;
    }
    Driver removedDriverElement = drivers[parsedSelectedDriver1 - 1];
    RemoveArrayElement(ref drivers, parsedSelectedDriver1 - 1);

    CarAndDriverList(drivers, "Name");
    Console.WriteLine($"\nSelect Driver 2:\n");

    string selectedDriver2 = Console.ReadLine();
    bool selectedDriver2Check = int.TryParse(selectedDriver2, out int parsedSelectedDriver2);
    if (!selectedDriver2Check || parsedSelectedDriver2 < 1 || parsedSelectedDriver2 > drivers.Length)
    {
        RestoreArrayElement(ref drivers, parsedSelectedDriver1 - 1, removedDriverElement);
        Console.WriteLine("Invalid input for Driver 2. Shutting down...");
        return null;
    }
    RestoreArrayElement(ref drivers, parsedSelectedDriver1 - 1, removedDriverElement);

    int[] storedInputs = new int[4] { parsedSelectedCar1, parsedSelectedCar2, parsedSelectedDriver1, parsedSelectedDriver2 };
    return storedInputs;
}

void CarAndDriverResults()
{
    int[] storedInputs = CarAndDriverInput();

    if (storedInputs == null)
    {
        return;
    }

    int parsedSelectedCar1 = storedInputs[0];
    int parsedSelectedCar2 = storedInputs[1];
    int parsedSelectedDriver1 = storedInputs[2];
    int parsedSelectedDriver2 = storedInputs[3];

    cars[parsedSelectedCar1 - 1].Driver = drivers[parsedSelectedDriver1 - 1];
    cars[parsedSelectedCar2 - 1].Driver = drivers[parsedSelectedDriver2 - 1];

    cars[parsedSelectedCar1 - 1].RaceCars(cars[parsedSelectedCar2 - 1]); // RaceCars is called on the first object naturally, so we don't need a parameter for it. Only for the second car. See RaceCars method inside of the Car class.
}

void ActivateRaces()
{
    int flag = 0;
    while (true)
    {
        if (flag == 0)
        {
            CarAndDriverResults();
            Console.WriteLine("Race Again? Yes/No.");
        }
        flag = 0;
        string raceAgain = Console.ReadLine().ToLower();
        if (raceAgain == "no" || raceAgain == "n")
        {
            Console.WriteLine("Ending races!");
            break;
        }
        else if (raceAgain == "yes" || raceAgain == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Enter an appropriate answer, please!");
            flag++;
        }
    }
}

ActivateRaces();