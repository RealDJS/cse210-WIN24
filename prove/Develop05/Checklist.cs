// Develop05
// Dennis Skoy
// Mar 2024

// Checklist Class

public class Checklist : Goal
{
    // Attributes
    public int HowManyDone { get; set; }// how many times it's been completed
    public int HowManyNeeded { get; set; }// how many times it needs to be completed
    public int BonusPoints { get; set; }// bonus points if completed


    //Constructor
    public Checklist() : base() { HowManyDone = 0; HowManyNeeded = 0; BonusPoints = 0; }

    public Checklist(string name, string description, int points, int HowManyNeeded, int BonusPoints) : base(name, description, points)
    {
        HowManyDone = 0;
        this.HowManyNeeded = HowManyNeeded;
        this.BonusPoints = BonusPoints;
    }


    // Methods
    /** CompleteGoal: adds to total if they haven't met the target number*/
    public override void CompleteGoal()
    {
        if (HowManyDone < HowManyNeeded) { HowManyDone++; }
        else { Console.WriteLine("This goal is already complete."); }
    }

    /** GetIndication: returns indication of completion*/
    public override string GetIndication()
    { if (IsDone) { return "[X]"; } else { return $"[{HowManyDone}/{HowManyNeeded}]"; } }

    /** CalcPoints: calculates points*/
    protected override int CalcPoints()
    {
        if (HowManyDone == HowManyNeeded) { IsDone = true; }//if done, sets to true
        int totalPoints = HowManyDone * Points;
        if (IsDone) { totalPoints += BonusPoints; }//adds bonus points if finished
        return totalPoints;
    }
}