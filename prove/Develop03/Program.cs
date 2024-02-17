// Develop03 Source Code
// Dennis Skoy
// Last Edit: Feb 2024


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Mormon", 9, 31);
        ScriptureText scriptureText = new ScriptureText();
        scriptureText.SetWords("Condemn me not because of mine imperfection, neither my father, because of his imperfection, neither them who have written before him; but rather give thanks unto God that he hath made manifest unto you our imperfections, that ye may learn to be more wise than we have been.");

        Scripture currentScripture = new Scripture(reference, scriptureText);

        ScriptureMenu.UseMenu(currentScripture);
    }
}