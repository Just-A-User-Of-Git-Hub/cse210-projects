public class Entry
{
    public string _text;
    public string _time;
    public string _prompt;
    public void Display()
    {
        Console.WriteLine($"Date: {_time}\nPrompt: {_prompt}\nResponse:{_text}")
    }
}