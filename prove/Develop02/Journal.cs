// Source code for Journal Class
// This stores JournalEntries and their filenames in a list
// Author: Dennis Skoy
// last edit: 2/1/24

class Journal
{
    // Attributes
    private string _filename;// the Journal's filename given by the user
    private List<JournalEntry> _entries = new List<JournalEntry>();// a list storing JournalEntry objects

    // Constructors
    public Journal()// Default
    {
        this._filename = "";
        this._entries = [];
    }

    public Journal(string filename, List<JournalEntry> _entries)// Paramaterized Constructor
    {
        this._filename = filename;
        this._entries = _entries;
    }

    public void Write()
    {
        // Randomly Choose Prompt
        string _userPrompt = JournalPrompts.DrawPrompt();

        // Display Prompt
        Console.Write($"{_userPrompt}");

        // User input
        string _userResponse = Console.ReadLine();

        // Entry Date
        DateTime _date = DateTime.Now;
        string _dateString = _date.ToShortDateString();

        // Saves the date, prompt, and response as an Entry
        _entries.Add(new JournalEntry(_userPrompt, _userResponse, _dateString));
    }

    public void Display()
    {
        foreach (JournalEntry _page in _entries)
        {
            Console.WriteLine(_page);
        }
    }
}