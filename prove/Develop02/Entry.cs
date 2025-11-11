using System;
public class Entry
{
    string Date { get; set; }
    string Prompt { get; set; }
    string Response { get; set; }
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public Entry()
    {
        Date = "";
        Prompt = "";
        Response = "";
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {Date} - Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public override string ToString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}