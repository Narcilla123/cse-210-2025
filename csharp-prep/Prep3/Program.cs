using System;

class GuessingGame
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            PlayGame();
            Console.WriteLine("\nDo you want to play again? (yes/no)");
            playAgain = Console.ReadLine();
        }
    }
    static void PlayGame()
    {
        Random random = new Random();

        int magicNumber = random.Next(1, 101);
        int guess = -1;
        int guessCount = 0;

        Console.WriteLine("\n New Game Started!");
        Console.WriteLine("Im thinking of a number between 1 and 100");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                guessCount++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a whole number plz");
            }
        }
        Console.WriteLine($"It took you {guessCount} guesses to find the magic number!");
    }
}