using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{

    private static List<Entry> _entries = new List<Entry>();


    public static void AddEntry()
    {

        string _prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(_prompt);
        Console.Write("Your answer: ");
        string _response = Console.ReadLine();

        Entry _newEntry = new Entry(_prompt, _response);
        _entries.Add(_newEntry);

        //Entry.DisplayEntry();
        //List<string> _entry = new List<string>();

        //Console.WriteLine(result);
    }

    public static void DisplayAll()

    {
        Console.WriteLine("\n--- Journal Entries --- \n");
        if (_entries.Count == 0)
        {
            Console.WriteLine("Didn't find anything.");
        }
        foreach (Entry _entry in _entries)
        {
            Console.WriteLine(_entry.GetDisplay());
        }
    }

    public static void SaveToFile()
        {
        Console.Write("Enter filename to save to: ");
        string _filename = Console.ReadLine();

        using (StreamWriter _writer = new StreamWriter(_filename))
        {
             foreach (Entry _entry in _entries)
            {
                _writer.WriteLine(_entry.Serialize());
            }
    }
    Console.WriteLine("Journal saved.");
}

//Console.WriteLine("I hope this works. ");
public static void LoadFromFile()
{
    Console.Write("Enter filename to load from: ");
    string _filename = Console.ReadLine();

    if (!File.Exists(_filename))
    {
        Console.WriteLine("File not found.\n");
        return;
    }

    string[] _lines = File.ReadAllLines(_filename);
    _entries.Clear();

        foreach (string _line in _lines)
        {
            Entry _entry = Entry.Deserialize(_line);
            _entries.Add(_entry);
        }
    Console.WriteLine("Journal loaded successfully.");
    }
}
