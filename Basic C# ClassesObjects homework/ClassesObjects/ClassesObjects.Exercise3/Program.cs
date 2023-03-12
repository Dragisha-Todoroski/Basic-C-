//Create a class Student that has properties: Name, Academy
//and Group
//Create an array with 5 new Students(objects)
//The user should enter a name and the user information
//should be displayed in the console if a user by that name
//exists
//If there is no such user it should show an error message

using ClassesObjects.Exercise3.Classes;

Student[] students = new Student[5];
students[0] = new Student() { Name = "Master Chief", Academy = "SEDC", Group = "Spartan-2" };
students[1] = new Student() { Name = "Nathan Drake", Academy = "SEDC", Group = "Adventuring" };
students[2] = new Student() { Name = "Kratos", Academy = "Brainster", Group = "Greek Gods" };
students[3] = new Student() { Name = "Mario", Academy = "Codecademy", Group = "Nintendo" };
students[4] = new Student() { Name = "Sonic", Academy = "SEDC", Group = "SEGA" };

Console.WriteLine("Check for name: ");
string nameInput = Console.ReadLine();
Student foundStudentName = Array.Find(students, elem => elem.Name.ToUpper() == nameInput.ToUpper());

if (foundStudentName != null )
{
    Console.WriteLine($"Name: {foundStudentName.Name} - Academy: {foundStudentName.Academy} - Group: {foundStudentName.Group}");
}
else
{
    Console.WriteLine("Not Found!");
}