// Foundation4
// Dennis Skoy
// Apr 2024

// Activities Class

class Activities
{
    private List<Activity> activities;// List of activities

    // Constructor
    public Activities() { activities = new List<Activity>(); }


    //Methods
    /**AddActivity: Adds an activity to the list */
    public void AddActivity(Activity activity) { activities.Add(activity); }


    /**GetSummary: Returns the summaries for all activities */
    public void GetSummaries()
    {
        foreach (Activity activity in activities)// For each activity in activities
        { activity.GetSummary(); }// Get the summary
        Console.WriteLine();
    }
}