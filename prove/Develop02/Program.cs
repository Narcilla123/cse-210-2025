using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        Console.WriteLine("Welcome to the Daily Journal App");

        while (choice != "5")
        {
            DisplayMenu();
            Console.WriteLine("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename?");
                    string saveFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("What is the filename to load?");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("\nThank you for the journal entry, good day!");
                    break;
                default:
                    Console.WriteLine("\nInvalid Option. Please choose a number from the menu");
                    break;
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following: ");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static void WriteNewEntry(Journal journal)
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        string currentDate = DateTime.Now.ToShortDateString();

        Console.WriteLine($"\n{currentDate}");
        Console.WriteLine($"Prompt: {selectedPrompt}");
        Console.Write("> ");
        string userResponse = Console.ReadLine();

        Entry newEntry = new Entry(currentDate, selectedPrompt, userResponse);
        journal.AddEntry(newEntry);

        Console.WriteLine("\nEntry recorded");

    }
}

    