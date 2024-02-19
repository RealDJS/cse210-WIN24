// Learning 04 Source code
// Dennis Skoy
// Last edit: Feb 2024

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Dennis Skoy", "Multiplication", "7.3", "8-19");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());

    }
}