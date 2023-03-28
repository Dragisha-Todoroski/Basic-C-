using System.Runtime.InteropServices;

while (true)
{
    Console.WriteLine("Enter date:");
    string dateInput = Console.ReadLine();

    bool dateInputCheck = DateTime.TryParse(dateInput, out DateTime parsedDateInput);

    if (dateInputCheck)
    {
        if (parsedDateInput.Day == 1 && parsedDateInput.Month == 1 || parsedDateInput.Day == 7 && parsedDateInput.Month == 1 || parsedDateInput.Day == 20 && parsedDateInput.Month == 4 || parsedDateInput.Day == 1 && parsedDateInput.Month == 5 || parsedDateInput.Day == 25 && parsedDateInput.Month == 5 || parsedDateInput.Day == 3 && parsedDateInput.Month == 8 || parsedDateInput.Day == 8 && parsedDateInput.Month == 9 || parsedDateInput.Day == 12 && parsedDateInput.Month == 10 || parsedDateInput.Day == 23 && parsedDateInput.Month == 10 || parsedDateInput.Day == 8 && parsedDateInput.Month == 12)
        {
            Console.WriteLine("This is a public holiday!");
            
        }
        else if (parsedDateInput.DayOfWeek != DayOfWeek.Saturday && parsedDateInput.DayOfWeek != DayOfWeek.Sunday)
        {
            Console.WriteLine("This is a working day!");
        }
        else if (parsedDateInput.DayOfWeek == DayOfWeek.Saturday || parsedDateInput.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("This is a weekend!");
        }
    }
    else
    {
        Console.WriteLine("Parsing failed.");
        continue;
    }

    Console.WriteLine("Enter another date? Y/N");
    string goAgainInput = Console.ReadLine();

    if (goAgainInput.Equals("y", StringComparison.CurrentCultureIgnoreCase) || goAgainInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
    {
        continue;
    }
    else
    {
        Console.WriteLine("Shutting down!");
        break;
    }
}