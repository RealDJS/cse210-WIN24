// Foundation4
// Dennis Skoy
// Apr 2024

// Activity Class

abstract class Activity
{
    protected string name;// Activity's name
    protected string date;// Date of the activity in DD MMM YYYY format
    protected double length;// Length of the activity in minutes

    // Constants
    protected double MINUTES_PER_HOUR = 60;

    // Constructor
    public Activity(string date, double length)
    {
        name = "Activity";
        this.date = date;
        this.length = length;
    }

    // Getters
    public string GetDate() { return date; }
    public double GetLength() { return length; }

    // Setters
    public void SetDate(string date) { this.date = date; }
    public void SetLength(double length) { this.length = length; }


    //Methods
    /**GetSummary: Displays the date, length, distance, speed, and pace of the activity */
    public void GetSummary()
    {
        Console.WriteLine($"\n{date} {name} ({length} min)- Distance: {CalcDistance()} miles, Speed: {CalcSpeed()} mph, Pace: {CalcPace()} min per mile");
    }


    /**CalcDistance: Returns activity's distance in miles and rounded to two decimals */
    virtual protected double CalcDistance()
    {
        return Math.Round(CalcSpeed() * (length / MINUTES_PER_HOUR), 2);// speed / time = distance
    }


    /**CalcSpeed: Returns activity's speed in miles per hour and rounded to two decimals*/
    virtual protected double CalcSpeed()
    {
        return Math.Round(CalcDistance() / (length / MINUTES_PER_HOUR), 2);// distance / time = speed
    }


    /**CalcPace: Returns activity's pace in minutes per mile and rounded to two decimals*/
    virtual protected double CalcPace()
    {
        return Math.Round(length / CalcDistance(), 2);// time / distance = pace
    }
}