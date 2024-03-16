// Develop05
// Dennis Skoy
// Mar 2024

// Goals Class

public class Goals
{
	// Attributes

	private List<Goal> goals = new List<Goal>();
	private int score;


	// Constructor
	public Goals(List<Goal> goals) { this.goals = goals; this.score = 0; }


	// Getters
	public List<Goal> GetGoals() { return goals; }
	public int GetScore() { return score; }


	// Setters
	public void SetGoals(List<Goal> goals) { this.goals = goals; }
	public void SetScore(int score) { this.score = score; }


	// Methods
	/** AddGoal: adds a goal to the list of goals*/
	public void AddGoal(Goal goal) { goals.Add(goal); }
	
	/** LoadGoals: loads goals from a file*/
	public void LoadGoals(string filename)
	{
		Serializer serializer = new Serializer(filename);
		Goals loadedGoals = serializer.Deserialize();
		this.goals = loadedGoals.GetGoals();
		this.score = loadedGoals.GetScore();
	}


	/** RecordGoal: records goal completion*/
	public void RecordGoal(Goal goal) { goal.CompleteGoal(); }


	/** CalcScore: calculates score*/
	public void CalcScore()//resets; adds up points
	{ score = 0; foreach (Goal goal in goals) { score += goal.GetPoints(); } }


	/** ListGoals: lists all goals*/
	public void ListGoals()
	{ foreach (Goal goal in goals) { Console.WriteLine(goal.ToString()); } }
}