// Foundation3 source code
// Dennis Skoy
// Mar 2024

// OutdoorGathering class

class OutdoorGathering : Event

{
    private string weather;// weather projected for the event

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
        this.eventType = "Outdoor Gathering";
    }

    // Getters
    public string GetWeather() { return weather; }

    // Setters
    public void SetWeather(string weather) { this.weather = weather; }

    // Methods
    /** FullDetails: lists all StandardDetails plus type of event and information specific to the event type */
    public override string FullDetails()
    { return StandardDetails() + "\nWeather: " + weather; }
}