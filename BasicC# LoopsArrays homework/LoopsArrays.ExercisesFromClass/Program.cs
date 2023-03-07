#region Exercise 4

string[] stringArray = new string[5];
stringArray[0] = "Bob";
stringArray[1] = "Josh";
stringArray[2] = "Eugene";
stringArray[3] = "Adam";
stringArray[4] = "Borat";
var totalElementsString = stringArray.Count();
Console.WriteLine(totalElementsString);

// претпоставувам дека немаше потреба да дадам values на овие arrays

double[] doubleArray = new double[5] { 2.2, 3.3, 4.4, 5.5, 6.6 };
var totalElementsDouble = doubleArray.Count();
Console.WriteLine(totalElementsDouble);



char[] charArray = new char[5];
charArray[0] = 'H';
charArray[1] = 'E';
charArray[2] = 'L';
charArray[3] = 'L';
charArray[4] = 'O';
var totalElementsChar = charArray.Count();
Console.WriteLine(totalElementsChar);



bool[] boolArray = new bool[5];
boolArray[0] = true;
boolArray[1] = false;
boolArray[2] = false;
boolArray[3] = true;
boolArray[4] = false;
var totalElementsBool = boolArray.Count();
Console.WriteLine(totalElementsBool);



int[][] intArrayOfArrays = new int[][]
{
    new int[] {1, 2},
    new int[] {3, 4},
    new int[] {5, 6},
    new int[] {7, 8},
    new int[] {9, 10},
};
var totalElementsArrayOfArrays = intArrayOfArrays.Count();
Console.WriteLine(totalElementsArrayOfArrays);

Console.ReadLine();

#endregion

#region Exercise 5

//int[] intArray = new int[5];

//Console.Write("Please enter input 1: ");
//string input1 = Console.ReadLine();
//bool input1Check = int.TryParse(input1, out int parsedInput1);

//Console.Write("Please enter input 2: ");
//string input2 = Console.ReadLine();
//bool input2Check = int.TryParse(input2, out int parsedInput2);

//Console.Write("Please enter input 3: ");
//string input3 = Console.ReadLine();
//bool input3Check = int.TryParse(input3, out int parsedInput3);

//Console.Write("Please enter input 4: ");
//string input4 = Console.ReadLine();
//bool input4Check = int.TryParse(input4, out int parsedInput4);

//Console.Write("Please enter input 5: ");
//string input5 = Console.ReadLine();
//bool input5Check = int.TryParse(input5, out int parsedInput5);

//if (input1Check && input2Check && input3Check && input4Check && input5Check)
//{
//    //intArray[0] = parsedInput1;
//    //intArray[1] = parsedInput2;
//    //intArray[2] = parsedInput3;
//    //intArray[3] = parsedInput4;
//    //intArray[4] = parsedInput5; // version 1

//    int[] parsedIntArray = new int[5] { parsedInput1, parsedInput2, parsedInput3, parsedInput4, parsedInput5 }; // version 2

//    for (int i = 0; i < parsedIntArray.Length; i++)
//    {
//        intArray[i] = parsedIntArray[i]; // version 2
//        Console.WriteLine(intArray[i]);
//    }

//    int sum = intArray.Sum();
//    Console.WriteLine(sum);
//}
//else
//{
//    Console.WriteLine("Whoops!");
//}

//Console.ReadLine();

#endregion

#region Exercise 6

//string[] namesArray = new string[3];
//namesArray[0] = "Johnny";
//namesArray[1] = "Carol";
//namesArray[2] = "Alex";

//InputName();

//bool loop = true;
//int flag = 0;

//while (loop)
//{
//    if (flag == 0)
//    {
//        Console.WriteLine("Do you want to enter another name?\nPress \"Y\" if YES or press \"N\" if NO...");
//    }
//    flag = 0;
//    string yesOrNo = Console.ReadLine();
//    string yesOrNoToLowercase = yesOrNo.ToLower();

//    if (yesOrNoToLowercase == "y" || yesOrNoToLowercase == "yes")
//    {
//        InputName();
//    }
//    else if (yesOrNoToLowercase == "n" || yesOrNoToLowercase == "no")
//    {
//        foreach (string name in namesArray)
//        {
//            Console.WriteLine(name);
//        }
//        loop = false;
//    }
//    else
//    {
//        Console.WriteLine("Incorrect input. \"Y\" or  \"N\"");
//        flag++;
//    }
//}
//void InputName()
//{
//    Console.Write("Enter a name: ");
//    string inputName = Console.ReadLine();
//    string inputNameCapitalLetter = char.ToUpper(inputName[0]) + inputName.Substring(1).ToLower(); // capitalize and make all other letters lowercase
//    Array.Resize(ref namesArray, namesArray.Length + 1);
//    namesArray[namesArray.Length - 1] = inputNameCapitalLetter;
//}

//Console.ReadLine();

#endregion