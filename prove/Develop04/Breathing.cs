// Develop04 Source Code
// Dennis Skoy
// Last edit: Feb 2024

// BreathingActivity Class

class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base(
        "Breathing",
        "Welcome to the Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing")
    { }


    // Member Methods
    public override void RunActivity()
    {
        Console.Clear();
        Display("Get Ready..."); LoadingAnimation(3);// Pause
        StartInstructions();// Shows instructions

        var startingTime = DateTime.Now;// saves current time

        while ((DateTime.Now - startingTime).TotalSeconds < activityTime)// until (activityTime) seconds pass,
        {
            Console.Write("\nBreathe in..."); Countdown(4);
            Console.Write("\nNow Breathe out..."); Countdown(6);
        }
        EndActivity();// shows Results
    }
}