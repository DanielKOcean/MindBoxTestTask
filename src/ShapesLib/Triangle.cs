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

    public override bool IsCorrect() =>
        SideA > 0.0 &&
        SideB > 0.0 &&
        SideC > 0.0 &&
        (SideA + SideB) > SideC &&
        (SideB + SideC) > SideA &&
        (SideA + SideC) > SideB;
}