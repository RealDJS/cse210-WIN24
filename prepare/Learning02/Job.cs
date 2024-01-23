// Job Class for Learning 02
// Tracks the job title, company, starting year, and ending year for each job
public class Job
{
    // Attributes
    public string _jobTitle;
    public string _company;// company worked for under that jobTitle
    public int _startYear;// starting year working at the company
    public int _endYear;// last year working at the company


    // Constructors
    //// Default Constructor
    public Job()
    {
        this._jobTitle = "";
        this._company = "";
        this._startYear = 0;
        this._endYear = 0;
    }

    //// Parameterized Constructor
    public Job(string _jobTitle, string _company, int _startYear, int _endYear)
    {
        this._jobTitle = _jobTitle;
        this._company = _company;
        this._startYear = _startYear;
        this._endYear = _endYear;
    }


    //// Methods
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}