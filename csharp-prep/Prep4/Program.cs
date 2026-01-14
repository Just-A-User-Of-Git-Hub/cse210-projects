using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int largest = 0;
        int sum = 0;
        foreach(int i in numbers)
        {
            sum += i;   
            if(i > largest)
            {
                largest = i;
            }
        }
        
        float average = 0;
        if(numbers.Count > 0)
        {
            average = (float)sum / numbers.Count;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}