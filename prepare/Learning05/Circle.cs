// Prepare05
// Dennis Skoy
// Mar 2024

// Circle Class

class Circle : Shape
{
    // Attributes
    private double radius;

    public Circle(string color, double radius) : base(color) { this.radius = radius; }

    public override double GetArea() { return radius * radius * Math.PI; }
}