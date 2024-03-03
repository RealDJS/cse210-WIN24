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
        Utility.Display("Get Ready..."); Utility.LoadingAnimation(3);// Pause
        Console.Clear();
        Utility.Display(startingMessage);// activity's starting message
        Utility.Display(activityDescription);// activity description
        AskForTime();// sets activityTime
        Console.Clear();
    }


    /** ReportActivity Method*/
    protected void ReportActivity()
    { Console.Write($"You completed {activityTime} seconds of the {activityName} Activity."); Utility.Display(""); }


    /** EndActivity Method */
    protected void EndActivity()
    {
        Utility.Display("\nWell Done!!!");//confirms end to activity
        Utility.LoadingAnimation(loadingLength);
        ReportActivity();
        Utility.LoadingAnimation(loadingLength);
    }


    /** AskForTime Method: retreives time from user */
    protected void AskForTime()
    {
        while (true)// loops indefinitely
        {
            Utility.Display("How long, in seconds, would you like your session?: ");// asks for time
            string userInput = Console.ReadLine();// reads inputs

            if (int.TryParse(userInput, out int userTime) && userTime > 0)// if user enters a valid integer,
            { this.activityTime = userTime; break; }

            else { Utility.Display("Not an option. Try a positive integer"); }// prevents invalid inputs
        }
    }


    /** SelectText*/
    protected static void SelectText(TextReader text) { Console.Write($"{text.DrawText()} "); }
}