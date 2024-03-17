// Develop 05
// Dennis Skoy
// Mar 2024

// Simple Class

public class Simple : Goal
{
    // Constructor
    public Simple() : base() { }

    public Simple(string name, string description, int points) : base(name, description, points) { }


    // Methods
    public override void CompleteGoal() { this.IsDone = true; }

    public override string GetIndication() { if (IsDone) { return "[X]"; } else { return "[ ]"; } }


    protected override int CalcPoints() { if (IsDone) { return Points; } else { return 0; } }
}