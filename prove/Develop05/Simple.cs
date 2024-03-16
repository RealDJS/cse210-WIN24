// Develop 05
// Dennis Skoy
// Mar 2024

// Simple Class

public class Simple : Goal
{
    // Constructor
    public Simple(string name, string description, int points) : base(name, description, points)
    { this.indication = "[ ]"; }

    // Methods
    public override void CompleteGoal()
    {
        this.isDone = true;
        this.indication = "[X]";
    }

    protected override int CalcPoints() { if (isDone) { return points; } else { return 0; } }
}