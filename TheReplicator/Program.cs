using System;

int[] arrayOne = new int[5];
int[] arrayTwo = new int[5];
for (int i = 0; i < arrayOne.Length; i++)
{
    Console.Write($"Please enter a number for array index {i}: ");
    arrayOne[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("arrayOne\tarrayTwo");
Console.WriteLine("--------\t--------");
for (int i = 0; i < arrayOne.Length; i++)
{
    System.Threading.Thread.Sleep(500);
    arrayTwo[i] = arrayOne[i];
    Console.WriteLine($"{arrayOne[i]}\t->\t{arrayTwo[i]}");
}