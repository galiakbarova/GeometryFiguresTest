using GeometryFigures.Figures;
using Xunit;

namespace GeometryFiguresTests;

public class CircleTests
{
    [Fact]
    public void TestGetArea()
    {
        var triangle = new Circle(2);

        var area = triangle.GetArea();

        Assert.Equal(Math.PI * 4, area);
    }

    [Fact]
    public void TestInvalidCircle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
    }
}