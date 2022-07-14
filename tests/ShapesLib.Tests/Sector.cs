namespace ShapesLib.Shapes;

public class Sector : Circle
{
    public double Angle { get; set; }

    public Sector() { }

    public Sector(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }

    public override double Area()
    {
        if (!IsCorrect()) throw new Exception("Angle must be between 0 and 360.");

        return base.Area() * Angle / 360.0;
    }

    public override bool IsCorrect() =>
        base.IsCorrect() &&
        Angle >= 0.0 &&
        Angle <= 360.0;
}
