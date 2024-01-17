using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    // Main Function
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");// Greeting Message

        // Create List
        List<int> numbers = CreateList();

        // Compute Sum
        int sum = ComputeSum(numbers);

        // Compute Average
        float average = ComputeAverage(sum, numbers);

        // Find Biggest Number
        int biggestNumber = FindBiggestNumber(numbers);

        // Print Results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
    }


    // Program Class Functions

    //// CreateList Function
    static List<int> CreateList()
    {
        // Blank List
        List<int> numbers = new List<int>();

        // Variables
        int userInput = -1;

        // Numbered List
        while (userInput != 0)
        {
            // User prompt
            Console.Write("Enter a number: ");

            string input = Console.ReadLine();// stores input to variable

            userInput = int.Parse(input);// converts string to int

            // End List
            if (userInput != 0)// prevents adding 0 to the list
            {
                numbers.Add(userInput);// integers are added to list
            }
        }
        return numbers;
    }


    //// ComputeSum Function
    static int ComputeSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int i in numbers)// for every item in the list
        {
            sum += i;// adds item to the total sum
        }
        return sum;// returns list
    }


    //// ComputeAverage Function
    static float ComputeAverage(int sum, List<int> numbers)
    {
        // Compute Average
        int items = numbers.Count;// counts items in List
        float average = ((float)sum) / items;// average is the total divided by the number of items
        return average;// returns average
    }


    //// FindBiggestNumber Function
    static int FindBiggestNumber(List<int> numbers)
    {
        // Default Biggest Number
        int biggestNumber = numbers[0];// first item in list

        // Iterates through List
        foreach (int i in numbers)
        {
            if (i > biggestNumber)// if the next item is larger
            {
                biggestNumber = i;// changes to larger number
            }
        }
        return biggestNumber;
    }
}