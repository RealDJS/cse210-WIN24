using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Main Function
    static void Main(string[] args)
    {
        // Greeting Message
        Console.WriteLine("Hello Prep5 World!");

        DisplayMessage();// Welcomes User
        string userName = PromptUserName();// Asks for name
        int userNumber = PromptUserNumber();// Asks for number
        int squaredNumber = SquareNumber(userNumber);// squares the number
        DisplayResult(userName, squaredNumber);// Displays the user's name and the squared number
    }

    // Functions

    //// DisplayWelcome
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    //// PromptUserName
    static string PromptUserName()
    {
        Console.Write("\nPlease enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    //// PromptUserNumber
    static int PromptUserNumber()
    {
        Console.Write("\nPlease enter your favorite number: ");
        string userNumber = Console.ReadLine();
        return int.Parse(userNumber);
    }


    //// SquareNumber
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }


    //// DisplayResult
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"\n{name}, the square of your number is {squaredNumber}");
    }
}