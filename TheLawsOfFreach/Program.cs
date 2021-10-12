using System;

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue;
foreach (int currentValue in array) 
{
    currentMinimum = Math.Min(currentValue, currentMinimum);
}
Console.WriteLine($"Lowest Number:\t{currentMinimum}");

int total = 0;
foreach (int currentValue in array) 
{
    total += currentValue;
}
float average = (float)total / array.Length;
Console.WriteLine($"Average Number:\t{average}");