using InheritanceEnums.Exercise.Classes;

// check ternary operator in SalesPerson.cs for GetSalary method

while (true)
{
    Console.WriteLine("Enter salary:\n");
    string successfulSalesInput = Console.ReadLine();
    bool successfulSalesInputCheck = double.TryParse(successfulSalesInput, out double parsedSuccessfulSalesInput);

    if (parsedSuccessfulSalesInput >= 0)
    {
        if (successfulSalesInputCheck)
        {
            SalesPerson salesPerson = new SalesPerson("Dragisha", "Todoroski", parsedSuccessfulSalesInput);
            Console.WriteLine(salesPerson.GetSalary());
            break;
        }
        else
        {
            Console.WriteLine("Wrong data type...\n");
        }
    }
    else
    {
        Console.WriteLine("Can't enter negative revenue.\n");
    }
}