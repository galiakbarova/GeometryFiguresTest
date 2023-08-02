namespace GeometryFigures.Figures;

public class Circle : Figure
{
    private readonly double _r;

    public double Radius => _r;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius length must be positive.");
        }
        
        _r = radius;
    }
    
    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }
}