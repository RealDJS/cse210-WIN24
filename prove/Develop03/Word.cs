// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Word Class:

// Word

// - word: string
// - isBlank: bool

// + GetWord() word: string
// + SetWord(word: string): void
// + ReturnBlank(): string
// + IsAlphabetic(): bool

class Word
{
    // Attributes
    private string word;
    private bool isBlank;


    // Constructors
    public Word() { this.word = ""; this.isBlank = true; }// Default
    public Word(string word) { this.word = word; this.isBlank = false; }// Paramaterized


    // Getter & Setter
    public string GetWord() { return word; }// Getter

    public void SetWord(string word) { this.word = word; }// Setter


    // Member Methods
    /** ReplaceLetters */
    public string ReturnBlank()
    {
        char[] letters = word.ToCharArray();// separate's the word's letters into an array
        for (int i = 0; i < word.Length; i++)// iterates through every letter in the array
        {
            if (char.IsLetter(letters[i]))
            {
                isBlank = true;
                letters[i] = '_';
            }
        }// replaces letter with _ if it is a valid character
        return new string(letters);// returns a _ for every letter
    }


    /** IsAlphabetic: Confirms if character is Alphabetic */
    public bool IsAlphabetic() { return word.All(char.IsLetter); }
}