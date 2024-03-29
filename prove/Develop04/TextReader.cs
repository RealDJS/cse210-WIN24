// Develop04 Source Code
// Dennis Skoy
// Last Edit: Mar 2024

// TextReader Class

class TextReader
{
    // Attributes
    private readonly string filename;

    // Constructor
    public TextReader(string filename) { this.filename = filename; }


    // Member Methods
    /** DrawText */
    public string DrawText()
    {
        List<string> lines = ReadToList(filename);// converts text document into a list of strings
        Random random = new();// Random integer generator
        int lineIndex = random.Next(0, lines.Count);// selects an integer between 0 and the list's max index
        return lines[lineIndex];// returns a random line as a string
    }

    /** ReadToList: returns each line as a list of strings */
    private static List<string> ReadToList(string filename)
    {
        string[] lines = File.ReadAllLines(filename);// reads every line in the file
        List<string> list = new List<string>(lines); return list;// creates/returns list
    }
}