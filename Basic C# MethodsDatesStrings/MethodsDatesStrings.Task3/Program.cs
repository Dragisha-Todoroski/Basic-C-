// Create a function that takes a number as input. This method should return the sum of the digits in the number.
using System;

int SumOfDigits(int num)
{
    int sum = 0;
    char[] digitsChar = num.ToString().ToCharArray(); // if input is 15, it makes it "15" it creates char array with 1 and 5 as elements
    int[] digitsInt = new int[digitsChar.Length]; // create an int array with the length of the char array length (2 because of 1 and 5)
    for (int i = 0; i < digitsInt.Length; i++) // populate int array with same values as in char array, but parsed back to int; then add to sum
    {
        digitsInt[i] = Convert.ToInt32(digitsChar[i].ToString()); // make sure our char elements are strings for successful string to int parsing
        sum += digitsInt[i];
    }
    return sum;
}

Console.Write("Enter number: ");
string num = Console.ReadLine();
bool numCheck = int.TryParse(num, out int parsedNum);

if (numCheck)
{
    Console.WriteLine($"The sum of the digits of the number you just entered is: {SumOfDigits(parsedNum)}");
}
else
{
    Console.WriteLine("Not a number!");
}