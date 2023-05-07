using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    public static class AdminService
    {
        public static void AddUser()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Create a new user for the app:\n\nUsername:");
                string username = Console.ReadLine();
                if (username.Length < 5)
                {
                    TextHelper.WriteLineInColor("Enter at least 5 characters!", ConsoleColor.Red);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    if (password.Length < 5 || !password.Any(x => char.IsDigit(x)))
                    {
                        TextHelper.WriteLineInColor("Password must contain at least 5 characters, including at least 1 number!", ConsoleColor.Red);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Role:\n\n1. Administrator\n2. Manager\n3. Maintenance");
                        string role = Console.ReadLine().ToLower();
                        switch (role)
                        {
                            case "1":
                            case "administrator":
                            case "admin":
                                User adminUser = new User(username, password, Role.Administrator);
                                StaticDatabase.Users.Add(adminUser);
                                TextHelper.WriteLineInColor($"Successful creation of an {adminUser.Role} user!", ConsoleColor.Green);
                                Console.ReadKey();
                                break;

                            case "2":
                            case "manager":
                                User managerUser = new User(username, password, Role.Manager);
                                StaticDatabase.Users.Add(managerUser);
                                TextHelper.WriteLineInColor($"Successful creation of a {managerUser.Role} user!", ConsoleColor.Green);
                                Console.ReadKey();
                                break;

                            case "3":
                            case "maintenance":
                                User maintenanceUser = new User(username, password, Role.Maintenance);
                                StaticDatabase.Users.Add(maintenanceUser);
                                TextHelper.WriteLineInColor($"Successful creation of a {maintenanceUser.Role} user!", ConsoleColor.Green);
                                Console.ReadKey();
                                break;

                            default:
                                TextHelper.WriteLineInColor("Incorrect input. Creation failed!", ConsoleColor.Red);
                                Console.ReadKey();
                                continue;
                        }
                        break;
                    }
                }
            }
        }

        public static void TerminateUser(User removeSelf)
        {
            Console.Clear();
            Console.WriteLine("Remove existing user from the app:\n\n");
            ListAllUsers();
            string option = Console.ReadLine().ToLower();
            bool optionCheck = int.TryParse(option, out int parsedOption);
            User foundUserById = StaticDatabase.Users.FirstOrDefault(x => x.Id == parsedOption);
            User foundUserByUsername = StaticDatabase.Users.FirstOrDefault(x => x.Username.ToLower() == option);
            if (optionCheck && foundUserById == removeSelf || foundUserByUsername == removeSelf)
            {
                TextHelper.WriteLineInColor("Cannot remove yourself!", ConsoleColor.Red);
            }
            else if (optionCheck && foundUserById != null)
            {
                StaticDatabase.Users.Remove(foundUserById);
                TextHelper.WriteLineInColor("Successfully removed user", ConsoleColor.Red);
            }
            else if (foundUserByUsername != null)
            {
                StaticDatabase.Users.Remove(foundUserByUsername);
                TextHelper.WriteLineInColor("Successfully removed user", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine("User does not exist!");
            }
            Console.ReadKey();
        }

        public static void ListAllUsers()
        {
            StaticDatabase.Users.ForEach(x => Console.WriteLine($"({x.Id}) {x.Username} - {x.Password} - Role: {x.Role}"));
        }
    }
}
