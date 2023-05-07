using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public static class StaticDatabase
    {
        static StaticDatabase()
        {
            SeedData();
        }

        public static List<User> Users { get; set; } = new List<User>();
        public static List<Driver> Drivers { get; set; } = new List<Driver>();
        public static List<Car> Cars { get; set; } = new List<Car>();

        private static void SeedData()
        {
            Users = new List<User>()
            {
                new User("Miki", "miki123", Role.Administrator),
                new User("Ace", "ace123", Role.Maintenance),
                new User("Mare", "mare123", Role.Manager),
                new User("Dragisha", "dade123", Role.Manager)
            };

            Cars = new List<Car>()
            {
                new Car("Ford", "F123321", new DateOnly(2023, 8, 5)),
                new Car("Tico", "T443224", new DateOnly(2026, 2, 3)),
                new Car("Ficho", "F443224", new DateOnly(2022, 8, 15)),
                new Car("Mercedes", "M443224", new DateOnly(2025, 4, 27))
            };

            Drivers = new List<Driver>()
            {
                new Driver("Boshko", "Boshkovski", null, null, "SK-1122-AB", new DateOnly(2027, 3, 22)),
                new Driver("Mishko", "Mishkoski", null, null, "SK-3344-CD", new DateOnly(2023, 7, 5)),
                new Driver("Boris", "Borisovski", null, null, "SK-3344-CD", new DateOnly(2019, 2, 3))
            };
        }
    }
}
