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
	protected override void RunActivity()
	{
		StartInstructions();

		var startingTime = DateTime.Now;

		while ((DateTime.Now - startingTime).TotalSeconds < activityTime)
		{
			Console.Write("Breathe in..."); Countdown(4);
			Display("");
			Console.Write("Now Breathe out..."); Countdown(6);
			Display("");
		}

		EndActivity();
	}
}