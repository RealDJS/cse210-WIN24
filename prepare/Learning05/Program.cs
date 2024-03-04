// Learning05
// Dennis Skoy
// Mar 2024


class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];// list for shapes

        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 5, 50));
        shapes.Add(new Circle("yellow", 20));

        foreach (Shape i in shapes)//iterates through list
        {
            string color = i.GetColor(); double area = i.GetArea();// returns color and area
            Console.WriteLine($"This shape is {color} with an area of {area}");// prints values
        }
    }
}