using System;

class Program
{
    static void Main(string[] args)
    {
        Activities activities = new Activities();// creates activities list
        activities.AddActivity(new Running("01 Jan 2024", 25, 3));// adds running activity
        activities.AddActivity(new Cycling("02 Jan 2024", 20, 15));// adds cycling activity
        activities.AddActivity(new Swimming("03 Jan 2024", 40, 28));// adds swimming activity
        activities.GetSummaries();//prints summaries
    }
}