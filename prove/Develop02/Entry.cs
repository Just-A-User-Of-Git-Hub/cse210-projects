public class Entry
{
    public string _text;
    public string _time;
    public string _prompt;

    public string _location;
    public void Display()
    {
        Console.WriteLine($"Date: {_time}");
        if(_location != "")
        {
            Console.WriteLine($"Location: {_location}");
        }
        Console.WriteLine($"Prompt: {_prompt}\nResponse: {_text}");
    }
}