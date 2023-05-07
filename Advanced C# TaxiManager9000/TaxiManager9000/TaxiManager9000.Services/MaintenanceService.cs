using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    public static class MaintenanceService
    {
        public static void ListVehicles()
        {
            StaticDatabase.Cars.ForEach(x => Console.WriteLine($"{(x.Id)} {x.Model} with Licence Plate {x.LicencePlate} and utilized {x.AssignedDrivers.Count() * 100 / 3}%"));
            Console.ReadKey();
        }

        public static void ListVehiclesLicencePlates()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            foreach (Car car in StaticDatabase.Cars)
            {
                int monthsToExpiry = ((car.LicensePlateExpiryDate.Year - today.Year) * 12) + car.LicensePlateExpiryDate.Month - today.Month + car.LicensePlateExpiryDate.Day - today.Day;
                if (car.LicensePlateExpiryDate <= today)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("(Expired) ");
                    Console.ResetColor();
                    Console.WriteLine($"Car Id: {car.Id} - Plate: {car.LicencePlate} expiring on {car.LicensePlateExpiryDate}");
                }
                else if (car.LicensePlateExpiryDate > today && monthsToExpiry <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"({monthsToExpiry} {(monthsToExpiry != 1 ? "months" : "month")} to expiry) ");
                    Console.ResetColor();
                    Console.WriteLine($"Car Id: {car.Id} - Plate: {car.LicencePlate} expiring on {car.LicensePlateExpiryDate}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(Valid) ");
                    Console.ResetColor();
                    Console.WriteLine($"Car Id: {car.Id} - Plate: {car.LicencePlate} expiring on {car.LicensePlateExpiryDate}");
                }
            }
            Console.ReadKey();
        }
    }
}
