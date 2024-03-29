// Develop05
// Dennis Skoy
// Mar 2024

// Eternal Quest

public class Eternal : Goal
{
    // Attributes
    int howManyDone = 0;// how many times it's been completed

    // Constructor
    public Eternal() : base() { }

    public Eternal(string goalName, string description, int points) : base(goalName, description, points)
    { }

    public override void CompleteGoal() { howManyDone++; }//adds one each time done

    public override string GetIndication() { return $"[{howManyDone}]"; }

    protected override int CalcPoints()
    { return howManyDone * Points; }
}
