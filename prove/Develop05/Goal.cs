// Develop05
// Dennis Skoy
// Mar 2024

// Goal Class

public abstract class Goal
{
    // Attributes
    public string GoalName { get; set; }//name from user
    public string Description { get; set; } //description from user
    public int Points { get; set; }//points from user
    public bool IsDone { get; set; }
    // public string Indication { get; set; }//indication of completion

    //Getters	
    public string GetName() { return GoalName; }//returns name

    // Constructor
    public Goal() { this.GoalName = "Goal"; this.Description = "Description"; this.Points = 0; IsDone = false; }


    public Goal(string name, string description, int points) { this.GoalName = name; this.Description = description; this.Points = points; }


    // Getter
    public int GetPoints() { return CalcPoints(); }//returns points
    public abstract string GetIndication();


    // Methods
    public abstract void CompleteGoal();//completes goal

    protected abstract int CalcPoints();//calculates points

    public override string ToString() { return $"{GetIndication()} {GoalName} - ({Description})"; }//returns name and description

}