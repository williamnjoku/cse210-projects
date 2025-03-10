using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
          
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine(new string('-', 50)); 
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename to save the journal entries: ");
        string fileName = Console.ReadLine(); 
        foreach (Entry entry in _entries)
        {
            entry.SaveToFile(fileName); 
        }
        Console.WriteLine($"Entries saved to {fileName}!");
    }

    public void LoadFromFile(string fileName)
    {
        if (System.IO.File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No previous journal found.");
        }
    }
}