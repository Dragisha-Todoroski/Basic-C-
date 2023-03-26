using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Trainer;
        }

        public void ListStudents(Database database)
        {
            foreach (Student stud in database.Students)
            {
                Console.WriteLine($"{stud.Firstname} {stud.Lastname}");
            }
            Console.WriteLine("\nSelect student (first name):");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine("\nLast name:");
            string lastNameInput = Console.ReadLine();

            Student getStudent = database.Students.FirstOrDefault(x => string.Equals(x.Firstname, firstNameInput, StringComparison.CurrentCultureIgnoreCase) && string.Equals(x.Lastname, lastNameInput, StringComparison.CurrentCultureIgnoreCase));

            if (getStudent != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (KeyValuePair<Subject, int> grade in getStudent.Grades)
                {
                    Console.WriteLine($"{grade.Key.Name}: {grade.Value}");
                }
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Student doesn't exist");
            }
        }

        public void ListSubjects(Database database)
        {
            foreach (Subject subject in database.Subjects)
            {
                Console.WriteLine($"{subject.Name}: {database.Students.Where(x => x.Grades != null && x.Grades.ContainsKey(subject)).Count()}");
            }
        }
}
}
