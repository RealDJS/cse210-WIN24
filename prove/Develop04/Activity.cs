// Develop04 Source Code
// Dennis Skoy
// Last edit: Feb 2024

// Activity Class

public class Activity
{
    // Attributes
    private string startingMessage;
    private string activityDescription;
    private string prompt;
    private int activityTime;
    private string endingMessage;
    readonly int miliseconds = 1000;// Const


    // Constructor
    public Activity()
    {
        startingMessage = "Hello";
        activityDescription = "This is an activity";
        prompt = "These are your instructions";
        endingMessage = "Good job.";
    }

    // Setter
    public void SetActivityTime(int activityTime) { this.activityTime = activityTime; }

    // Member Methods
    /** RunActivityMethod(): runs activity for user */
    public void RunActivity()
    {
        Console.Clear();
        Display("");
        DisplayStartingMessage();
        DisplayActivityDescription();
        AskForTime();
        Console.Clear();
        LoadingAnimation(activityTime);
        DisplayPrompt();
        DisplayEndingMessage();
    }

    /** Display Method: displays string on new line */
    private static void Display(string words) { Console.WriteLine($"{words}"); }


    /** Greeting Message */
    private void DisplayStartingMessage() { Display(startingMessage); }// activity's starting message


    /** DisplayActivityDescription Method: Explains Activity */
    private void DisplayActivityDescription() { Console.WriteLine(activityDescription); }

    /** AskForTime Method: retreives time from user */
    private void AskForTime()
    {
        int loop = -1;
        while (loop < 0)
        {
            Display("How long will you do this activity?: ");
            string userInput = Console.ReadLine();
            int userTime;
            if (int.TryParse(userInput, out userTime) && userTime > 0)
            {
                SetActivityTime(userTime);
                loop++;
            }
        };
    }


    /** DisplayPrompt Method: Provides instructions */
    private void DisplayPrompt() { Display(prompt); }


    /** DisplayEndingMessage Method: confirms end to activity */
    private void DisplayEndingMessage() { Display($"{endingMessage}. \nThis activity took {activityTime} seconds."); }


    /** Countdown Method: counts down from time given by user */
    public virtual void Countdown()
    {
        int timeLeft = activityTime / miliseconds;// convert to milliseconds
        while (timeLeft > 0)// while there's time left
        {
            Console.Clear(); Console.WriteLine($"{timeLeft} seconds left");// shows time left
            Thread.Sleep(miliseconds);// waits for this many miliseconds
            timeLeft--;// lowers timeLeft by 1
        }
    }


    /** LoadingAnimation Method: displays animation in terminal */
    private void LoadingAnimation(int animationTime)
    {
        int time = 0;
        int convertedTime = animationTime * miliseconds;
        while (time < convertedTime)// until time equals the activity's time limit
        {
            Console.Write($"\\");// writes a character
            Thread.Sleep(250);// pauses for the given miliseconds
            Console.Write("\b \b");// deletes previous character
            Console.Write($"|");// writes new character
            Thread.Sleep(250); Console.Write("\b \b"); Console.Write($"/");
            Thread.Sleep(250); Console.Write("\b \b"); Console.Write($"—");
            Thread.Sleep(250); Console.Write("\b \b");
            time += 1000;// adds to time
        }
    }
}