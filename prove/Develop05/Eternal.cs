// Develop05
// Dennis Skoy
// Mar 2024

// Eternal Quest

class Eternal : Goal
{
    int howManyDone;
    Eternal(string goalName, string description, int points, int howManyDone) : base(goalName, description, points) { }

    public override int GetPoints()
    {
        throw new NotImplementedException();
    }
}