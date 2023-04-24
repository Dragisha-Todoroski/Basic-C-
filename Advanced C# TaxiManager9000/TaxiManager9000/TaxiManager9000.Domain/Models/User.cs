using System.Reflection;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class User : BaseEntity
    {
        public User(string username, string password, Role role)
        {
            Id = _userCounter;
            Username = username;
            Password = password;
            Role = role;

            _userCounter++;
        }

        private static int _userCounter = 1;
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nUsername: {Username}\nPassword: {Password}\nRole: {Role}");
        }
    }
}
