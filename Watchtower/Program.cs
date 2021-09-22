using System;

Console.Write("Enter X coordinate: ");
string xString = Console.ReadLine();
Console.Write("Enter Y coordinate: ");
string yString = Console.ReadLine();

int xCoordinate = Convert.ToInt32(xString);
int yCoordinate = Convert.ToInt32(yString);

if (xCoordinate < 0) {
    if (yCoordinate < 0) {
        Console.WriteLine("Northwest!");    
    }
    if (yCoordinate == 0) {
        Console.WriteLine("West!");
    }
    if (yCoordinate > 0) {
        Console.WriteLine("Southwest!");
    }
}
if (xCoordinate == 0) {
    if (yCoordinate < 0)
    {
        Console.WriteLine("North!");
    }
    if (yCoordinate == 0)
    {
        Console.WriteLine("The Enemy is here!");
    }
    if (yCoordinate > 0)
    {
        Console.WriteLine("South!");
    }
}
if (xCoordinate > 0)
{
    if (yCoordinate > 0)
    {
        Console.WriteLine("Northeast!");
    }
    if (yCoordinate == 0)
    {
        Console.WriteLine("East!");
    }
    if (yCoordinate < 0)
    {
        Console.WriteLine("Southeast!");
    }
}