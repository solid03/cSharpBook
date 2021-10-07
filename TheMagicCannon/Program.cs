using System;

string status = "";
for (int i = 1; i <= 100; i++) 
{
    if ((i % 15) == 0)
    {
        status = "Electric and Fire";
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if ((i % 5 == 0))
    {
        status = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if ((i % 3 == 0))
    {
        status = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        status = "Normal";
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine($"{i}: {status}");
}