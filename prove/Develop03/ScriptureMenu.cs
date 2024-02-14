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
        Action action = input.ToLower() switch
        {
            "quit" => () => Quit(),
            "" => () => currentScripture.EmptyWord(wordCount),
            _ => () => DefaultOption()
        }; action();
    }


    /** PromptUser Method: prompts user to make input */
    private static void PromptUser() { Console.WriteLine("Press enter or type 'quit'"); }


    /** ClearAndRefresh Method */
    private static void ClearAndRefresh() { Console.Clear(); }

    /** Quit Method */
    private static void Quit() { Environment.Exit(0); }

    /** DefaultOption Method */
    private static void DefaultOption() { Console.WriteLine("\nNot an option. Read your options and try again"); Console.WriteLine(); }
}