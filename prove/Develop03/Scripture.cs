// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Scripture Class:

// Scripture
// 
// - reference: Reference
// - words: List<Word>
// - blankedIndex: List<Word>
// 
// + SetWords(string text): void
// + DisplayScripture(): void
// + EmptyWord(int number): void


class Scripture
{
    // Attributes
    private Reference reference;// The Scripture's reference (ex. Genesis 1:1)
    private ScriptureText text;// The Scripture's text
    private bool blank;// if scripture is completely empty or not


    // Constructors
    /** Default */
    public Scripture() { this.reference = new Reference(); this.text = new ScriptureText(); }

    /** Paramaterized */
    public Scripture(Reference reference, ScriptureText text) { this.reference = reference; this.text = text; this.blank = false; }


    // Getter
    public Reference GetReference() { return reference; }

    public ScriptureText GetScriptureText() { return text; }


    // Setter: converts a string to a List<Word> 
    public void SetReference(Reference reference) { this.reference = reference; }
    public void SetScriptureText(ScriptureText text) { this.text = text; }
    public void SetNewBlanks(int number) { text.EmptyWords(number); }// sets "number" of words to blank boolean value


    // Member Methods
    /** DisplayScripture Method */
    public void DisplayScripture() { Console.Write($"{reference.ReturnReferenceString()} {text.PrintText}"); }
}