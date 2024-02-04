// Source code for Journal Class
// This stores JournalEntries and their filenames in a list
// Author: Dennis Skoy
// last edit: February 2024


class Journal
{
    // Attributes
    private string _filename;// the Journal's filename given by the user
    private List<JournalEntry> _entries = new List<JournalEntry>();// a list storing JournalEntry objects


    // Constructors
    // // Default
    public Journal() { this._filename = ""; this._entries = []; }

    // // Paramaterized Constructor
    public Journal(string filename, List<JournalEntry> _entries)
    { this._filename = filename; this._entries = _entries; }


    // Member Methods
    // // Write Method
    public void Write()// Saves a new Entry to the _entries List
    {
        // Randomly Choose Prompt
        string _userPrompt = JournalPrompts.DrawPrompt();

        // Display Prompt
        Console.Write($"{_userPrompt} ");

        // User input
        string _userResponse = Console.ReadLine();

        // Entry Date
        DateTime _date = DateTime.Now;
        string _dateString = _date.ToShortDateString();

        // Saves the date, prompt, and response as an Entry
        _entries.Add(new JournalEntry(_dateString, _userPrompt, _userResponse));
    }


    // // DisplayJournal Method
    public void DisplayJournal()
    {
        foreach (JournalEntry _page in _entries)// For every journal Entry
        { _page.Display(); }// print the contents using the JournalEntry.Display method
    }


    // // SaveJournal Method
    public void SaveJournal()// saves Journal to CSV file
    {
        using (StreamWriter _outputFile = new StreamWriter(FetchFileName()))//reads filename provided by user
        {
            foreach (JournalEntry _entry in _entries)// for every entry in the _entries list
            { _outputFile.WriteLine(_entry); }// writes the _entry into a file with the JournalEntry.ToString Method
        }
    }


    // // LoadJournal Method
    public void LoadJournal()// Loads CSV file into Journal instances
    {
        // Constants
        int _journalLength = 3;// matfhes # of JournalEntry Attributes
        int _journalDate = 0;// Index 0
        int _journalPrompt = 1;// Index 1
        int _journalResponse = 2;// Index 2

        // Clears the _entries List
        NewJournal();

        // Reads Entire File
        using StreamReader _file = new StreamReader(FetchFileName());// reads filename provided by user
        string _line;// variable to store the current line being read

        while ((_line = _file.ReadLine()) != null)// until the line stored in _line returns blank
        {
            var _parts = _line.Split("<|>");// returns each _line as an array of strings 
            if (_parts.Length == _journalLength)// checks if each line has the right number of items
                // converts each line into their corresponding JournalEntry attributes
                _entries.Add(new JournalEntry(_parts[_journalDate], _parts[_journalPrompt], _parts[_journalResponse]));
        }
    }


    // // FetchFileName Method
    public string FetchFileName()// returns the user's CSV filename
    { Console.Write("What is the filename?(.csv) "); _filename = Console.ReadLine(); return $"{_filename}.csv"; }


    // // ClearJournal Method
    public void NewJournal() { _entries.Clear(); }


    // // EndJournal Method
    public static void EndJournal() { Console.WriteLine("/nGoodbye"); Environment.Exit(0); }


    // // DefaultOption Method
    public static void DefaultOption() { Console.Write("\nNot an option. Read the options and try again"); Console.WriteLine(); }
}