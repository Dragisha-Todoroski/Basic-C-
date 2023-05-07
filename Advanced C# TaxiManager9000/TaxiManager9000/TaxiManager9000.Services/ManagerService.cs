using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    public static class ManagerService
    {
        public static void ListDrivers()
        {
            StaticDatabase.Drivers.ForEach(x =>
            {
                if (x.Car != null)
                {
                    Console.WriteLine($"({x.Id}) {x.FirstName} {x.LastName} driving in the {x.Shift} shift with {x.Car.Model} car");
                }
                else
                {
                    Console.WriteLine($"({x.Id}) {x.FirstName} {x.LastName} is currently off duty");
                }
            });
            Console.ReadKey();
        }

        public static void ListDriverLicences()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            foreach (Driver driver in StaticDatabase.Drivers)
            {
                int monthsToExpiry = ((driver.LicenceExpiryDate.Year - today.Year) * 12) + driver.LicenceExpiryDate.Month - today.Month + driver.LicenceExpiryDate.Day - today.Day;
                if (driver.LicenceExpiryDate < today)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("(Expired) ");
                    Console.ResetColor();
                    Console.WriteLine($"Driver {driver.FirstName} {driver.LastName} with licence {driver.Licence} expiring on {driver.LicenceExpiryDate}");
                }
                else if (driver.LicenceExpiryDate >= today && monthsToExpiry <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"({monthsToExpiry} {(monthsToExpiry != 1 ? "months" : "month")} to expiry) ");
                    Console.ResetColor();
                    Console.WriteLine($"Driver {driver.FirstName} {driver.LastName} with licence {driver.Licence} expiring on {driver.LicenceExpiryDate}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(Valid) ");
                    Console.ResetColor();
                    Console.WriteLine($"Driver {driver.FirstName} {driver.LastName} with licence {driver.Licence} expiring on {driver.LicenceExpiryDate}");
                }
            }
            Console.ReadKey();
        }

        public static void DriverManager()
        {

        }

        public static void AssignDrivers()
        {
            foreach (Driver driver in StaticDatabase.Drivers)
            {
                if (driver.Car == null)
                {
                    Console.WriteLine($"({driver.Id}) {driver.FirstName} {driver.LastName}");
                }
            }
            string option = Console.ReadLine().ToLower();
            bool optionCheck = int.TryParse(option, out int parsedOption);
            Driver foundDriverById = StaticDatabase.Drivers.FirstOrDefault(x => x.Id == parsedOption);
            Driver foundDriverByUsername = StaticDatabase.Drivers.FirstOrDefault(x => x.FirstName.ToLower() == option);
            if (optionCheck && foundDriverById != null || foundDriverByUsername != null)
            {
                Console.WriteLine($"Pick a shift:\n\n1. {Shift.Morning}\n2. {Shift.Afternoon}\n3. {Shift.Evening}");
                string shiftOption = Console.ReadLine().ToLower();
                bool shiftOptionCheck = int.TryParse(shiftOption, out int parsedShiftOption);
                Shift shift;
                if (shiftOptionCheck && parsedShiftOption == 1 || shiftOption == "morning")
                {
                    shift = Shift.Morning;
                }
                else if (shiftOptionCheck && parsedShiftOption == 2 || shiftOption == "afternoon")
                {
                    shift = Shift.Afternoon;
                }
                else if (shiftOptionCheck && parsedShiftOption == 3 || shiftOption == "evening")
                {
                    shift = Shift.Evening;
                }
                else
                {
                    TextHelper.WriteLineInColor("Invalid choice!", ConsoleColor.Red);
                    return;
                }

                DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                List<Car> cars = StaticDatabase.Cars.Where(x => x.AssignedDrivers.Where(y => y.Shift == shift && y.LicenceExpiryDate > today).ToList().Count() == 0).ToList();
                cars.ForEach(x => Console.WriteLine($"({x.Id}) {x.Model} - Plate: {x.LicencePlate}"));
                string carOption = Console.ReadLine();
                bool carOptionCheck = int.TryParse(carOption, out int parsedCarOption);
                Car foundCarById = cars.FirstOrDefault(x => x.Id == parsedCarOption);
                if (carOptionCheck && foundCarById != null)
                {
                    if (foundDriverById != null)
                    {
                        foundCarById.AssignedDrivers.Add(foundDriverById);
                        foundDriverById.Car = foundCarById;
                        foundDriverById.Shift = shift;
                    }
                    else if (foundDriverByUsername != null)
                    {
                        foundCarById.AssignedDrivers.Add(foundDriverByUsername);
                        foundDriverByUsername.Car = foundCarById;
                        foundDriverByUsername.Shift = shift;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                TextHelper.WriteLineInColor("Invalid choice!", ConsoleColor.Red);
            }
            Console.ReadKey();
        }
    }
}
