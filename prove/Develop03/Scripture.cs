// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Scripture Class:

// Scripture()
// Scripture( 	
// 				reference: Reference
// 				text: ScriptureText )
// 
// - reference: Reference
// - words: List<Word>
// 
// + GetReference(): reference: Reference
// + GetScriptureText(): text: Reference
// + SetReference( reference: Reference ): void
// + SetScriptureText( text: ScriptureText ): void
// + DisplayScripture(): void
// + SetNewBlanks(int number): void


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


    // Setter 
    public void SetReference(Reference reference) { this.reference = reference; }
    public void SetScriptureText(ScriptureText text) { this.text = text; }
    public void SetNewBlanks(int number) { text.EmptyWords(number); }// sets "number" of words to blank boolean value


    // Member Methods
    /** DisplayScripture Method */
    public void DisplayScripture() { Console.Write($"{reference.ReturnReferenceString()} "); text.PrintText(); }
}