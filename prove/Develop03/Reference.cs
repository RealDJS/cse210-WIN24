// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Reference Class

// Reference

// - scriptureReference: string

// + GetScriptureReference(): string
// + SetScriptureReference( scriptureReference: string): void

class Reference
{
    private string scriptureReference;// Attributes

    // Constructors
    public Reference() { this.scriptureReference = "Genesis 1:1"; }// Default
    public Reference(string scriptureReference) { this.scriptureReference = scriptureReference; }// Paramaterized

    // Getter & Setter
    public string GetReference() { return scriptureReference; }// Getter
    public void SetReference(string scriptureReference) { this.scriptureReference = scriptureReference; }// Setter
}