// Develop04 Source Code
// Dennis Skoy
// Last edit: Mar 2024

// Activity Class


abstract class Activity
{
    // Attributes
    protected string activityName;
    protected string startingMessage;
    protected string activityDescription;
    protected int activityTime;

    // Constants

    protected readonly int loadingLength = 3;

    // Constructor
    public Activity(string activityName, string startingMessage, string activityDescription)
    { this.activityName = activityName; this.startingMessage = startingMessage; this.activityDescription = activityDescription; }


    // Member Methods
    /** PresentActivity */
    public void PresentActivity()
    {
        StartInstructions();//shows instructions
        RunActivity();//runs activity
        EndActivity();//shows results
    }

    /** RunActivity */
    public abstract void RunActivity();//runs activity


    /** StartInstructions */
    protected void StartInstructions()
    {
        Display("Get Ready..."); LoadingAnimation(3);// Pause
        Console.Clear();
        Display(startingMessage);// activity's starting message
        Display(activityDescription);// activity description
        AskForTime();// sets activityTime
        Console.Clear();
    }


    /** ReportActivity Method*/
    protected void ReportActivity()
    { Console.Write($"You completed {activityTime} seconds of the {activityName} Activity."); Display(""); }


    /** EndActivity Method */
    protected void EndActivity()
    {
        Display("\nWell Done!!!");//confirms end to activity
        LoadingAnimation(loadingLength);
        ReportActivity();
        LoadingAnimation(loadingLength);
    }


    /** Display Method: displays string on new line */
    protected static void Display(string words) { Console.WriteLine($"{words}"); }


    /** AskForTime Method: retreives time from user */
    protected void AskForTime()
    {
        while (true)// loops indefinitely
        {
            Display("How long, in seconds, would you like your session?: ");// asks for time
            string userInput = Console.ReadLine();// reads inputs

            if (int.TryParse(userInput, out int userTime) && userTime > 0)// if user enters a valid integer,
            { this.activityTime = userTime; break; }

            else { Display("Not an option. Try a positive integer"); }// prevents invalid inputs
        }
    }


    
    


    /** LoadingAnimation Method: displays animation in terminal */
    protected static void LoadingAnimation(int animationTime)
    {
        DateTime startTime = DateTime.Now;//Animation Start
        DateTime endTime = startTime.AddSeconds(animationTime);// Animation End

        while (DateTime.Now < endTime)// until time equals the activity's time limit
        {
            Console.Write($"\\");   // 1. Writes a character
            Thread.Sleep(250);      // 2. Pauses for the given miliseconds
            Console.Write("\b \b"); // 3. Deletes previous character
            Console.Write($"|"); Thread.Sleep(250); Console.Write("\b \b");// Repeats steps 1-3
            Console.Write($"/"); Thread.Sleep(250); Console.Write("\b \b");// ""
            Console.Write($"—"); Thread.Sleep(250); Console.Write("\b \b");// ""
        }
    }

    /** SelectText*/
    protected static void SelectText(TextReader text) { Console.Write($"{text.DrawText()} "); }
}