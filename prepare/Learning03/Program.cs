using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        Fraction fraction5 = new Fraction();
        Random randomGenerator = new Random();
        for (int i = 1; i < 21; i++)
        {
            fraction5.SetTop(randomGenerator.Next(1, 100));
            fraction5.SetBottom(randomGenerator.Next(1, 100));
            Console.WriteLine($"Fraction {i}: string: {fraction1.GetFractionString()} Number: {fraction1.GetDecimalValue()}");
        }
    }

}