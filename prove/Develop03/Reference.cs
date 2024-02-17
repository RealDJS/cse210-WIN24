// Source Code: Develop03
// Dennis Skoy
// Last Edit: Feb 2024

// Reference Class

// Reference

// - book: string
// - chapter: int
// - verse: int
// - endVerse: int

// + GetBook(): string
// + GetChapter(): int
// + GetVerse(): int
// + GetEndVerse(): int
// + SetBook( scriptureReference: string): void
// + SetChapter( chapter: int): void
// + SetVerse( verse: int): void
// + SetEndVerse( endVerse: int): void

// + ReturnReferenceString(): string

class Reference
{
    // Attributes
    private string book;// book name
    private int chapter;// chapter in book
    private int verse;// 1st verse in chapter
    private int endVerse;// last verse in chapter

    // Constructors
    public Reference() { this.book = "Genesis"; this.chapter = 1; this.verse = 1; this.endVerse = 0; }// Default

    public Reference(string book, int chapter, int verse)// Paramaterized: One verse
    { this.book = book; this.chapter = chapter; this.verse = verse; }

    public Reference(string book, int chapter, int verse, int endVerse)// Paramaterized: multiple verses
    { this.book = book; this.chapter = chapter; this.verse = verse; this.endVerse = endVerse; }

    // Getters
    public string GetBook() { return book; }
    public int GetChapter() { return chapter; }
    public int GetVerse() { return verse; }
    public int GetEndVerse() { return endVerse; }

    // Setters
    public void SetBook(string book) { this.book = book; }
    public void SetChapter(int chapter) { this.chapter = chapter; }
    public void SetVerse(int verse) { this.verse = verse; }
    public void SetEndVerse(int endVerse) { this.endVerse = endVerse; }


    // Methods
    /** ReturnReferenceString Method: */
    public string ReturnReferenceString()// IF endverse > verse, returns verse and endVerse
    { return endVerse > verse ? $"{book} {chapter}:{verse}-{endVerse}" : $"{book} {chapter}:{verse}"; }
}