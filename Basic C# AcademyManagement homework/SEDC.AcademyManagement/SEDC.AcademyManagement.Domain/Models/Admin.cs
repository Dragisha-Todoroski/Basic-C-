using SEDC.AcademyManagement.Domain.Enums;
using System.IO.Pipes;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Admin : User
    {
        public Admin(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Admin;
        }

        public Admin(string username) : base(username)
        {
            Role = Role.Admin;
        }

        public void AddUser(Database database, Role role)
        {
            Console.Write("Enter new username: ");
            string username = Console.ReadLine();
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            string age = Console.ReadLine();
            bool ageCheck = int.TryParse(age, out int parsedAge);

            if (ageCheck)
            {
                switch (role)
                {
                    case Role.Admin:
                        Admin admin = database.Admins.FirstOrDefault(x => x.Username == username);
                        if (admin != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Username already exists.");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            database.Admins.Add(new Admin(username, firstName, lastName, parsedAge));
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Added new Admin user: {username}");
                            Console.ResetColor();
                            break;
                        }

                    case Role.Trainer:
                        Trainer trainer = database.Trainers.FirstOrDefault(x => x.Username == username);
                        if (trainer != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Username already exists.");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            database.Trainers.Add(new Trainer(username, firstName, lastName, parsedAge));
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Added new Trainer user: {username}");
                            Console.ResetColor();
                            break;
                        }
                    case Role.Student:
                        Student student = database.Students.FirstOrDefault(x => x.Username == username);
                        if (student != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Username already exists.");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            database.Students.Add(new Student(username, firstName, lastName, parsedAge));
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Added new Student user: {username}");
                            Console.ResetColor();
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("You did not enter an appropriate age number.");
            }
        }

        public void RemoveUser(Database database, Role role, string deleteSelfUsername = "Irrelevant")
        {
            Console.Write("Enter new username: ");
            string username = Console.ReadLine();

            switch (role)
            {
                case Role.Admin:
                    Admin admin = database.Admins.FirstOrDefault(x => x.Username == username);
                    if (admin == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Username doesn't exist.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        if (username == deleteSelfUsername)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Cannot remove yourself!");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            database.Admins.Remove(admin);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Removed Admin user: {username}");
                            Console.ResetColor();
                            break;
                        }
                    }

                case Role.Trainer:
                    Trainer trainer = database.Trainers.FirstOrDefault(x => x.Username == username);
                    if (trainer == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Username doesn't exist.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        database.Trainers.Remove(trainer);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Removed Trainer user: {username}");
                        Console.ResetColor();
                        break;
                    }
                case Role.Student:
                    Student student = database.Students.FirstOrDefault(x => x.Username == username);
                    if (student == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Username doesn't exist.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        database.Students.Remove(student);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Removed Student user: {username}");
                        Console.ResetColor();
                        break;
                    }
            }
        }
    }
}
