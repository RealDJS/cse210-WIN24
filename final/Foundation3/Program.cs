using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address objects
        Address address = new Address("747 Howard St", "San Francisco", "CA", "USA");
        Address address2 = new Address("51 S 2nd W", "Rexburg", "ID", "USA");
        Address address3 = new Address("1356 Broadway", "New York", "NY", "USA");

        // Create Lecture object
        Lecture lecture = new Lecture("Classic Game Postmortem: Deus Ex", "Acclaimed game designer Warren Spector walks through Deus Ex's development and key lessons from launching the game", "03/02/2017", "5:30 PM", address, "Warren Spector", 450);

        // Create OutdoorGathering object
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ward Closing Social", "Let's close off the semester with a BBQ for the whole ward. Main course provided. Bring a side dish", "04/08/2024", "4:00 PM", address2, "Sunny");

        // Create Reception object
        Reception reception = new Reception("A New Hell's Kitchen", "Join Wilson Fisk as he strives to build a better tomorrow for Hell's Kitchen. Food and entertainment will be provided. Valets free of charge", "04/04/2015", "8:00 PM", address3, "kingpin@fisk.com");

        // Displays the StandardDetails, FullDetails, and ShortDescription for each Event object
        lecture.GenerateMessages();// Lecture
        reception.GenerateMessages();// Reception
        outdoorGathering.GenerateMessages();// OutdoorGathering
    }
}