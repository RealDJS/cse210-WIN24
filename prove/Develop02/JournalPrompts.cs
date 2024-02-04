// This is the source code for the JournalPrompts Class
// This selects prompts for the JournalEntry class to use
// Author: Dennis Skoy
// last edit: February 2024

static class JournalPrompts
{
    // Attributes
    private static readonly string _filename = "prompts.txt";// text document with journal prompts


    // Member Methods
    // // ReadToList Method
    private static List<string> ReadToList(string _filename)// Converts prompts.txt to list
    {
        string[] _lines = File.ReadAllLines(_filename);// reads every line in the file
        List<string> _list = new List<string>(_lines);// creates list
        return _list;// returns each line as a list of strings
    }


    // // DrawPrompt Method
    public static string DrawPrompt()// Randomly selects prompt from prompts.txt
    {
        List<string> _prompts = ReadToList(_filename);// converts text document into a list of strings
        Random random = new();// Random integer generator
        int _promptIndex = random.Next(0, _prompts.Count);// selects an integer between 0 and the list's max index
        return _prompts[_promptIndex];// returns a random prompt as a string
    }
}