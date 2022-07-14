using ShapesLib;
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
    public void Triangle_Area_ReturnsCorrectValue(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.Area();

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(1, 3.1416)]
    [TestCase(5, 78.5398)]
    [TestCase(1600.0, 8042477.1931)]
    public void Circle_Area_ReturnsCorrectValue(double r, double expected)
    {
        var circle = new Circle(r);

        var actual = circle.Area();

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(10, 10, 14.14, true)]
    [TestCase(7, 10, 5, true)]
    [TestCase(50, 70, 30, true)]
    [TestCase(-1, 10, 10, false)]
    [TestCase(10, -1, 10, false)]
    [TestCase(10, 10, -1, false)]
    [TestCase(0, 10, 10, false)]
    [TestCase(10, 0, 10, false)]
    [TestCase(10, 10, 0, false)]
    [TestCase(10, 10, 100, false)]
    [TestCase(10, 100, 10, false)]
    [TestCase(100, 10, 10, false)]
    public void Triangle_IsCorrect_RetursCorrectValue(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);

        var actual = triangle.IsCorrect();

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase(1, true)]
    [TestCase(1500, true)]
    [TestCase(0.0, false)]
    [TestCase(-1.0, false)]
    public void Circle_IsCorrect_RetursCorrectValue(double r, bool expected)
    {
        var circle = new Circle(r);

        var actual = circle.IsCorrect();

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase(0.0)]
    [TestCase(-1.0)]
    public void Circle_Area_ThrowsError_IfWrongSRadius(double r)
    {
        var circle = new Circle(r);

        var ex = Assert.Throws<Exception>(() => circle.Area());

        Assert.That(ex?.Message, Is.EqualTo("Radius mut be greater then 0."));
    }

    [Test]
    [TestCase(-1, 10, 10)]
    [TestCase(10, -1, 10)]
    [TestCase(10, 10, -1)]
    [TestCase(0, 10, 10)]
    [TestCase(10, 0, 10)]
    [TestCase(10, 10, 0)]
    [TestCase(10, 10, 100)]
    [TestCase(10, 100, 10)]
    [TestCase(100, 10, 10)]
    public void Triangle_Area_ThrowsError_IfWrongSides(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        var ex = Assert.Throws<Exception>(() => triangle.Area());

        Assert.That(ex?.Message, Is.EqualTo("Triangle sides dont match correct values."));
    }

    [Test]
    [TestCase(1, 3.1416)]
    [TestCase(5, 78.5398)]
    [TestCase(1600.0, 8042477.1931)]
    public void Utils_GetArea_ReturnsCorrectValueForCircle(double r, double expected)
    {
        var circle = new Circle(r);

        var actual = ShapeUtils.GetArea(circle);

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(10, 10, 14.14, 50.0000)]
    [TestCase(7, 10, 5, 16.2481)]
    [TestCase(50, 70, 30, 649.5191)]
    public void Utils_GetArea_ReturnsCorrectValueForTriangle(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);

        var actual = ShapeUtils.GetArea(triangle);

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(10.0, 0.0, 0.0)]
    [TestCase(5.0, 360, 78.5398)]
    [TestCase(1600.0, 180.0, 4021238.5965)]
    public void Sector_Area_ReturnsCorrectValue(double r, double angle, double expected)
    {
        var sector = new Sector(r, angle);

        var actual = sector.Area();

        Assert.AreEqual(expected, actual, 0.0001);
    }

    [Test]
    [TestCase(0.0, true)]
    [TestCase(360.0, true)]
    [TestCase(-0.1, false)]
    [TestCase(360.1, false)]
    public void Sector_IsCorrect_RetursCorrectValue(double angle, bool expected)
    {
        var sector = new Sector(10.0, angle);

        var actual = sector.IsCorrect();

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase(-0.1)]
    [TestCase(360.1)]
    public void Sector_Area_ThrowsError_IfWrongSRadius(double angle)
    {
        var sector = new Sector(10.0, angle);

        var ex = Assert.Throws<Exception>(() => sector.Area());

        Assert.That(ex?.Message, Is.EqualTo("Angle must be between 0 and 360."));
    }

    [Test]
    [TestCase(10.0, 0.0, 0.0)]
    [TestCase(5.0, 360, 78.5398)]
    [TestCase(1600.0, 180.0, 4021238.5965)]
    public void Utils_GetArea_ReturnsCorrectValueForSector(double r, double angle, double expected)
    {
        var sector = new Sector(r, angle);

        var actual = ShapeUtils.GetArea(sector);

        Assert.AreEqual(expected, actual, 0.0001);
    }
}
