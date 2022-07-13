namespace ShapesLib.Shapes;

public abstract class Shape
{
    public virtual bool IsCorrect() => true;
    public virtual double Area() => 0.0;
}
