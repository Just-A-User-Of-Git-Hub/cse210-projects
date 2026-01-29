using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActiviy reflectingActivity = new ReflectingActiviy();
        ListingActivity listingActivity = new ListingActivity();
        int input = 0;
        while(input != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View Activity logs");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Console.Clear();
                breathingActivity.RunActivity();
            }
            else if(input == 2)
            {
                Console.Clear();
                reflectingActivity.RunActivity();
            }
            else if(input == 3)
            {
                Console.Clear();
                listingActivity.RunActivity();
            }
            else if(input == 4)
            {
                Console.Clear();
                breathingActivity.DisplayLogs();
                Console.WriteLine();
                reflectingActivity.DisplayLogs();
                Console.WriteLine();
                listingActivity.DisplayLogs();
                Console.WriteLine("\nPress enter to go back to menu.");
                Console.ReadLine();
            }
        }
    }
}