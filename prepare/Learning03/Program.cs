using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Random randomGenerator = new Random();
        for (int i = 1; i < 21; i++)
        {
            fraction1.SetTop(randomGenerator.Next(1, 100));
            fraction1.SetBottom(randomGenerator.Next(1, 100));
            Console.WriteLine($"Fraction {i}: string: {fraction1.GetFractionString()} Number: {fraction1.GetDecimalValue()}");
        }
    }

}