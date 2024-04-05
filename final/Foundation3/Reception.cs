// Foundation3 source code
// Dennis Skoy
// Mar 2024

// Reception : Event class

class Reception : Event
{
    private string email;// email to RSVP for event

    // Constructor
    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    { this.email = email; this.eventType = "Reception"; }


    // Getters
    public string GetEmail() { return email; }

    // Setters
    public void SetEmail(string email) { this.email = email; }

    // Methods
    /** FullDetails: lists all StandardDetails plus type of event and information specific to the event type */
    public override string FullDetails() { return StandardDetails() + "\nRSVP to " + email; }
}