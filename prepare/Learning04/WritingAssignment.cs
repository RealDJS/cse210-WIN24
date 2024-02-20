// Learning04 source code
// Dennis Skoy
// Last edit: Feb 2024

// WritingAssignment Class

class WritingAssignment : Assignment
{
    // Attributes
    private string title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    { this.title = title; }


    // Member Methods
    public string GetWritingInformation() { return $"{title}"; }

    // public WritingAssignment ()
}