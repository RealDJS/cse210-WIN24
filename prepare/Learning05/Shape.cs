// Source code for Prepare05
// Dennis Skoy
// Mar 2024

// Shape Class

abstract class Shape
{
    // Attributes
    private string color;

    // Constructor
    protected Shape(string color) { this.color = color; }


    // Getter
    public string GetColor() { return color; }

    // Setter
    public void SetColor(string color) { this.color = color; }

    // Member Methods
    public abstract double GetArea();
}