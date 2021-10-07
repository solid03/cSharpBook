using System;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope\n2 - Torches\n3 - Climbing Equiptment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
Console.Write("What number do you want to see the price of?: ");
int playerChoice = Convert.ToInt32(Console.ReadLine());
Console.Write("What is your name? ");
string playerName = Console.ReadLine();

string item = "";
float cost = 0;

switch (playerChoice) 
{
    case 1:
        item = "Rope";
        cost = 10;
        break;
    case 2:
        item = "Torches";
        cost = 15;
        break;
    case 3:
        item = "climbing Equiptment";
        cost = 25;
        break;
    case 4:
        item = "Clean Water";
        cost = 1;
        break;
    case 5:
        item = "Machete";
        cost = 20;
        break;
    case 6:
        item = "Canoe";
        cost = 200;
        break;
    case 7:
        item = "Food Supplies";
        cost = 1;
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("We don't have that item...");
        Console.ForegroundColor = ConsoleColor.White;
        return;
}
if (playerName == "sean" || playerName == "Sean")
    cost /= 2;

Console.WriteLine($"{item} costs {cost} gold");