// This is the source code for the JournalPrompts Class
// This contains prompts for the JournalEntry class to use
// Author: Dennis Skoy
// last edit: 1/31/24

using System;
using System.IO;

class JournalPrompts
{
    // Attributes
    public string _filename;

    JournalPrompts()
    {
        this._filename = "prompts";
    }

    public static List<string> ReadPrompts()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
    }

}