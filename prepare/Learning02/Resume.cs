// Resume Class for Learning 02
// Creates a list for storing Job objects
public class Resume
{
    // Attributes
    public string _name;// The Resume's owner's name


    // List
    public List<Job> _jobs = new List<Job>();// list holding the owner's job history


    // Constructors
    //// Default Constructor
    public Resume()
    {
        this._name = "";
    }


    //// Paramaterized Constructor
    public Resume(string _name)
    {
        this._name = _name;
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