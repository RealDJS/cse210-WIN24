// Learning04 Source Code
// Dennis Skoy
// last edit: Feb 2024

class MathAssignment : Assignment
{
    // Attributes
    private string textbookSection;
    private string problems;


    // Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    { this.textbookSection = textbookSection; this.problems = problems; }

    // Member Methods
    public string GetHomeworkList() { return $"Section {textbookSection} Problems {problems}"; }
}