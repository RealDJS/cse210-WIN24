// Prepare05
// Dennis Skoy
// Mar 2024

// Square Class

class Square : Shape
{
    // Attributes 
    private double side;

    // Constructor
    public Square(string color, double side) : base(color) { this.side = side; }

    // GetArea
    public override double GetArea() { return side * side; }
}