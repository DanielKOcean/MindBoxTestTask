namespace ShapesLib.Shapes;

public class Triangle : Shape
{
    public double SideA { get; set; }

    public double SideB { get; set; }

    public double SideC { get; set; }

    public Triangle() { }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private double SP => (SideA + SideB + SideC) / 2; // Semi-perimeter

    public override double Area() => Math.Sqrt(SP * (SP - SideA) * (SP - SideB) * (SP - SideC)); // Heron's Formula
}
