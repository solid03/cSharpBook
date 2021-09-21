using System;

Console.Title = "Kings' Dominions";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

Console.Write("How many Provinces? ");
string provinceString = Console.ReadLine();
Console.Write("How many Duchies? ");
string duchiesString = Console.ReadLine();
Console.Write("How many Estates? ");
string estatesString = Console.ReadLine();

int province = Convert.ToInt32(provinceString);
int duchies = Convert.ToInt32(duchiesString);
int estates = Convert.ToInt32(estatesString);

int playerScore = estates + (3 * duchies) + (6 * province);
//Console.WriteLine("Your score\t=\t" + playerScore);
Console.WriteLine($"Your score\t=\t{playerScore}");