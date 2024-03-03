// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// ScriptureMenu Class:

// wordCount: const int

// UseMenu( currentScripture: Scripture): void

// + ManageInput(): void
// + DefaultOption(): void
// + PromptUser(): void
// + ClearAndRefresh(): void
// + Quit(): void

class ScriptureMenu
{
    // Constant
    private const int wordCount = 3;// words to replace per round


    // Member Methods
    /** UseMenu Method: sets up menu for user */
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


    /** ManageInput */
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