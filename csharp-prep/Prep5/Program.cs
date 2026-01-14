using System;
using System.Security.Cryptography;

class Program
{
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("What is your birth year? ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squareNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year;
        PromptUserBirthYear(out year);
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber, year);

    }
}