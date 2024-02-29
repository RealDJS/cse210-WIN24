// Develop04 Source Code
// Dennis Skoy
// Last edit: Feb 2024

// BreathingActivity Class

class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base()
    {
        activityName = "Breathing";
        startingMessage = "Welcome to the Breathing Activity";
        activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing";
    }

    // Member Methods

    protected override void RunActivity()
    {
        int timeLimit = activityTime * miliseconds;// converts time to milliseconds
        int time = 0;
        while (timeLimit > time)
        {
            Display("Breathe in..."); Countdown(4);
            Display("Now Breathe out..."); Countdown(6);
            Display("");
        }
    }
}