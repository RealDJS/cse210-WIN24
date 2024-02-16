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
    public static object UseMenu(Scripture currentScripture)
    {
        do
        {
            ClearAndRefresh();// clears the terminal
            currentScripture.DisplayScripture();// displays the currentScripture
            PromptUser();// displays the user's prompt
            string input = Console.ReadLine();// reads user's input
            EditScripture(currentScripture, input);// 
        }
        while (true);
    }


    // Member Methods
    /** EditScripture*/
    private static void EditScripture(Scripture currentScripture, string input)
    {
        int wordCount = 3;// words to replace per round
        Action action = input.ToLower() switch
        {
            "quit" => () => Quit(),// leave program
            "" => () => currentScripture.SetNewBlanks(wordCount),// removes words
            _ => () => DefaultOption()// stops unacceptable unputs
        }; action();
    }


    /** DefaultOption Method: warns about unacceptable inputs */
    private static void DefaultOption()
    { Console.WriteLine("\nNot an option. Read your options and try again"); Console.WriteLine(); }


    /** PromptUser Method: prompts user to make input */
    private static void PromptUser() { Console.WriteLine("Press enter or type 'quit'"); }


    /** ClearAndRefresh Method: clears console */
    private static void ClearAndRefresh() { Console.Clear(); }


    /** Quit Method: closes program */
    private static void Quit() { Environment.Exit(0); }
}