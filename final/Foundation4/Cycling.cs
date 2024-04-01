// Foundation4
// Dennis Skoy
// Apr 2024

// Cycling : Activity Class

class Cycling : Activity
{
    private double speed;// Speed of the activity in miles per hour

    // Constructor
    public Cycling(string date, double length, double speed) : base(date, length)
    {
        name = "Cycling";
        this.speed = speed;
    }

    // Getters
    public double GetSpeed() { return speed; }

    // Setters
    public void SetSpeed(double speed) { this.speed = speed; }


    //Methods
    /**CalcPace: Returns activity's pace in minutes per mile*/
    protected override double CalcSpeed() { return Math.Round(speed, 2); }
}