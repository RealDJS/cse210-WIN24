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


    // Constructors
    /** Default */
    public Scripture() { this.reference = new Reference(); this.text = new ScriptureText(); }

    /** Paramaterized */
    public Scripture(Reference reference, ScriptureText text) { this.reference = reference; this.text = text; }


    // Getter
    public Reference GetReference() { return reference; }

    public ScriptureText GetScriptureText() { return text; }


    // Setter: converts a string to a List<Word> 
    public void SetReference(Reference reference) { this.reference = reference; }
    public void SetScriptureText(ScriptureText text) { this.text = text; }


    // Member Methods
    /** DisplayScripture Method */
    public void DisplayScripture() { Console.Write($"{reference.ReturnReferenceString()} {text}"); }
}