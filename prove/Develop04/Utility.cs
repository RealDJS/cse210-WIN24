// Source Code for Develop04
// Dennis Skoy
// Last edit: Mar 2024

// Utility Class

public static class Utility
{

    /** Countdown Method: counts down from time given by user */
    public static void Countdown(int activityTime)
    {
        int miliseconds = 1000;
        for (int i = activityTime; i > 0; i--)// for every second left
        {
            Console.Write($"{i}");      // shows time left
            Thread.Sleep(miliseconds);  // waits for this many miliseconds                                      
            Console.Write("\b \b");     // removes character
        }
    }
}