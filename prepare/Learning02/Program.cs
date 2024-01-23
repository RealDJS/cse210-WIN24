// Source code for Learning 02 assignment
// This program creates a List of a person's past job experiences
using System;

class Program
{

    static void Main(string[] args)
    {
        // Create Resume Object
        Resume myResume = new Resume("GabeN");


        // Create Job Objects
        Job _job1 = new Job("Microsoft", "Software Engineer", 2019, 2023);
        Job _job2 = new Job("Milosoft", "Engineer", 2011, 2012);
        Job _job3 = new Job("Backyard Balistics", "Pyrotechnic", 2000, 2003);


        // Add Jobs to List
        myResume._jobs.Add(_job1);
        myResume._jobs.Add(_job2);
        myResume._jobs.Add(_job3);


        // Presents the Job List
        myResume.Display();
        Console.WriteLine();
    }
}