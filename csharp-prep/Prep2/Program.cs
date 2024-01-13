using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int gradeDigit;
        string letter; // letters A-D,F
        string passingClassMessage;
        string sign; // + or - sign


        // Constants
        const int A = 90;
        const int B = 80;
        const int C = 70;
        const int D = 60;
        const int Divisor = 10;
        const int PlusSign = 7;
        const int MinusSign = 3;


        // Greeting Message
        Console.WriteLine("\nHello Prep2 World!");


        // Ask for Grade Percentage
        Console.Write("\nWhat is your grade percentage? ");
        string userGrade = Console.ReadLine();


        // Convert to Integer
        gradeDigit = int.Parse(userGrade);


        // Determine Letter Grade
        if (gradeDigit >= A)
        {
            // 90% or above
            letter = "A";
        }
        else if (gradeDigit >= B)
        {
            // 80% or above
            letter = "B";
        }
        else if (gradeDigit >= C)
        {
            // 70% or above
            letter = "C";

        }
        else if (gradeDigit >= D)
        {
            // 60% or above
            letter = "D";
        }
        else
        {
            // 60% or below
            letter = "F";
        }


        // Calculate Grade Sign
        double gradeRemainder = gradeDigit % Divisor;// finding remainder (second digit) to determine sign

        if (letter == "F")//no signs for F's
        {
            sign = "";
        }
        else if (gradeRemainder >= PlusSign)// Remainders equal to or more than 7 are "+"
        {
            sign = "+";
            if (letter == "A")// no + signs for A's
            {
                sign = "";
            }
        }
        else if (gradeRemainder > MinusSign)// Remainders less than 7 and greater than 3 have no sign
        {
            sign = "";
        }
        else// Remainders equal to or less than 3 are minus
        {
            sign = "-";
        }


        // Determine if they Pass
        if (gradeDigit >= C)
        {
            passingClassMessage = "Congradulations! You passed!";
        }
        else
        {
            passingClassMessage = "We're sorry you didn't pass. Try again!";
        }


        // Display their Results
        Console.Write($"\nFinal Grade: {letter}{sign}");
        Console.Write($"\n{passingClassMessage}");
        Console.Write(" ");
    }
}