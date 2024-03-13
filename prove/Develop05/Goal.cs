// Develop05
// Dennis Skoy
// Mar 2024

// Goal Class

public abstract class Goal
{
    // Attributes
    protected string goalName;//name from user
    protected string description;//description from user
    protected int points;//points earned for completing goal
    protected bool isDone = false;//

    // Getter
    public abstract int GetPoints();//returns points

    // Constructor
    public Goal(string name, string description, int points) { this.goalName = name; this.description = description; this.points = points; }

    // Methods
    public virtual void CompleteGoal() { this.isDone = true; }
}