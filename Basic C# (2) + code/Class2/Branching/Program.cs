Console.WriteLine("------- BRANCHING -------");

int someNumber = int.Parse(Console.ReadLine());
if(someNumber > 0)
{
    Console.WriteLine(someNumber + " is larger");
}
else
{
    Console.WriteLine(someNumber + " is smaller");
}

// Exercise 5

int applesPerBranch = 8;
int basketSpace = 5;
int baskets;
int trees = int.Parse(Console.ReadLine());


if(trees > 0)
{
    int totalApples = applesPerBranch * trees * 12;

    if (totalApples % basketSpace == 0)
    {
        baskets = totalApples / basketSpace;
    }
    else
    {
        baskets = totalApples / basketSpace + 1;
    }
    Console.WriteLine(baskets);
}
