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
    int ageInDays = (int)dateDiff.TotalDays;
    int ageInYears = ageInDays / 365;
    Console.WriteLine(ageInYears);
    Console.WriteLine(ageInDays);
    DateTime tomorrowDate = todayDate.AddDays(1); // setup to check if tomorrow is birthday
    Console.WriteLine(tomorrowDate);
    DateTime yesterdayDate = todayDate.AddDays(-1); // setup to check if yesterday was birthday
    Console.WriteLine(yesterdayDate);
    //int currentDayOfYear = todayDate.DayOfYear;
    //Console.WriteLine(currentDayOfYear);
    //int birthdayDayOfYear = birthdayDate.DayOfYear;
    //Console.WriteLine(birthdayDayOfYear);
    //int differenceInDays = birthdayDate.DayOfYear - todayDate.DayOfYear;
    //Console.WriteLine(differenceInDays);

    if (birthdayDate.Month == todayDate.Month && birthdayDate.Day == todayDate.Day) // check if today is birthday
    {
        if (ageInYears % 10 == 1)
        {
            return $"Today is your {ageInYears}st birthday! HAPPY BIRTHDAY :)";
        }
        else if (ageInYears % 10 == 2)
        {
            return $"Today is your {ageInYears}nd birthday! HAPPY BIRTHDAY :)";
        }
        else if ( ageInYears % 10 == 3)
        {
            return $"Today is your {ageInYears}rd birthday! HAPPY BIRTHDAY :)";
        }
        else
        {
            return $"Today is your {ageInYears}th birthday! HAPPY BIRTHDAY :)";
        }
    }
    else if (birthdayDate.Month == tomorrowDate.Month && birthdayDate.Day == tomorrowDate.Day) // check if tomorrow is birthday
    {
        if (ageInYears % 10 == 1)
        {
            return $"Tomorrow is your {ageInYears}st birthday! SO EXCITED!!";
        }
        else if (ageInYears % 10 == 2)
        {
            return $"Tomorrow is your {ageInYears}nd birthday! SO EXCITED!!";
        }
        else if (ageInYears % 10 == 3)
        {
            return $"Tomorrow is your {ageInYears}rd birthday! SO EXCITED!!";
        }
        else
        {
            return $"Tomorrow is your {ageInYears}th birthday! SO EXCITED!!";
        }
    }
    else if (birthdayDate.Month == yesterdayDate.Month && birthdayDate.Day == yesterdayDate.Day) // check if yesterday was birthday
    {
        if (ageInYears % 10 == 1)
        {
            return $"Yesterday was your {ageInYears}st birthday! Hope you had a fun time!";
        }
        else if (ageInYears % 10 == 2)
        {
            return $"Yesterday was your {ageInYears}nd birthday! Hope you had a fun time!";
        }
        else if (ageInYears % 10 == 3)
        {
            return $"Yesterday was your {ageInYears}rd birthday! Hope you had a fun time!";
        }
        else
        {
            return $"Yesterday was your {ageInYears}th birthday! Hope you had a fun time!";
        }
    }
    //else if (birthdayDate.Month >= todayDate.Month && birthdayDate.Day > todayDate.Day) // TUKA MI E PROBLEMOT! AKO NAPISHEME NEKOJA GODINA SO LEAP YEAR, PRIMER 1992, MESEC 3, DEN 17 (go pisuvam ova na 11ti, probaj so barem 2 dena od tvojot datum), TOGASH MI VRAKJA GRESHNA BROJKA ZA KOLKU GODINI IMA, NI DAVA 1 GODINA POVEKJE. POSLE NEKOLKU DENA OD MOMENTALNIOT, OVA PRESTANUVA DA E PROBLEM I POKAZHUVA DOBRO. AKO PROBAME SO GODINA SHTO NEMA LEAP YEAR, KAKO 1999, ISTIOT PROBLEM E, NO SE POPRAVA EDEN DEN PORANO. EVE NA 11TI PISHUVAM, 1999, 3, 17, I MI DAVA 24 GODINI. 1999, 3, 18 GO POPRAVA I STANUVA 23 KO SHTO TREBA. 1992, 3, 18 DAVA 31 GODINI I E GRESHNO. 1992, 3, 19 DAVA 30 GODINI I E TOCHNO. IMA NEKOJ NACHIN DA GO SREDIME OVA??
    //{
    //    return $"Your age is: {ageInYears}";
    //}
    else
    {
        return $"Your age is {ageInYears}";
    }
}

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
    //DateTime birthInfoOnlyDate = birthdayInfo.Date;
    //Console.WriteLine(birthInfoOnlyDate.ToString("dd/MM/yyyy"));
        Console.WriteLine(AgeCalculator(birthdayInfo));
    } 
    catch
    {
        Console.WriteLine("Something went wrong!");
    }
}
else
{
    Console.WriteLine("Something went wrong!");
}

Console.ReadLine();