// source code for JournalEntry Class
// this stores a date, prompt, and user response
// Author: Dennis Skoy
// last edit: 2/1/24

class JournalEntry
{
    // Attributes
    private string _date;// the date the JournalEntry was made
    private string _prompt;// the _prompt provided by JournalPrompts
    private string _response;// the user's response to the _prompt


    // Constructors
    //// Default
    JournalEntry()
    {
        this._date = "";
        this._prompt = "";
        this._response = "";
    }

    //// Parameterized
    public JournalEntry(string _date, string _prompt, string _response)
    {
        this._date = _date;
        this._prompt = _prompt;
        this._response = _response;
    }


    // Getter Methods
    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }


    // Setter Methods
    public void SetDate(string _date)
    {
        this._date = _date;
    }

    public void SetPrompt(string _prompt)
    {
        this._prompt = _prompt;
    }

    public void SetResponse(string _response)
    {
        this._response = _response;
    }

    // Member Methods
    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.Write(_response);
    }
}