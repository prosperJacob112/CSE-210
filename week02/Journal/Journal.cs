using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something kind someone did for me today?"
    };

    private Random _random = new Random();

    public void WriteEntry()
    {
        int promptIndex = _random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine() ?? "";

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        JournalEntry entry = new JournalEntry(date, prompt, response);

        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no journal entries to display.");
            return;
        }

        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (JournalEntry entry in _entries)
        {
            lines.Add(entry.Date);
            lines.Add(entry.Prompt);
            lines.Add(entry.Response);
        }

        File.WriteAllLines(filename, lines);
    }

    public bool LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            return false;
        }

        string[] lines = File.ReadAllLines(filename);

        // Each entry needs three lines: date, prompt, and response.
        if (lines.Length % 3 != 0)
        {
            return false;
        }

        List<JournalEntry> loadedEntries = new List<JournalEntry>();

        for (int index = 0; index < lines.Length; index += 3)
        {
            JournalEntry entry = new JournalEntry(
                lines[index],
                lines[index + 1],
                lines[index + 2]
            );

            loadedEntries.Add(entry);
        }

        // Replace the current journal with the entries from the file.
        _entries = loadedEntries;
        return true;
    }
}