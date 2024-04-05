// Foundation4
// Dennis Skoy
// Apr 2024

// Running : Activity Class

class Running : Activity
{
    private double distance;// Distance of the activity in miles

    // Constructor
    public Running(string date, double length, double distance) : base(date, length)
    {
        name = "Running";
        this.distance = distance;
    }

    // Getters
    public double GetDistance() { return distance; }

    // Setters
    public void SetDistance(double distance) { this.distance = distance; }


    //Methods
    /**CalcDistance: Returns activity's distance */
    override protected double CalcDistance() { return Math.Round(distance, DECIMAL_POINTS); }// Running distance is already in miles
}