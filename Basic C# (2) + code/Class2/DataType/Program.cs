Console.WriteLine("------- INTEGER -------");

int number;
number = 0;

Console.WriteLine(number.GetType());
Console.WriteLine(number.GetTypeCode());


Console.WriteLine("------- FLOAT -------");

float decimalNumber = 1.2F;
Console.WriteLine(decimalNumber.GetTypeCode());


Console.WriteLine("------- CHAR -------");

char charVariable = 'A';
Console.WriteLine(charVariable.GetTypeCode());


Console.WriteLine("------- STRING -------");

string stringVariable = "Hello SEDC";
Console.WriteLine(stringVariable);
Console.WriteLine(stringVariable.GetTypeCode());


Console.WriteLine("------- BOOLEAN -------");

bool boolVariable = false; // boolVariable = default would be false
Console.WriteLine(boolVariable);
Console.WriteLine(boolVariable.GetTypeCode());


Console.WriteLine("------- DOUBLE -------");

double doubleVariable = 0.2;
Console.WriteLine(doubleVariable.GetTypeCode());

//double doubleVariable2 = default;
//Console.WriteLine(doubleVariable2);

//number = 2.2;


int a = 12;
int b = 12;

int sum = a + b;
Console.WriteLine(sum);

var num = 2;
//num = "asdasd";


Console.WriteLine("------- DateTime -------");

DateTime currentTime = DateTime.Now;
Console.WriteLine(currentTime);
Console.WriteLine(currentTime.GetTypeCode());


// Exercise 1

double var1 = 2.5;
double var2 = 63.467;

double div1 = var1 / var2;
Console.WriteLine(div1);

int var3 = 2;
int var4 = 3;

int div2 = var3 / var4;
Console.WriteLine(div2);


// Exercise 2

string stringVar1 = "Hello ";
string stringVar2 = "SEDC";

string stringConcat1 =  stringVar1 + stringVar2;
Console.WriteLine(stringConcat1);

string stringVar3 = "9";
string stringVar4 = "3";

string stringConcat2 =  stringVar3 + stringVar4;
Console.WriteLine(stringConcat2);