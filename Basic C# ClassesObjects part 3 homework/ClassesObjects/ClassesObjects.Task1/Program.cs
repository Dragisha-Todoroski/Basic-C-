// Exercise Task 1

// You are given the following string "The whole group of G2 loves C#.They find learning this language fun and easy!". Print the text after the ".", using string methods.

string line = "The whole group of G2 loves C#.They find learning this language fun and easy!";
string[] splitLine = line.Split('.');
Console.WriteLine(splitLine[1]);