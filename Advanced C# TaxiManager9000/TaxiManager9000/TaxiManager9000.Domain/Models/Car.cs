namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {
        public Car(string model, string licencePlate, DateOnly licensePlateExpiryDate)
        {
            Id = _carCounter;
            Model = model;
            LicencePlate = licencePlate;
            LicensePlateExpiryDate = licensePlateExpiryDate;

            _carCounter++;
        }

        private static int _carCounter = 1;
        public string Model { get; set; }
        public string LicencePlate { get; set; }
        public DateOnly LicensePlateExpiryDate { get; set; }
        public List<Driver> AssignedDrivers { get; set; } = new List<Driver>();

        public override void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nModel: {Model}\nLicence Plate: {LicencePlate}\nLicence Plate Expiry Date: {LicensePlateExpiryDate}\nAssigned Drivers: {AssignedDrivers}");
        }
    }
}
