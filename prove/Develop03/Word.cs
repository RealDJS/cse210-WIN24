// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Word Class:

// Word

// - word: string
// - blank: bool
// - character: bool

// + GetWord() word: string
// + SetWord(word: string): void
// + ReturnBlank(): string
// + IsAlphabetic(): bool

class Word
{
    // Attributes
    private string word;
    private bool blank;
    private bool character;


    // Constructors
    public Word() { this.word = ""; this.blank = true; this.character = false; }// Default
    public Word(string word) { this.word = word; this.blank = false; }// Paramaterized


    // Getter & Setter
    public string GetWord() { return word; }// Getter

    // Setter
    public void SetWord(string word) { this.word = word; }
    public void SetIsBlank(bool blank) { this.blank = blank; }//determines if word returns as an underscore
    public void SetIsCharacter(bool character) { this.character = character; }//characters are not blank



    // Member Methods
    /** ReplaceLetters */
    public string ReturnBlank()
    {
        char[] letters = word.ToCharArray();// separate's the word's letters into an array
        for (int i = 0; i < letters.Length; i++)// iterates through every letter in the array
        {
            if (char.IsLetter(letters[i]))
            { blank = true; letters[i] = '_'; }
        }// replaces letter with _ if it is a valid character
        return new string(letters);// returns a _ for every letter
    }


    public override string ToString()// returns the word as a string
    {
        if (blank) { return ReturnBlank(); }
        if (character) { return word; }
        else { return word; }
    }

    /** IsAlphabetic: Confirms if character is Alphabetic */
    public bool IsAlphabetic() { return word.All(char.IsLetter); }

    public bool IsBlank() { return blank; }
}