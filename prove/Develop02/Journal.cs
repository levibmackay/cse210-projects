using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine(_entries[i].GetDisplayString());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        string content = "";
        for (int i = 0; i < _entries.Count; i++)
        {
            content += _entries[i].GetSaveString() + "\n";
        }

        File.WriteAllText(filename, content);
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string content = File.ReadAllText(filename);
        string[] lines = content.Split('\n');

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Trim() == "")
                continue;

            string[] parts = lines[i].Split('|');
            if (parts.Length == 4)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entries.Add(entry);
            }
        }
    }
}
