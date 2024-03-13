// Develop 05
// Dennis Skoy
// Mar 2024

// Simple Class

public class Simple : Goal
{
    // Constructor
    Simple(string name, string description, int points) : base(name, description, points) { }

    // Methods

    public override void CompleteGoal()
    { this.isDone = true; }

    protected override int CalcPoints() { if (isDone) { return points; } else { return 0; } }
}