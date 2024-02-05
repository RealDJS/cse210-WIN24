using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1
        Fraction _fraction1 = new Fraction();
        Console.WriteLine(_fraction1.GetFractionString());
        Console.WriteLine(_fraction1.GetDecimalValue());

        // Example 2
        Fraction _fraction2 = new Fraction(5);
        Console.WriteLine(_fraction2.GetFractionString());
        Console.WriteLine(_fraction2.GetDecimalValue());

        // Example 3
        Fraction _fraction3 = new Fraction(6, 7);
        Console.WriteLine(_fraction3.GetFractionString());
        Console.WriteLine(_fraction3.GetDecimalValue());
    }
}