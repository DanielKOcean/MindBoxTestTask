using ShapesLib.Shapes;

namespace ShapesLib;

public class ShapeUtils
{
    // Virtual method on base class invokes last oveeriden method on derived class chain.
    public static double GetArea(Shape shape) => shape.Area();

    // Virtual method on base class invokes last oveeriden method on derived class chain.
    // LINQ Aggregate method makes calculation of areas comfortable.
    public static double GetArea(List<Shape> shapes) => shapes.Aggregate(0.0, (acc, shape) => acc + shape.Area());
}
