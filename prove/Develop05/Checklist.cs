// Develop05
// Dennis Skoy
// Mar 2024

// Checklist Class

class Checklist : Goal
{
	// Attributes
	private int howManyDone;
	private int howManyNeeded;
	private int bonusPoints;


	//Constructor
	public Checklist(string name, string description, int points, int howManyNeeded, int bonusPoints) : base(name, description, points)
	{ this.howManyDone = 0; this.howManyNeeded = howManyNeeded; this.bonusPoints = bonusPoints; }


	// Methods
	/** CompleteGoal: adds to total if they haven't met the target number*/
	public override void CompleteGoal() { if (howManyDone < howManyNeeded) { howManyDone++; } }


	protected override int CalcPoints()
	{
		int totalPoints = howManyDone * points;//
		
		if (isDone) { totalPoints += bonusPoints; }//adds bonus points if finished
		
		return totalPoints;
	}
}