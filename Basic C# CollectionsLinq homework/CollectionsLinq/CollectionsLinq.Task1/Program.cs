//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the numbers in the order that the user entered them from the QUEUE

using System.Reflection.Metadata.Ecma335;

Queue<long> queue = new Queue<long>();

int flag = 0;
while (true)
{
    if (flag == 0)
    {
        Console.WriteLine("Enter number:");
        string numInput = Console.ReadLine();
        bool numInputCheck = long.TryParse(numInput, out long parsedNumInput);

        if (numInputCheck)
        {
            queue.Enqueue(parsedNumInput);
        }
        else
        {
            Console.WriteLine("You did not enter an appropriate number.");
        }
        Console.WriteLine("Do you want to enter another number? Y/N");
    }
    flag = 0;
    string enterAgainInput = Console.ReadLine();

    if (enterAgainInput.Equals("y", StringComparison.CurrentCultureIgnoreCase) || enterAgainInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase)) continue;
    else if (enterAgainInput.Equals("n", StringComparison.CurrentCultureIgnoreCase) || enterAgainInput.Equals("no", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Printing numbers:\n");
        Thread.Sleep(2000);
        foreach (int num in queue)
        {
            Console.WriteLine(num);
        }
        break;
    }
    else
    {
        Console.WriteLine("Not an option. Enter 'Y' or 'N'");
        flag++;
    }
}