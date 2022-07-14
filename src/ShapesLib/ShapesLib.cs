using ShapesLib.Shapes;

namespace ShapesLib;

public class ShapeUtils
{
    public static double GetArea(Shape shape) => shape.Area();

    public static double GetArea(List<Shape> shapes) => shapes.Aggregate(0.0, (acc, shape) => acc + shape.Area());
}
