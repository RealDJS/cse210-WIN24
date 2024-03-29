// Foundation3 source code
// Dennis Skoy
// Mar 2024

// Lecture : Event class

class Lecture : Event
{
    private string speaker;// speaker of the lecture
    private int roomCapacity;// max room capacity for guests at event

    // Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int roomCapacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.roomCapacity = roomCapacity;
        this.eventType = "Lecture";
    }

    // Getters
    public string GetSpeaker() { return speaker; }
    public int GetRoomCapacity() { return roomCapacity; }

    // Setters
    public void SetSpeaker(string speaker) { this.speaker = speaker; }
    public void SetRoomCapacity(int roomCapacity) { this.roomCapacity = roomCapacity; }

    // Methods
    /** FullDetails: lists all StandardDetails plus type of event and information specific to the event type */
    public override string FullDetails()
    { return StandardDetails() + "\nSpeaker: " + speaker + "\nRoom Capacity: " + roomCapacity; }
}