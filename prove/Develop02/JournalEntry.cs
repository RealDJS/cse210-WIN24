// source code for JournalEntry Class
// This stores a _date, _prompt, and _response
// Author: Dennis Skoy
// last edit: February 2024

class JournalEntry
{
    // Attributes
    private string _date;// the date the JournalEntry was made
    private string _prompt;// the _prompt provided by JournalPrompts
    private string _response;// the user's response to the _prompt


    // Constructors
    // // Default
    JournalEntry() { this._date = ""; this._prompt = ""; this._response = ""; }

    // // Parameterized
    public JournalEntry(string _date, string _prompt, string _response)
    { this._date = _date; this._prompt = _prompt; this._response = _response; }


    // Getter Methods
    public string GetDate() { return _date; }
    public string GetPrompt() { return _prompt; }
    public string GetResponse() { return _response; }


    // Setter Methods
    public void SetDate(string _date) { this._date = _date; }
    public void SetPrompt(string _prompt) { this._prompt = _prompt; }
    public void SetResponse(string _response) { this._response = _response; }


    // Member Methods
    // // Display Method: Displays the JournalEntry's data
    public void Display() { Console.WriteLine($"\n{_date}: {_prompt}\n{_response}\n"); }


    // // ToString Method: saves all attributes into a single string
    public override string ToString() { return $"{_date}<|>{_prompt}<|>{_response}"; }
}