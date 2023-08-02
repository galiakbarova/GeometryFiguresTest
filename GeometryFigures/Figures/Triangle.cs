namespace GeometryFigures.Figures;

public class Triangle : Figure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly double _p;

    public double A => _a;
    public double B => _b;
    public double C => _c;

    public bool IsRightAngled => _a * _a + _b * _b == _c * _c
                                 || _b * _b + _c * _c == _a * _a
                                 || _a * _a + _c * _c == _b * _b;
    
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("Side", "Side length must be positive.");
        }
        
        _a = a;
        _b = b;
        _c = c;

        _p = (_a + _b + _c) / 2;
    }
    
    public override double GetArea()
    {
        return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
    }
}