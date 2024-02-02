// This is the source code for the JournalPrompts Class
// This contains prompts for the JournalEntry class to use
// Author: Dennis Skoy
// last edit: 2/1/24

static class JournalPrompts
{
    // Attributes
    public static string _filename = "prompts.txt";// text document with journal prompts


    // Member Methods
    //// ReadToList Method
    private static List<string> ReadToList(string _filename)
    {
        string[] _lines = System.IO.File.ReadAllLines(_filename);// reads every line in the file

        List<string> _list = new List<string>(_lines);// creates list

        return _list;// returns each line as a list of strings
    }


    //// DrawPrompt Method
    public static string DrawPrompt()
    {
        List<string> _prompts = ReadToList(_filename);// converts text document into a list of strings

        Random random = new();// Random integer generator

        int _promptIndex = random.Next(0, _prompts.Count);// selects an integer between 0 and the list's max index

        return _prompts[_promptIndex];// returns a random prompt as a string
    }
}