// Source Code for Develop04
// Dennis Skoy
// Last edit: Mar 2024

// Utility Class

public static class Utility
{
    // Member Methods
    public static void Display(string words) { Console.WriteLine($"{words}"); }// displays string on new line

    /** Countdown Method: counts down from time given by user */
    public static void Countdown(int activityTime)
    {
        int miliseconds = 1000;
        for (int i = activityTime; i > 0; i--)// for every second left:
        // shows time left; waits for this many miliseconds; removes character
        { Console.Write($"{i}"); Thread.Sleep(miliseconds); Console.Write("\b \b"); }
    }


    /** LoadingAnimation Method: displays animation in terminal */
    public static void LoadingAnimation(int animationTime)
    {
        char[] aniFrames = new[] { '\\', '|', '/', '—' };// animation characters
        DateTime startTime = DateTime.Now;//Animation Start
        DateTime endTime = startTime.AddSeconds(animationTime);// Animation End
        while (DateTime.Now < endTime)// until time equals the activity's time limit
        {
            foreach (var i in aniFrames)// iterates through animation list
            {
                if (DateTime.Now >= endTime) break;// stops when time's up; 
                Console.Write($"{i}"); Thread.Sleep(250); Console.Write("\b \b");// Writes; Pauses; Deletes previous character
            }
        }
    }

    /**Creates Border in terminal*/
    public static void MakeBorder(string _character) { Console.WriteLine(new string(_character[0], Console.WindowWidth - 1)); }

    public static void DefaultOption()// prevents invalid inputs
    { Console.Write("\nNot an option. Read the options and try again "); Utility.LoadingAnimation(3); Console.Clear(); }
}