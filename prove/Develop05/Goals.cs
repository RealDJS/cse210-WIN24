// Develop05
// Dennis Skoy
// Mar 2024

// Goals Class

public class Goals
{
    // Attributes

    public List<Goal> GoalsList { get; set; }
    public int Score { get; set; }


    // Constructor
    public Goals() { GoalsList = new List<Goal>(); this.Score = 0; }
    public Goals(List<Goal> Goals) { GoalsList = Goals ?? new List<Goal>(); this.Score = 0; CalcScore(); }


    // Methods
    /** AddGoal: adds a goal to the list of Goals*/
    public void AddGoal(Goal goal) { GoalsList.Add(goal); }


    /** RecordGoal: records goal completion*/
    public void RecordGoal(Goal goal) { goal.CompleteGoal(); CalcScore(); }


    /** CalcScore: calculates Score*/
    public void CalcScore()//resets; adds up points
    { Score = 0; foreach (Goal goal in GoalsList) { Score += goal.GetPoints(); } }


    /** ListGoals: lists all Goals*/
    public void ListGoals()
    { foreach (Goal goal in GoalsList) { Console.WriteLine(goal.ToString()); } }
}