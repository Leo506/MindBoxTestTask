using TestTask;

namespace TestTaskTests;

[TestFixture]
public class ShapesTests
{
    [Test]
    [TestCase(-1)]
    [TestCase(0)]
    public void CreateCircle_RadiusLessOrEqualToZero_Throws(double radius)
    {
        var ex = Assert.Catch<Exception>(() =>
        {
            var circle = new Circle(radius);
        });
        
        StringAssert.Contains("Radius must be greater than 0", ex?.Message);
    }

    [Test]
    public void CreateTriangle_TriangleNotExists_Throws()
    {
        var ex = Assert.Catch<Exception>(() =>
        {
            var triangle = new Triangle(1, 10, 4);
        });
        
        StringAssert.Contains("Such a triangle does not exists", ex?.Message);
    }
}