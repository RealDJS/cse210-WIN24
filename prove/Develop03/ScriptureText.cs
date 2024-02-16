// Source code for Develop03
// Dennis Skoy
// Last edit: Feb 2024

// ScriptureText Class:


public class ScriptureText
{
    // Attributes
    private string text;// The text from the reference
    private List<Word> words;// List of text

    /** characters to separate the scriptures by*/
    internal static readonly char[] separator = [' ', '.', ',', '!', '?', ';', ':', '"', '[', ']', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];


    public ScriptureText() { text = ""; words = []; }

    // Getter
    public string GetText() { return text; }

    // Setter
    public void SetWords(string text)
    {
        words.Clear(); // Clears the words Lists

        // Splits the text by the arguments in "separator"
        string[] splitText = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        // Adds each word and separator character to the words List
        for (int i = 0; i < splitText.Length; i++)
        {
            Word word = new Word(splitText[i]);// the current character/string is a "word"
            words.Add(word);// current word is added to list
            if (!word.IsAlphabetic()) { word.SetIsCharacter(false); }// separator characters are not words
        }
    }


    // Member Methods
    /** EmptyWord Method: sets new words to Blank */
    public void EmptyWords(int number)// number = how many words to replace
    {
        int start = 0;// counter
        Random random = new();// Random integer generator
        List<int> notBlanked = Enumerable.Range(0, words.Count).Where(i => !words[i].IsBlank() && words[i].IsAlphabetic()).ToList();
        // int wordIndex = random.Next(0, words.Count);// selects word from the words List

        for (int i = start; i < number && notBlanked.Any(); i++)
        {
            int index = random.Next(notBlanked.Count);
            words[notBlanked[index]].SetIsBlank(true);
            notBlanked.RemoveAt(index);
        }

        // do
        // {
        // 	Word word = words[wordIndex];// the current word in the word list
        // 	if (!word.IsAlphabetic())// if that word is not a separator:
        // 	{ start++; word.SetIsBlank(true); }// adds to counter; sets the word to blank
        // } while (start != number);// while we are not done removing "number" of words
    }


    public void PrintText()// Print words List
    {
        for (int i = 0; i < words.Count; i++) // for every word in the words list
        { Console.Write(words[i].ToString()); }// returns string through the Word Class ToString method
    }
}