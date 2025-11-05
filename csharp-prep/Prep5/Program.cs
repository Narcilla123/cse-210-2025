using System;
using System.ComponentModel.DataAnnotations;

class Functions
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        Console.WriteLine();

        string userName = promptUserName();
        Console.WriteLine();

        int favoriteNumber = PromptUserNumber();
        Console.WriteLine();

        int birthYear;
        PromptUserBirthYear(out birthYear);
        Console.WriteLine();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome!!!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        int number;
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                break;
            }
            Console.WriteLine("Invalid Input. Please enter a valid whole number.");
        }
        return number;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        birthYear = 0;

        while (true)
        {
            Console.Write("Enter the year you were born: ");

            if (int.TryParse(Console.ReadLine(), out birthYear) && birthYear > 1900 && birthYear <= DateTime.Now.Year)
            {
                break;
            }
            Console.WriteLine("Invalid Input. Enter a valid year");
        }
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNum, int year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - year;

        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
        Console.WriteLine($"{name} you will turn {age} this year.");
    }
}