// Source Code for Develop04
// Dennis Skoy
// Last edit: Feb 2024

// Timer Class

public class Timer
{
    // Attributes


    Timer()
    {

    }

    // Member Methods
    public void Loading(string message = "") { }


    protected static void MakeTimeframe(int time, Action activity)
    {
        DateTime startTime = DateTime.Now;//Animation Start
        DateTime endTime = startTime.AddSeconds(time);// Animation End
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)// until time equals the activity's time limit
        {
            activity();
        }
    }


    private int ConvertTime(int seconds) { return seconds * 1000; }
}