using System;

Console.Write("What's the base? ");
string widthString = Console.ReadLine();
float width = Convert.ToInt32(widthString);

Console.Write("What's the height? ");
string heightString = Console.ReadLine();
float height = Convert.ToInt32(heightString);

float area = width * height / 2;
Console.WriteLine("Area of Triangle: " + area);