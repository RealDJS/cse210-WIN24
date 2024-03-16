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
    protected bool isDone = false;//if goal is done
    protected string indication;//indicates how much of goal is done

    //Getters	
    public string GetName() { return goalName; }//returns name

    // Constructor
    public Goal(string name, string description, int points) { this.goalName = name; this.description = description; this.points = points; }


    // Getter
    public int GetPoints() { return CalcPoints(); }//returns points
    public string GetIndication() { return indication; }//returns indication


    // Methods
    public abstract void CompleteGoal();//completes goal

    protected abstract int CalcPoints();//calculates points

    public override string ToString() { return $"{indication} {goalName} - ({description})"; }//returns name and description

}