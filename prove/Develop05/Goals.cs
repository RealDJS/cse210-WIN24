// Develop05
// Dennis Skoy
// Mar 2024

// Goals Class

class Goals
{
	// Attributes
	private string filename;
	private List<Goal> goals;
	private int score;

	// Constructor
	public Goals(string filename, List<Goal> goals)
	{
		this.filename = filename;
		this.goals = goals;
	}

	// Methods

	public void AddGoal(Goal goal) { goals.Add(goal); }
	
	public void RecordGoal(){}
}