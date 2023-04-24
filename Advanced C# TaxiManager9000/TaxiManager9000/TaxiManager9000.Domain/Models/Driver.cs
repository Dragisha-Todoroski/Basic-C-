using System.Reflection;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class Driver : BaseEntity
    {
        public Driver(string firstName, string lastName, Shift shift, Car car, string licence, DateOnly licenceExpiryDate)
        {
            Id = _driverCounter;
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            Licence = licence;
            LicenceExpiryDate = licenceExpiryDate;

            _driverCounter++;
        }

        private static int _driverCounter = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string Licence { get; set; }
        public DateOnly LicenceExpiryDate { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nShift: {Shift}\nCar: {Car.Model}\nLicence: {Licence}\nLicence Expiry Date: {LicenceExpiryDate}");
        }
    }
}
