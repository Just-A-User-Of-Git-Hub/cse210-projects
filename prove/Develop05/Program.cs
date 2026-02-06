using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Part of how this program exceeds requirements is by having a list of goal ideas that can be randomly picked from and displayed.
        // Note: These goal ideas are geared towards youth.
        List<string> spiritualGoals = 
        [
            "Read the Book of Mormon each day and write your thoughts and feelings in a scripture journal",
            "Study recent General Conference talks about a topic you feel you need to improve in",
            "Daily seek and record personal revelation in a personal revelation journal",
            "Pray for a missionary experience and then look for opportunities to share the gospel",
            "Do baptisms for the dead each week / month",
            "Lead your families FHE or Come, Follow Me for a month and encourage your family to be involved",
            "Keep a gratitude journal - record 5 things you are grateful for each day and practice showing gratitude to Heavenly Father",
            "Choose a specific gospel topic and study it in depth",
            "Learn more about the purpose of the Sacrament and set a plan to more fully appreciate the Sacrament and the Sabbath",
            "Review each section of the For Strength of Youth booklet. For each topic, find a way you can improve and then implement it in your life",
            "Attend and be involved in Seminary with a happy attitude",
            "Choose a favorite apostle that inspires you. Learn about his life and service. Then, read all of his General Conference talks from the beginning until now. Keep a journal to record your insights and favorite quotes"
        ];

        List<string> intellectualGoals =
        [
            "Think of something that interests you and take a class or learn about it. Some ideas of things you can learn are:\nPainting\nPhotography\nA new language\nCooking\nGraphic design\nSewing\nCake decorating\nCamping\nDrama / Acting\nFirst aid skills\nDance\nA musical instrument\nComputer programming",
            "Write a book or story",
            "Learn about and visit / tour different colleges that interest you",
            "Create a vision board with your goals and dreams for the future",
            "Learn about different careers that interest you. Contact people who work in these areas and learn about job requirements, schooling, etc. Choose a couple of different jobs and then find someone to job shadow and experience the career firsthand",
            "Choose your most difficult class at school and create a plan to do better at it",
            "Read a book or study about a subject that challenges you"
        ];

        List<string> physicalGoals =
        [
            "Set a bedtime and stick to it",
            "Study the Word of Wisdom. Pray about how you can better follow it and set a plan to act on what you feel you should do",
            "Learn how to budget and set up a savings plan",
            "Plan, shop for, and cook meals for your family for a week",
            "Learn about healthy foods and how to cook them",
            "Learn a new sport or physical activity (basketball, tennis, dance, running, etc.)",
            "Train for and run a 5k or other race",
            "Help your family develop an emergency and evacuation plan. Practice it and be sure everyone understands what to do in an emergency",
            "Eat 5 fruits and vegetables a day, or increase your water intake",
            "Plant and harvest a garden",
            "Get outside and be active for ___ hours each day",
            "Learn self defense",
            "Plan a hike for your family or youth group",
            "Learn how to and help do repairs around your home"
        ];

        List<string> socialGoals =
        [
            "Limit social media to ___ minutes each day.",
            "Find someone new to eat lunch with",
            "Do a random act of kindness for someone each day for a month",
            "Introduce yourself / meet someone new in each of your classes",
            "Choose a family member that you feel you need to strengthen your relationshipw. Prayerfully ponder ways to strengthen the relationship and then act on what you feel you should do",
            "Smile at everyone you meet!",
            "Interview an elderly family member about their life growing up. Write up the information that you learn and add it to Family Search.",
            "Plan and carry out a service project for someone in your community",
            "Make cookies or a treat to take to a friend, widow, or someone who needs a pick-me up",
            "Set up a game night or other wholesome fun event for your friends",
            "Create a family history slideshow of your ancestors to share with your family. Learn something about each of them as you do",
            "Index ____ # of names",
            "Find an organization in your community that blesses lives and volunteer with them"
        ];
        int userPoints = 0;
        List<Goal> goals = new List<Goal>();

        int input = 0;
        while(input != 7)
        {
            Console.WriteLine($"\nYou have {userPoints} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. View Goal ideas");
            Console.WriteLine("  7. Quit ");
            Console.Write("Select a choice from the menu: ");
            
            input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("  4. Large Goal");
                Console.Write("Which type of goal would you liket to create? ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if(type == 1)
                {
                    goals.Add(new SimpleGoal(name, description, points, false));
                }
                else if(type == 2)
                {
                    goals.Add(new EternalGoal(name, description, points));
                }
                else if(type == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int completionsNeeded = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, description, points, completionsNeeded, 0, bonusPoints));
                }
                else if(type == 4)
                {
                    Console.Write("What is the amount of points for working on this goal? ");
                    int workingPoints = int.Parse(Console.ReadLine());
                    goals.Add(new LargeGoal(name, description, workingPoints, false, points));
                }
            }
            else if(input == 2)
            {
                Console.WriteLine("The goals are:");
                for(int i = 0; i < goals.Count; i++)
                {
                    Goal goal = goals[i];

                    string completion = " ";
                    if (goal.IsComplete())
                    {
                        completion = "x";
                    }

                    Console.WriteLine($"{i + 1}. [{completion}] {goal.GetDetails()}");
                }
            }
            else if(input == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                outputFile.WriteLine(userPoints);
                }
                foreach(Goal goal in goals)
                {
                    goal.Save(filename);
                }
            }
            else if(input == 4)
            {
                goals.Clear();

                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                userPoints = int.Parse(lines[0]);

                for(int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split("~|~");

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if(type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        goals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                    else if(type == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(name, description, points));
                    }
                    else if(type == "ChecklistGoal")
                    {
                        int completions = int.Parse(parts[4]);
                        int completionsNeeded = int.Parse(parts[5]);
                        int bonusPoints= int.Parse(parts[6]);
                        goals.Add(new ChecklistGoal(name, description, points, completionsNeeded, completions, bonusPoints));
                    }
                    else if(type == "LargeGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        int finalPoints = int.Parse(parts[5]);
                        goals.Add(new LargeGoal(name, description, points, isComplete, finalPoints));
                    }
                }
            }
            else if(input == 5)
            {
                if(goals.Count != 0)
                {
                    Console.WriteLine("The goals are:");
                    for(int i = 0; i < goals.Count; i++)
                    {
                        Goal goal = goals[i];
                        Console.WriteLine($"{i + 1}. {goal.GetName()}");

                    }
                    Console.Write("Which goal did you accomplish? ");
                    int recordInput = int.Parse(Console.ReadLine());

                    int pointsGained = goals[recordInput - 1].RecordEvent();
                    Console.WriteLine($"Congratulations! You have earned {pointsGained} points!");
                    userPoints += pointsGained;
                    Console.WriteLine($"You now have {userPoints} points.");
                }
                else
                {
                    Console.WriteLine("You do not have any goals. ");
                }
            }
            else if(input == 6)
            {
                Console.WriteLine("The catergories are: ");
                Console.WriteLine("  1. Spiritual");
                Console.WriteLine("  2. Intellectual");
                Console.WriteLine("  3. Physical");
                Console.WriteLine("  4. Social");
                Console.WriteLine("  5. All catergories");
                Console.WriteLine("What catergory would you like? ");
                
                List<string> goalIdeas = new List<string>();
                int catergoryInput = int.Parse(Console.ReadLine());
                if(catergoryInput == 1)
                {
                    goalIdeas = spiritualGoals;
                }
                else if(catergoryInput == 2)
                {
                    goalIdeas = intellectualGoals;
                }
                else if(catergoryInput == 3)
                {
                    goalIdeas = physicalGoals;
                }
                else if(catergoryInput == 4)
                {
                    goalIdeas = socialGoals;
                }
                else if(catergoryInput == 5)
                {
                    goalIdeas = spiritualGoals;
                    goalIdeas.AddRange(intellectualGoals);
                    goalIdeas.AddRange(physicalGoals);
                    goalIdeas.AddRange(socialGoals);
                }

                Random random = new Random();
                int continueInput = 0;
                while(continueInput != 2)
                {
                    Console.WriteLine("\nGoal idea:");
                    int index = random.Next(0, goalIdeas.Count);
                    Console.WriteLine(goalIdeas[index]);
                    Console.WriteLine("\nYour options are:");
                    Console.WriteLine("  1. Get another goal idea");
                    Console.WriteLine("  2. Return to menu");
                    Console.WriteLine("What would you like to do? ");
                    continueInput = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}