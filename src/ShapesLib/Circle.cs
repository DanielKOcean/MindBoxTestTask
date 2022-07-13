namespace ShapesLib.Shapes;

public class Circle
{
    public double Radius { get; set; }

    public double Area() => Math.PI * Math.Pow(Radius, 2);

    public Circle() { }

    public Circle(double radius)
    {
        Radius = radius;
    }
}
