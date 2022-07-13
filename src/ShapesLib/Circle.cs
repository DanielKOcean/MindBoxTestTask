namespace ShapesLib.Shapes;

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area() => Math.PI * Math.Pow(Radius, 2);

    public Circle() { }

    public Circle(double radius)
    {
        Radius = radius;
    }
}
