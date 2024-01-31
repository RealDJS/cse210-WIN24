// Source code for Journal Class
// This stores JournalEntries and their filenames in a list
// Author: Dennis Skoy
// last edit: 1/29/24

class Journal
{
    // Attributes
    public string _filename;// the Journal's filename given by the user
    public List<JournalEntry> _entries = new List<JournalEntry>();// a list storing JournalEntry objects

    // Constructors
    Journal()// Default
    {
        this._filename = "";
        this._entries = [];
    }

    Journal(string filename, List<JournalEntry> _entries)// Paramaterized Constructor
    {
        this._filename = filename;
        this._entries = _entries;
    }
}