// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Word Class:

// Word

// - word: string
// - blank: bool

// + GetWord() word: string
// + SetWord(word: string): void
// + SetIsBlank(blank: bool): void
// + ToString(): string
// + IsAlphabetic(): bool
// + IsBlank(): bool

class Word
{
    // Attributes
    private string word;
    private bool blank;



    // Constructors
    public Word() { this.word = ""; this.blank = true; }// Default
    public Word(string word) { this.word = word; this.blank = false; }// Paramaterized


    // Getter
    public string GetWord() { return word; }

    // Setters
    public void SetWord(string word) { this.word = word; }
    public void SetIsBlank(bool blank) { this.blank = blank; }//determines if word returns as an underscore


    // Member Methods
    /** ToString Method: returns word as string */
    public override string ToString()
    // returns words not blank
    {
        if (blank && IsAlphabetic())// IF blank and contains letters:
        { return new string('_', word.Length); }// converts characters to underscores; 
        return word;
    }


    /** IsAlphabetic: Checks if character is Alphabetic */
    public bool IsAlphabetic() => word.All(char.IsLetter);


    /** IsBlank Method: Checks if word is blank */
    public bool IsBlank() { return blank; }
}