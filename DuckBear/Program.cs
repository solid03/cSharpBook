using System;

Console.Write("How many eggs collected? ");
string totalEggsPrompt = Console.ReadLine();
int totalEggs = Convert.ToInt32(totalEggsPrompt);

int peopleEggs = totalEggs / 4;
int duckbearEggs = totalEggs % 4;

Console.WriteLine("People Eggs:\t" + peopleEggs);
Console.WriteLine("Duckbear Eggs:\t" + duckbearEggs);