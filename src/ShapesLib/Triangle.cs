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

    public override double Area()
    {
        if (!IsCorrect()) throw new Exception("Triangle sides dont match correct values.");

        return Math.Sqrt(SP * (SP - SideA) * (SP - SideB) * (SP - SideC)); // Heron's Formula
    }

    public override bool IsCorrect() =>
        SideA > 0.0 &&
        SideB > 0.0 &&
        SideC > 0.0 &&
        (SideA + SideB) > SideC &&
        (SideB + SideC) > SideA &&
        (SideA + SideC) > SideB;

    public bool IsRightTriangle()
    {
        if (!IsCorrect()) throw new Exception("Triangle sides dont match correct values.");

        var a2 = SideA * SideA;
        var b2 = SideB * SideB;
        var c2 = SideC * SideC;

        var delta = 0.0001;

        return Math.Abs(a2 - b2 - c2) < delta ||
            Math.Abs(b2 - a2 - c2) < delta ||
            Math.Abs(c2 - a2 - b2) < delta;
    }
}
