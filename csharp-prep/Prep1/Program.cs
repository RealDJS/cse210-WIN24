using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string firstName;
        string lastName;

        // Greeting Message
        Console.Write("Hello Prep1 World!");

        // User's First Name
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();

        // User's Last Name
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        // Print Introduction
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}