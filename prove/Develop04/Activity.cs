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
	protected string prompt;
	protected int activityTime;
	protected string endingMessage;
	protected string timeReport;
	protected readonly int miliseconds = 1000;// Const


	// Constructor
	public Activity()
	{
		activityName = "Base";
		startingMessage = "Hello";
		activityDescription = "This is an activity";
		prompt = "These are your instructions";
		activityTime = 30;
		endingMessage = $"Well done!";
		timeReport = $"You completed {activityTime} seconds of the {activityName} Activity.";
	}

	// Setter
	public void SetActivityTime(int activityTime) { this.activityTime = activityTime; }


	// Member Methods
	/** RunActivityMethod(): runs activity for user */
	public void PresentActivity()
	{
		Console.Clear();
		Display("");
		Display(startingMessage);// activity's starting message
		Display(activityDescription);// activity description
		AskForTime();// sets activityTime
		Console.Clear();
		Display("Get Ready..."); LoadingAnimation(activityTime);// loading
		RunActivity();
		Display(endingMessage);//confirms end to activity
		LoadingAnimation(3);
		Display(timeReport);
		LoadingAnimation(5);
	}


	/** RunActivity */
	protected abstract void RunActivity();


	/** Display Method: displays string on new line */
	protected static void Display(string words) { Console.WriteLine($"{words}"); }


	/** AskForTime Method: retreives time from user */
	protected void AskForTime()
	{
		int loop = -1;
		while (loop < 0)
		{
			Display("How long, in seconds, would you like your session?: ");
			string userInput = Console.ReadLine();
			if (int.TryParse(userInput, out int userTime) && userTime > 0)
			{ SetActivityTime(userTime); loop++; }
		};
	}

	


	/** Countdown Method: counts down from time given by user */
	public virtual void Countdown(int activityTime)
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
	protected static void LoadingAnimation(int animationTime)
	{
		DateTime startTime = DateTime.Now;//Animation Start
		DateTime endTime = startTime.AddSeconds(animationTime);// Animation End
		DateTime currentTime = DateTime.Now;
		while (currentTime < endTime)// until time equals the activity's time limit
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