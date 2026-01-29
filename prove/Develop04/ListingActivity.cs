public class ListingActivity : Activity
{
    private List<string> _responses = new List<string>();
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = 
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    private void AddResponse()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _responses.Add(response);
    }
        private string GeneratePrompt()
    {
        int index = _random.Next(0 , _prompts.Count);
        return _prompts[index];
    }
    public void RunActivity()
    {
        _responses.Clear();
        Start();
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n --- {GeneratePrompt()} ---");
        Console.Write("\nYou may being in: ");
        CountDown(5);
        Console.WriteLine();
        Console.WriteLine();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while(currentTime < futureTime)
        {
            AddResponse();
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_responses.Count} items!");

        End();
    }
}