// Take a sentence as input and print its words.

Console.WriteLine("Write a sentence!");

string input = Console.ReadLine();

string[] inputArray = input.Split(" ");

foreach (string element in inputArray)
{
    Console.WriteLine(element);
}