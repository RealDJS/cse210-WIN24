// Prepare05
// Dennis Skoy
// Mar 2024

// Rectangle Class

using System.Drawing;

class Rectangle : Shape
{
    // Attributes
    private double length; private double width;

    public Rectangle(string color, double length, double width) : base(color) { this.length = length; this.width = width; }


    public override double GetArea() { return width * length; }
}