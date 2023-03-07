string[] studentsG1 = new string[5];
studentsG1[0] = "Jaime Lannister";
studentsG1[1] = "Tyrion Lannister";
studentsG1[2] = "Jon Snow";
studentsG1[3] = "Ned Stark";
studentsG1[4] = "Brienne of Tarth";

string[] studentsG2 = new string[5];
studentsG2[0] = "Harry Potter";
studentsG2[1] = "Ron Weasley";
studentsG2[2] = "Hermione Granger";
studentsG2[3] = "Severus Snape";
studentsG2[4] = "Rubeus Hagrid";

Console.WriteLine("Enter student group: ( there are 1 and 2 )");

string studentGroupInput = Console.ReadLine();
bool studentGroupInputCheck = int.TryParse(studentGroupInput, out int parsedStudentGroupInput);

if (studentGroupInputCheck)
{
    if (parsedStudentGroupInput == 1)
    {
        StudentGroupChoice(studentsG1, "G1");
    }
    else if (parsedStudentGroupInput == 2)
    {
        StudentGroupChoice(studentsG2, "G2");
    }
    else
    {
        Console.WriteLine("You did not enter 1 or 2. Shutting down, sorry bud :/");
    }
}
else
{
    Console.WriteLine("You did not enter a number. Shutting down :(");
}

Console.ReadLine();

void StudentGroupChoice(string[] studentGroup, string groupNumber)
{
    Console.WriteLine($"The students in {groupNumber} are:");

    foreach (string student in studentGroup)
    {
        Console.WriteLine(student);
    }
}