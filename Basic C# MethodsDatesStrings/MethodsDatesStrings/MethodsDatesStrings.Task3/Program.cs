// Create a function that takes a number as input. This method should return the sum of the digits in the number.
using System;

int SumOfDigits(int num)
{
    int sum = 0;
    char[] digitsChar = num.ToString().ToCharArray(); // if input is 15, it makes it "15" it creates char array with 1 and 5 as elements
    for (int i = 0; i < digitsChar.Length; i++) // populate char array with same values as in char array, but parsed back to int; then add to sum
    {
        sum += Convert.ToInt32(digitsChar[i].ToString()); // char back to string, string back to int... add to sum
    }
    return sum;
}

void Input()
{
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
}

Input();