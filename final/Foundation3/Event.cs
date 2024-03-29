// Foundation3 source code
// Dennis Skoy
// Mar 2024

// Event class

abstract class Event
{
    protected string title;// title of the event
    protected string description;// description of the event
    protected string date;// date of the event
    protected string time;// time of the event
    protected Address address;// address of the event
    protected string eventType;// type of event

    // Constructor
    public Event()
    {
        this.title = "title";
        this.description = "description";
        this.date = "date";
        this.time = "time";
        this.address = new Address();
        this.eventType = "event";
    }

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.eventType = "event";
    }

    // Getters
    public string GetTitle() { return title; }
    public string GetDescription() { return description; }
    public string GetDate() { return date; }
    public string GetTime() { return time; }
    public Address GetAddress() { return address; }
    public string GetEventType() { return eventType; }

    // Setters
    public void SetTitle(string title) { this.title = title; }
    public void SetDescription(string description) { this.description = description; }
    public void SetDate(string date) { this.date = date; }
    public void SetTime(string time) { this.time = time; }
    public void SetAddress(Address address) { this.address = address; }

    // Methods
    /**GenerateMessages: calls all marketing messages for the event */
    public void GenerateMessages()
    {
        Console.WriteLine();
        Console.WriteLine(StandardDetails());
        Console.WriteLine();
        Console.WriteLine(FullDetails());
        Console.WriteLine();
        Console.WriteLine(ShortDescription());
        Console.WriteLine();
    }


    /** StandardDetails: lists the title, description, date, time, and address of the event */
    public string StandardDetails()
    { return title + "\n" + description + "\n" + date + " at " + time + "\n" + address.ToString(); }


    /**FullDetails: lists all StandardDetails plus type of event and information specific to the event type */
    public abstract string FullDetails();


    /**ShortDesctiption: returns the event type, title, and date */
    public string ShortDescription()
    { return eventType + ": " + title + " on " + date; }
}