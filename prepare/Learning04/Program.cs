// Learning 04 Source code
// Dennis Skoy
// Last edit: Feb 2024

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dennis Skoy", "Multiplication");//Assignment
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("Dennis Skoy", "Long Division", "7.3", "8-19");//MathAssignment
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Dennis Skoy", "U.S. History", "Today");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}