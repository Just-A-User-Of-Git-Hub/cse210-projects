public class ReflectingActiviy : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();

    public ReflectingActiviy() : base("Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = 
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];
        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    private string GeneratePrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    private string GenerateQuestion()
    {
        //Part of how this program exceeds requirements is by making sure all of the questions have been used once before cycling back through.
        bool worked = false;
        string question = "";
        while (!worked)
        {
            int index = _random.Next(0, _questions.Count);
            question = _questions[index];
            if (_usedQuestions.Count == _questions.Count)
            {
                _usedQuestions.Clear();
            }
            if (!_usedQuestions.Contains(question))
            {
                worked = true;
            }
        }
        _usedQuestions.Add(question);
        return question;
    }
    public void RunActivity()
    {
        _usedQuestions.Clear();
        Start();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n --- {GeneratePrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);

        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while(currentTime < futureTime)
        {
            string question = GenerateQuestion();
            Console.Write($"> {question}");
            Pause(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        End();

    }


    
}