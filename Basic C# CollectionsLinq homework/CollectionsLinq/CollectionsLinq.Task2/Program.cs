//Create a list of ten numbers.
//Use LINQ to select in a list of the squares of all the numbers in the list from above.

List<long> list = new List<long> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<long> squaredList = list.Select(x => (long)Math.Pow(x, 2)).ToList();

foreach (long num in squaredList)
{
    Console.WriteLine(num);
}