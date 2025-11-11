using System.Collections.Generic;
using System.Linq.Expressions;

class Journal
{
    List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("\nThe Journal is empty. Feel free to write something!");
            return;
        }
        Console.WriteLine("\n Journal Entries");
        foreach (var entry in Entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in Entries)
                {
                    outputFile.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();

        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                }
                else
                {
                    Console.WriteLine($"Skipping Line not formed correctly");
                }
            }
            Console.WriteLine($"\nJournal successfully loaded from {filename}. Total Entries: {Entries.Count}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nError: File not found at {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError occurred while loading file: {ex.Message}");
        }
    }
}