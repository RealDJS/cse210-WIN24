// Learning04 Source code
// Dennis Skoy
// Last edit: Feb 2024

// Assignment Class

class Assignment
{
    // Attributes
    private string studentName;
    private string topic;

    // Constructor
    public Assignment(string studentName, string topic) { this.studentName = studentName; this.topic = topic; }

    // Member Methods
    public string GetSummary() { return ($"{studentName} - {topic}"); }
}