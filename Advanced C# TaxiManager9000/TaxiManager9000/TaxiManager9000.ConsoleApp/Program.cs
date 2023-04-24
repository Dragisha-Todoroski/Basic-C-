using TaxiManager9000.Domain;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services;

AdminService adminService = new AdminService();

while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Taxi Manager 9000\n\nLog in:\n\nUsername:");
        string usernameInput = Console.ReadLine();
        Console.WriteLine("Password:");
        string passwordInput = Console.ReadLine();

        User currentUser = StaticDatabase.Users.FirstOrDefault(x => x.Username == usernameInput && x.Password == passwordInput);

        if (currentUser == null)
        {
            TextHelper.WriteLineInColor("Login unsuccessful. Please try again...", ConsoleColor.Red);
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            TextHelper.WriteLineInColor($"Successful Login! Welcome {currentUser.Role} user!", ConsoleColor.Green);

            switch (currentUser.Role)
            {
                case Role.Administrator:
                    Console.WriteLine("1. Add User\n2. Terminate User");
                    string option = Console.ReadLine();
                    bool optionCheck = int.TryParse(option, out int parsedOption);
                    if (optionCheck)
                    {
                        if (parsedOption == 1)
                        {
                            // add user
                        }
                        else if (parsedOption == 2)
                        {
                            // terminate user
                        }
                        else
                        {
                            Console.WriteLine("Enter either 1 or 2.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a whole number.");
                    }
                    break;
                case Role.Manager:

                    break;
                case Role.Maintenance:

                    break;
            }
        }
    }
    catch
    {

    }
}