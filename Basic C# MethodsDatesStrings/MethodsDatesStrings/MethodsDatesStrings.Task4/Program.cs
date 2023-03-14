// Make a method called AgeCalculator
// The method will have one input parameter, your birthday date
// The method should return your age
// Show the age of a user after he inputs a date
// Note: take into consideration if the birthday is today, after or before today

using Microsoft.VisualBasic;

string AgeCalculator(DateTime birthdayDate)
{
    DateTime todayDate = DateTime.Now;
    TimeSpan dateDiff = todayDate - birthdayDate;
    Console.WriteLine(dateDiff);
    var firstDay = new DateTime(1, 1, 1);
    int ageInYears = (firstDay + dateDiff).Year - 1;
    DateTime tomorrowDate = todayDate.AddDays(1); // setup to check if tomorrow is birthday
    Console.WriteLine(tomorrowDate);
    DateTime yesterdayDate = todayDate.AddDays(-1); // setup to check if yesterday was birthday
    Console.WriteLine(yesterdayDate);

    if (birthdayDate.Month == todayDate.Month && birthdayDate.Day == todayDate.Day) // check if today is birthday
    {
        string suffix = ageInYears % 10 == 1 ? "st" : ageInYears % 10 == 2 ? "nd" : ageInYears % 10 == 3 ? "rd" : "th";
        return $"Today is your {ageInYears}{suffix} birthday! HAPPY BIRTHDAY :)";
    }
    else if (birthdayDate.Month == tomorrowDate.Month && birthdayDate.Day == tomorrowDate.Day) // check if tomorrow is birthday
    {
        string suffix = ageInYears % 10 == 1 ? "st" : ageInYears % 10 == 2 ? "nd" : ageInYears % 10 == 3 ? "rd" : "th";
        return $"Tomorrow is your {ageInYears + 1}{suffix} birthday! SO EXCITED!!";
    }
    else if (birthdayDate.Month == yesterdayDate.Month && birthdayDate.Day == yesterdayDate.Day) // check if yesterday was birthday
    {
        string suffix = ageInYears % 10 == 1 ? "st" : ageInYears % 10 == 2 ? "nd" : ageInYears % 10 == 3 ? "rd" : "th";
        return $"Yesterday was your {ageInYears}{suffix} birthday! Hope you had a fun time!";
    }
    else
    {
        return $"Your age is {ageInYears}";
    }
}

void ProvideBirthdayInfo()
{
    Console.Write("Enter year of birth: ");
    string yearOfBirth = Console.ReadLine();
    bool yearOfBirthCheck = int.TryParse(yearOfBirth, out int parsedYearOfBirth);

    Console.Write("Enter month of birth: ");
    string monthOfBirth = Console.ReadLine();
    bool MonthOfBirthCheck = int.TryParse(monthOfBirth, out int parsedMonthOfBirth);

    Console.Write("Enter day of birth: ");
    string dayOfBirth = Console.ReadLine();
    bool dayOfBirthCheck = int.TryParse(dayOfBirth, out int parsedDayOfBirth);

    if (yearOfBirthCheck && MonthOfBirthCheck && dayOfBirthCheck)
    {
        try // check if dates exist (1992 has leap year, so Feb 29 works. 1999 does not, so Feb 29 returns contents inside CATCH
        {
            DateTime birthdayInfo = new DateTime(parsedYearOfBirth, parsedMonthOfBirth, parsedDayOfBirth);
            Console.WriteLine(AgeCalculator(birthdayInfo));
        }
        catch
        {
            Console.WriteLine("You did not enter a valid date!");
        }
    }
    else
    {
        Console.WriteLine("Your inputs were not all integers!");
    }
}

ProvideBirthdayInfo();