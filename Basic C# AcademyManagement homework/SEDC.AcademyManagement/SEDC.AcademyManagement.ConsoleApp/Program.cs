using SEDC.AcademyManagement.Domain.Enums;
using SEDC.AcademyManagement.Domain.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Database database = new Database();

while (true)
{
    try
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Admin admin = database.Admins.FirstOrDefault(x => x.Username == username);
        Trainer trainer = database.Trainers.FirstOrDefault(x => x.Username == username);
        Student student = database.Students.FirstOrDefault(x => x.Username == username);

        if (admin != null)
        {
            Console.WriteLine("[1] Add Admin\n[2] Add Trainer\n[3] Add Student\n[4] Remove Admin\n[5] Remove Trainer\n[6] Remove Student");
            string option = Console.ReadLine();
            bool optionCheck = int.TryParse(option, out int parsedOption);

            if (optionCheck)
            {
                switch (parsedOption)
                {
                    case 1:
                        admin.AddUser(database, Role.Admin);
                        break;
                    case 2:
                        admin.AddUser(database, Role.Trainer);
                        break;
                    case 3:
                        admin.AddUser(database, Role.Student);
                        break;
                    case 4:
                        admin.RemoveUser(database, Role.Admin, admin.Username);
                        break;
                    case 5:
                        admin.RemoveUser(database, Role.Trainer);
                        break;
                    case 6:
                        admin.RemoveUser(database, Role.Student);
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }

        }
        else if (trainer != null)
        {
            Console.WriteLine("[1] List students\n[2] List subjects");

            string option = Console.ReadLine();
            bool optionCheck = int.TryParse(option, out int parsedOption);

            if (optionCheck)
            {
                switch (parsedOption)
                {
                    case 1:
                        trainer.ListStudents(database);
                        break;
                    case 2:
                        trainer.ListSubjects(database);
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }
        }
        else if (student != null)
        {
            student.PrintDetails();
        }
        else
        {
            Console.WriteLine("Username does not exist.");
        }

        Console.WriteLine("\nPress any key to exit or 'y' to continue");
        string logInAgainInput = Console.ReadLine();

        if (logInAgainInput.Equals("y", StringComparison.CurrentCultureIgnoreCase) || logInAgainInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        {
            continue;
        }
        break;
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"[ERROR] {ex.Message}");
        Console.ResetColor();
    }
}