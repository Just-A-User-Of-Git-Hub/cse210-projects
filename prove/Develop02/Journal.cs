public class Journal
{
    public List<Entry> _listOfEntries = new List<Entry>();
    public void AddEntry(string entryName)
    {
        Entry  = new Entry();
        _listOfEntries.Add(entryname);
    }
    public void DisplayEntries()
    {
        foreach(Entry entry in _listOfEntries)
        {
            
            entry.Display();
        }
    }
    public void Save(string filename)
    {

    }
    public void Load(string filename)
    {
        _listOfEntries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split("~|~");
            AddEntry()

        }
    }
    public string GeneratePrompt()
    {
        return "hello";
    }

}