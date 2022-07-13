using ShapesLib.Shapes;

namespace ShapesLib.Tests;

public class ShapesLibTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(10, 10, 14.14, 50.0000)]
    [TestCase(7, 10, 5, 16.2481)]
    [TestCase(50, 70, 30, 649.5191)]
    public void TriangleAreaReturnsCorrectValue(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.Area();
        
        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(1, 3.1416)]
    [TestCase(5, 78.5398)]
    [TestCase(1600.0, 8042477.1931)]
    public void CircleAreaReturnsCorrectValue(double r, double expected)
    {
        var circle = new Circle(r);

        var actual = circle.Area();
        
        Assert.AreEqual(expected, actual, 0.0001);
    }
}