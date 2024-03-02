// Develop04 Source Code
// Dennis Skoy
// Last edit: Feb 2024

// Activity Class


abstract class Activity
{
	// Attributes
	protected string activityName;
	protected string startingMessage;
	protected string activityDescription;
	protected int activityTime;
	protected string endingMessage;
	protected readonly int miliseconds = 1000;// Const


	// Constructor
	public Activity(string activityName, string startingMessage, string activityDescription)
	{
		this.activityName = activityName;
		this.startingMessage = startingMessage;
		this.activityDescription = activityDescription;
		this.activityTime = 0;
		endingMessage = $"Well done!";
	}


	// Member Methods
	/** RunActivityMethod(): runs activity for user */
	public void PresentActivity()
	{
		Console.Clear();
		Display("Get Ready..."); LoadingAnimation(3);// loading
		RunActivity();
	}


	/** RunActivity */
	protected abstract void RunActivity();


	/** StartInstructions */
	protected void StartInstructions()
	{
		Console.Clear();
		Display("");
		Display(startingMessage);// activity's starting message
		Display(activityDescription);// activity description
		AskForTime();// sets activityTime
		Console.Clear();
	}

	/** EndActivity Method */
	protected void EndActivity()
	{
		Display("");
		Display(endingMessage);//confirms end to activity
		Display("");
		LoadingAnimation(3);
		ReportActivity();
		LoadingAnimation(3);
	}


	/** Display Method: displays string on new line */
	protected static void Display(string words) { Console.WriteLine($"{words}"); }


	/** AskForTime Method: retreives time from user */
	protected void AskForTime()
	{
		while (true)// loops indefinitely
		{
			Display("How long, in seconds, would you like your session?: ");
			string userInput = Console.ReadLine();

			if (int.TryParse(userInput, out int userTime) && userTime > 0)
			{ this.activityTime = userTime; break; }

			else { Display("Not an option. Try a positive integer"); }
		}
	}


	protected void ReportActivity()
	{ Console.Write($"You completed {activityTime} seconds of the {activityName} Activity."); }


	/** Countdown Method: counts down from time given by user */
	protected void Countdown(int activityTime)
	{
		for (int i = activityTime; i > 0; i--)
		{
			Console.Write($"{i}");// shows time left
			Thread.Sleep(miliseconds);// waits for this many miliseconds                                      
			Console.Write("\b \b");
		}
	}


	/** LoadingAnimation Method: displays animation in terminal */
	protected static void LoadingAnimation(int animationTime)
	{
		DateTime startTime = DateTime.Now;//Animation Start
		DateTime endTime = startTime.AddSeconds(animationTime);// Animation End

		while (DateTime.Now < endTime)// until time equals the activity's time limit
		{
			Console.Write($"\\");// writes a character
			Thread.Sleep(250);// pauses for the given miliseconds
			Console.Write("\b \b");// deletes previous character
			Console.Write($"|");// writes new character
			Thread.Sleep(250); Console.Write("\b \b"); Console.Write($"/");
			Thread.Sleep(250); Console.Write("\b \b"); Console.Write($"—");
			Thread.Sleep(250); Console.Write("\b \b");
		}
	}
}