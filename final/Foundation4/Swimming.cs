// Foundation4
// Dennis Skoy
// Apr 2024

// Swimming : Activity Class

class Swimming : Activity
{
    private int laps;// Number of laps swam

    // Constants
    private int METERS_PER_LAP = 50;// Meters per lap
    private int METERS_PER_KM = 1000;// Meters per kilometer
    private double MILES_PER_KM = 0.62;// Miles per kilometer


    // Constructor
    public Swimming(string date, double length, int laps) : base(date, length)
    {
        name = "Swimming";
        this.laps = laps;
    }

    // Getters
    public int GetLaps() { return laps; }

    // Setters
    public void SetLaps(int laps) { this.laps = laps; }


    //Methods
    /**CalcDistance: Returns activity's distance rounded to two decimals*/
    override protected double CalcDistance()
    {
        return Math.Round((laps * METERS_PER_LAP) / (METERS_PER_KM * MILES_PER_KM), 2);// laps * meters per lap / meters per kilometer / miles per kilometer = distance
    }
}