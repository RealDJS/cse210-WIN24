// Develop04 Source Code
// Dennis Skoy
// Last edit: Mar 2024

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
    public override void RunActivity() { BreatheInAndOut(); }// Breathing exercise    


    /** BreatheInAndOut method: */
    private void BreatheInAndOut()
    {
        var startingTime = DateTime.Now;// saves current time
        while ((DateTime.Now - startingTime).TotalSeconds < activityTime)// until (activityTime) seconds pass,
        {
            Console.Write("\nBreathe in..."); Utility.Countdown(4);
            Console.Write("\nNow Breathe out..."); Utility.Countdown(6);
        }
    }
}