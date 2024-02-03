// Resume Class for Learning 02
// Creates a list for storing Job objects
// Author: Dennis Skoy
// last edit: 2/2/24
public class Resume
{
    // Attributes
    public string _name;// The Resume's owner's name


    // List
    public List<Job> _jobs = new List<Job>();// list holding the owner's job history
    private string v;


    // Constructors
    //// Default Constructor
    public Resume()
    {
        this._name = "";
        this._jobs = [];
    }

    public Resume(string v)
    {
        this.v = v;
    }


    //// Paramaterized Constructor
    public Resume(string _name, List<Job> _jobs)
    {
        this._name = _name;
        this._jobs = _jobs;
    }


    // Methods
    public void Display()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job j in _jobs)// Displays all Job Class attributes for each object in the list
        {
            j.Display();
        }
    }
}