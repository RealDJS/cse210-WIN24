// source code for JournalEditor Class
// This converts and interacts with Journals from CSV files
// Author: Dennis Skoy
// last edit: February 2024

class JournalEditor
{
    // Member Methods
    // // UseMenu Method
    public static object UseMenu(Journal _currentJournal)// Creates interface for the user in the terminal 
    {
        while (true)// Repeats while loop until they select Exit
        {
            // Displays Menu
            Console.Write("""
            
        Choose what to do with your Journal:
        1. Write a new Journal Entry
        2. Display the Journal
        3. Save the Journal
        4. Load a Journal
        5. Make a New Journal
        6. Exit
        """);

            // Asks User Input
            Console.Write("\nUse 1-5 to select an option: "); var _option = Console.ReadLine();

            // edits the _currentJournal with the selected _option
            EditJournal(_currentJournal, _option);
        }
    }


    // // EditJournal Method
    public static void EditJournal(Journal _currentJournal, string _option)// executes option chosen by User
    {
        Action _action = _option switch// Converts user's input to lambda expressions
        {
            "1" => () => _currentJournal.Write(),// Write a New Entry
            "2" => () => _currentJournal.DisplayJournal(),// Displays all current JournalEntry's
            "3" => () => _currentJournal.SaveJournal(),// Saves the Journal to a CSV file
            "4" => () => _currentJournal.LoadJournal(),// Load the Journal from a CSV file
            "5" => () => _currentJournal.NewJournal(),// Starts a new Journal
            "6" => () => Journal.EndJournal(),// Exits the Program
            _ => () => Journal.DefaultOption()// Prevents invalid inputs
        };

        _action();// Executes the option
    }
}