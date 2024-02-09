// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Scripture Class:

// Scripture
// 
// - reference: string
// - words: List<Word>
// - blankedIndex: List<Word>
// 
// + SetWords(string text): void
// + DisplayScripture(): void
// + ReplaceWord(int number): void


class Scripture
{
    // Attributes
    private Reference reference;// The Scripture's reference (ex. Genesis 1:1)
    private List<Word> words;// The text from the reference
    private List<int> blankedIndex;// indexes for words List items we cannot/already replaced with underscores
    internal static readonly char[] separator = [' ', '.', ',', '!', '?', ';', ':', '"', '[', ']', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];


    // Constructors
    /** Default */
    public Scripture() { this.reference = new Reference(); this.words = []; }

    /** Paramaterized */
    public Scripture(Reference reference, List<Word> words) { this.reference = reference; this.words = words; }


    // Getter
    public List<Word> GetWords() { return words; }

    // Setter: converts a string to a List<Word> 
    public void SetWords(string text)
    {
        words.Clear(); blankedIndex.Clear();// Clears the words and blankedIndex Lists

        // Splits the text by the arguments in "separator"
        string[] splitText = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        // Adds each word and separator character to the words List
        for (int i = 0; i < splitText.Length; i++)
        {
            Word word = new Word(splitText[i]);// the current character/string is a "word"
            words.Add(word);// current word is added to list
            if (!word.IsAlphabetic()) { blankedIndex.Add(i); }// separator characters are indexed
        }
    }


    // Member Methods
    /** DisplayScripture Method */
    public void DisplayScripture() { Console.Write($"{reference} {words}"); }


    /** ReplaceWord Method: replaces a Word in words with a "___" */
    public void ReplaceWord(int number)// number = how many words to replace
    {
        int start = 0;// counter
        Random random = new();// Random integer generator
        int wordIndex = random.Next(0, words.Count);// selects word from the words List
        do
        {
            // if that index is not in the blankedIndex:
            if (!blankedIndex.Contains(wordIndex))
            // adds to counter; replaces the word with a blank; adds that word's index number to the list
            { start++; words[wordIndex].ReplaceLetters(); blankedIndex.Add(wordIndex); }
        } while (start != number);// while we are not done removing "number" of words
    }


    /** DefaultOption Method */
    public static void DefaultOption()
    { Console.WriteLine("\nNot an option. Read you options and try again"); Console.WriteLine(); }
}