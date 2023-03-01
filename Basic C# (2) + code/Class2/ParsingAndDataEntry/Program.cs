//Console.Write("Enter last name: ");
//string lastName = Console.ReadLine();
//Console.WriteLine(lastName);
//Console.Write("Enter first name: ");
//string firstName = Console.ReadLine();
//Console.WriteLine(firstName);
//Console.WriteLine(firstName.GetTypeCode());

//Console.ReadLine();


Console.WriteLine("------- PARSING -------");

string numberString = "2";
string numberString2 = "3.2";

int number = int.Parse(numberString);
double number2 = double.Parse(numberString2);

Console.WriteLine(number);
Console.WriteLine(number.GetTypeCode());
Console.WriteLine(number2);
Console.WriteLine(number2.GetTypeCode());
//Console.ReadLine();

string numberStringOne = "2";
string numberStringTwo = "3.2";

int parseInt = Convert.ToInt32(numberStringOne);
double parseDouble = Convert.ToDouble(numberStringTwo);
Console.WriteLine(parseInt);
Console.WriteLine(parseInt.GetTypeCode());
Console.WriteLine(parseDouble);
Console.WriteLine(parseDouble.GetTypeCode());

Console.WriteLine("------- Try Parse -------");
//int ifParsedValue;
string numberParse = "221.05";
bool parsingSuccess = double.TryParse(numberParse, out double ifParsedValue);

Console.WriteLine(parsingSuccess);
Console.WriteLine(ifParsedValue);
Console.WriteLine(ifParsedValue.GetTypeCode());

Console.WriteLine("Enter number: ");
var enterNumber = int.Parse(Console.ReadLine());
Console.WriteLine(enterNumber);
Console.WriteLine(enterNumber.GetTypeCode());