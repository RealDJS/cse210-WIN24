// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// ScriptureMenu Class:

// UseMenu( currentScripture: Scripture)

// + PromptUser(): void
// + InsertBlanks(): void
// + ClearAndRefresh(): void
// + Quit(): void
// + DefaultOption(): void

class ScriptureMenu
{
    private const int wordCount = 3;// words to replace per round

    public static void UseMenu(Scripture currentScripture)
    {

        while (true)
        {
            ClearAndRefresh();// clears the terminal
            currentScripture.DisplayScripture();// displays the currentScripture
            PromptUser();// displays the user's prompt
            string input = Console.ReadLine();// reads user's input
            ManageInput(currentScripture, input);// registers the user's input
        }
    }


    // Member Methods
    /** EditScripture*/
    private static void ManageInput(Scripture currentScripture, string input)
    {
        if (!currentScripture.GetScriptureText().HasWordsLeft()) { Quit(); }// quits if no words are left
        Action action = input.ToLower() switch
        {
            "quit" => () => Quit(),// leave program
            "" => () => currentScripture.SetNewBlanks(wordCount),// removes words
            _ => () => DefaultOption()// stops unacceptable unputs
        }; action();
    }


    /** DefaultOption Method: warns about unacceptable inputs */
    private static void DefaultOption()
    { Console.WriteLine("\nNot an option. Read your options and try again"); Console.WriteLine(); Console.ReadLine(); }


    /** PromptUser Method: prompts user to make input */
    private static void PromptUser() { Console.WriteLine("\nPress enter or type 'quit'"); }


    /** ClearAndRefresh Method: clears console */
    private static void ClearAndRefresh() { Console.Clear(); }


    /** Quit Method: closes program */
    private static void Quit() { Environment.Exit(0); }
}