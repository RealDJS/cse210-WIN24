// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// ScriptureMenu Class:

// ScriptureMenu

// + PromptUser(): void
// + InsertBlanks(): void
// + ClearAndRefresh(): void
// + Quit(): void

class ScriptureMenu
{
    public static object UseMenu(Scripture currentScripture)
    {
        do
        {
            ClearAndRefresh();
            currentScripture.DisplayScripture();
            PromptUser();
            var input = Console.ReadLine();
            EditScripture(currentScripture, input);
        }
        while (true);
    }


    // Member Methods
    /** EditScripture*/
    private static void EditScripture(Scripture currentScripture, string input)
    {
        int wordCount = 3;// words to replace per round
        Action action = input.ToLower() switch//
        {
            "quit" => () => Quit(),
            "" => () => currentScripture.ReplaceWord(wordCount),
            _ => () => Scripture.DefaultOption()
        }; action();
    }


    /** PromptUser Method: prompts user to make input */
    public static void PromptUser() { Console.WriteLine("Press enter or type 'quit'"); }


    /** ClearAndRefresh Method */
    public static void ClearAndRefresh() { Console.Clear(); }


    /** Quit Method */
    public static void Quit() { Environment.Exit(0); }
}