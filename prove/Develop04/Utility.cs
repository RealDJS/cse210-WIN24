// Source Code for Develop04
// Dennis Skoy
// Last edit: Mar 2024

// Utility Class

public static class Utility
{

	/** Display Method: displays string on new line */
	public static void Display(string words) { Console.WriteLine($"{words}"); }

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


	/** LoadingAnimation Method: displays animation in terminal */
	public static void LoadingAnimation(int animationTime)
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
}