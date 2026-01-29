using System.Collections.Concurrent;

public class Activity
{
    private string _name;
    private string _discription;
    protected int _duration;
    private int _usesLog = 0;
    private int _timeLog = 0;

    public Activity(string name, string discription)
    {
        _name = name;
        _discription = discription;
    }

    protected void Start()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_discription);

        Console.WriteLine("\nHow long, in seconds, would you like for you session?");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(4);
    }
    protected void End()
    {
        Console.WriteLine("\nGood Job!");
        Pause(6);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        _usesLog += 1;
        _timeLog += _duration;
        Pause(4);
    }
    protected void Pause(int pauseDuration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(pauseDuration);
        while(currentTime < futureTime)
        {
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;  
            if(currentTime >= futureTime)
            {
                break;
            }
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
    protected void CountDown(int amount)
    {
        for(int i = amount; i > 0; i--)
        {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayLogs()
    {
        //Part of how this program exceeds requirements is by including a log of how many times activities were performed and for how long.
        string pluralCheckUses = "s";
        string pluralCheckTime = "s";
        if(_usesLog == 1)
        {
            pluralCheckUses = "";
        }
        if(_timeLog == 1)
        {
            pluralCheckTime = "";
        }
        Console.WriteLine($"You have done the {_name} {_usesLog} time{pluralCheckUses} for a total of {_timeLog} second{pluralCheckTime}.");
    }
}