using System;

Console.Write("Enter a number: ");
string input = Console.ReadLine();

int number = Convert.ToInt32(input);
if ((number % 2) == 0)
{
    Console.WriteLine("Tick");
}
else { 
    Console.WriteLine("Tock");
}