using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");// Greeting Message

        // Create List
        List<int> numbers = new List<int>();

        // Variables
        int userInput = -1;

        // Numbered List
        while (userInput != 0)
        {
            // User List
            Console.Write("Enter a number: ");

            string input = Console.ReadLine();// stores input to variable

            userInput = int.Parse(input);// converts string to int

            // End List
            if (userInput != 0)// prevents adding 0 to the list
            {
                numbers.Add(userInput);// integers are added to list
            }
        };


        // Compute Sum
        int sum = 0;
        foreach (int i in numbers)// prints each number
        {
            sum += i;
        }

        // Compute Average
        int items = numbers.Count;
        float average = ((float)sum) / items;// average is the total divided by the number of items

        // Biggest Number
        int biggestNumber = numbers[0];

        // Iterates through List
        foreach (int i in numbers)
        {
            if (i > biggestNumber)
            {
                biggestNumber = i;// changes to larger number
            }
        }

        // Print Results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
    }
}