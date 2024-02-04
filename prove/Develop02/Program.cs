// Source code for Develop02 Journaling program
// This creates a Journal object for the user to interact with in the JournalEditor Class
// Author: Dennis Skoy
// Last edit: February 2024

class Program
{
    static void Main(string[] args)// starts program for Develop02
    {
        Journal _currentJournal = new Journal();//  creates blank default Journal object

        JournalEditor.UseMenu(_currentJournal);// uses default Journal to start the Menu
    }
}