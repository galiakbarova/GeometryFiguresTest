using Xunit;
using GeometryFigures.Figures;

namespace GeometryFiguresTests;

public class TriangleTests
{
    [Fact]
    public void TestGetArea()
    {
        var triangle = new Triangle(3, 4, 5);

        var area = triangle.GetArea();

        Assert.Equal(6, area);
    }

    [Fact]
    public void TestIsRightAngled()
    {
        var triangle1 = new Triangle(3, 4, 5);
        var triangle2 = new Triangle(5, 12, 16);

        var isRightAngled1 = triangle1.IsRightAngled;
        var isRightAngled2 = triangle2.IsRightAngled;

        Assert.True(isRightAngled1);
        Assert.False(isRightAngled2);
    }

    [Fact]
    public void TestInvalidTriangle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 0));
    }
}