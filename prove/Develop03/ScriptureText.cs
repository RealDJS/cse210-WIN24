// Source code for Develop03
// Dennis Skoy
// Last edit: Feb 2024

// ScriptureText Class:

public class ScriptureText
{
    // Attributes
    private string text;// The text from the reference

    private List<Word> words;// List to parse through text

    // private List<int> blankedIndex;// indexes for words List items we cannot/already replaced with underscores

    /** characters to separate the scriptures by*/
    internal static readonly char[] separator = [' ', '.', ',', '!', '?', ';', ':', '"', '[', ']', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];


    // Getter
    public string GetText() { return text; }


    // Setter
    public void SetWords(string text)
    {
        words.Clear(); //blankedIndex.Clear();// Clears the words and blankedIndex Lists

        // Splits the text by the arguments in "separator"
        string[] splitText = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        // Adds each word and separator character to the words List
        for (int i = 0; i < splitText.Length; i++)
        {
            Word word = new Word(splitText[i]);// the current character/string is a "word"
            words.Add(word);// current word is added to list
            if (!word.IsAlphabetic())
            {
                // blankedIndex.Add(i);
            }// separator characters are indexed
        }
    }


    // Member Methods
    /** EmptyWord Method: replaces a Word in words with a "___" */
    public void EmptyWord(int number)// number = how many words to replace
    {
        int start = 0;// counter
        Random random = new();// Random integer generator
        int wordIndex = random.Next(0, words.Count);// selects word from the words List
        do
        {
            // if that index is not in the blankedIndex:
            // if (!blankedIndex.Contains(wordIndex))
            // adds to counter; replaces the word with a blank; adds that word's index number to the list
            {
                start++; words[wordIndex].ReturnBlank();
                // blankedIndex.Add(wordIndex);
            }
        } while (start != number);// while we are not done removing "number" of words
    }
}