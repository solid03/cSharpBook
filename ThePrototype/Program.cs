using System;

int number = 0;
int guess = 0;

while (number < 1 || number > 100)
{
    Console.Write("User 1:\tPick a number between 1 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("User 2:\tGuess the number.");
while (guess != number)
{
    Console.Write("What is your guess? ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > number)
    {
        Console.WriteLine($"{guess} is too high.");
        continue;
    }
    else if (guess < number)
    {
        Console.WriteLine($"{guess} is too low.");
        continue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You guessed the number!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}