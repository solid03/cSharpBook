using System;

Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
string targetRowString = Console.ReadLine();
Console.Write("Target Column? ");
string targetColumnString = Console.ReadLine();

int targetRow = Convert.ToInt32(targetRowString);
int targetColumn = Convert.ToInt32(targetColumnString);
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({targetRow},{targetColumn - 1})");
Console.WriteLine($"({targetRow - 1},{targetColumn})");
Console.WriteLine($"({targetRow},{targetColumn + 1})");
Console.WriteLine($"({targetRow + 1},{targetColumn})");
Console.Beep(440, 500);