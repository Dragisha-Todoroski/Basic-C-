using TaxiManager9000.Domain;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services;

//AdminService adminService = new AdminService();

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
                    Console.WriteLine("1. Add User\n2. Terminate User\n3. List All Registered Users");
                    string adminOption = Console.ReadLine();
                    bool adminOptionCheck = int.TryParse(adminOption, out int parsedAdminOption);
                    if (adminOptionCheck)
                    {
                        if (parsedAdminOption == 1)
                        {
                            AdminService.AddUser();
                        }
                        else if (parsedAdminOption == 2)
                        {
                            AdminService.TerminateUser(currentUser);
                        }
                        else if (parsedAdminOption == 3)
                        {
                            Console.Clear();
                            AdminService.ListAllUsers();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Enter either 1, 2 or 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a whole number.");
                    }
                    break;
                case Role.Manager:
                    Console.WriteLine("1. List Drivers\n2. List Driver Licenses (Statuses)\n3. Driver Manager");
                    string managerOption = Console.ReadLine();
                    bool managerOptionCheck = int.TryParse(managerOption, out int parsedManagerOption);
                    if (managerOptionCheck)
                    {
                        if (parsedManagerOption == 1)
                        {
                            ManagerService.ListDrivers();
                        }
                        else if (parsedManagerOption == 2)
                        {
                            ManagerService.ListDriverLicences();
                        }
                        else if (parsedManagerOption == 3)
                        {
                            ManagerService.AssignDrivers();
                        }
                    }
                    break;
                case Role.Maintenance:
                    Console.WriteLine("1. List Vehicles\n2. List Vehicles Licence Plates (Statuses)");
                    string maintenanceOption = Console.ReadLine();
                    bool maintenanceOptionCheck = int.TryParse(maintenanceOption, out int parsedMaintenanceOption);
                    if (maintenanceOptionCheck)
                    {
                        if (parsedMaintenanceOption == 1)
                        {
                            MaintenanceService.ListVehicles();
                        }
                        else if (parsedMaintenanceOption == 2)
                        {
                            MaintenanceService.ListVehiclesLicencePlates();
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
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}