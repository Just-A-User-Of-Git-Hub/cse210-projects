using System.Net;
using System.IO;
public class Journal
{
    public List<Entry> _listOfEntries = new List<Entry>();
    public List<string> _listOfPrompts = new List<string>();
    public Random _random = new Random();

    public void AddEntry(string time, string prompt, string text, string location)
    {
        Entry newentry = new Entry();
        _listOfEntries.Add(newentry);
        _listOfEntries[_listOfEntries.Count - 1]._time = time;
        _listOfEntries[_listOfEntries.Count - 1]._prompt = prompt;
        _listOfEntries[_listOfEntries.Count - 1]._text = text;
        _listOfEntries[_listOfEntries.Count - 1]._location = location;
    }
    public void DisplayEntries()
    {
        foreach(Entry entry in _listOfEntries)
        {
            Console.WriteLine();
            entry.Display();
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _listOfEntries)
            {
                string time = entry._time;
                string prompt = entry._prompt;
                string text = entry._text;
                string location = entry._location;
                outputFile.WriteLine($"{time}~|~{prompt}~|~{text}~|~{location}");
            }
        }
    }
    public void Load(string filename)
    {
        _listOfEntries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split("~|~");
            AddEntry(parts[0], parts[1], parts[2], parts[3]);
        }
    }
    public string GeneratePrompt()
    {
        int i = _random.Next(0, _listOfPrompts.Count);
        string prompt = _listOfPrompts[i];
        Console.WriteLine(prompt);
        return prompt;
    }

}