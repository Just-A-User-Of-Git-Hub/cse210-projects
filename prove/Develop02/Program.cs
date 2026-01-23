using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        Journal journal = new Journal();
        journal._listOfPrompts = [
            "Who was the most interesting perosn I interacted with today?",
            "What was the best part of my day",
            "How did I see the hand of the Lord in my life today",
            "What was the strongest emotion I felt today",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I improved on today?",
            "What was the most out-of-the-ordinary thing that happened today?",
            "When did I feel the Spirit the most strongly today?",
            "What is one good habit or routine I continued today?"
        ];
        int input = 0;
        while(input != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                // Part of how this program exceeds requirements is including location in the entries.
                Console.WriteLine("Would you like to include your location in the entry? y/n");
                string inputLocation = Console.ReadLine();
                string location = "";
                if(inputLocation == "y")
                {
                    Console.WriteLine("Where are you?");
                    location = Console.ReadLine();
                }
                
                // Another part of how this program exceeds requirements is including not only the date but also the time of day.
                string time = $"{date.ToShortDateString()} {date.ToShortTimeString()}";
                string prompt = journal.GeneratePrompt();
                string text = Console.ReadLine();

                journal.AddEntry(time, prompt, text, location);

            }
            else if(input == 2)
            {
                journal.DisplayEntries();
            }
            else if(input == 3)
            {
                Console.WriteLine("What file would you like to load entries from?");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
            }
            else if(input == 4)
            {
                Console.WriteLine("What file would you like to save entries to?");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
            }
        }
    }
}
        

    
