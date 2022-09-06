using TestTask.Algorithms;

namespace TestTaskTests;

[TestFixture]
public class AlgorithmsTests
{
    [Test]
    [TestCase(1, Math.PI)]
    [TestCase(10, 314.159)]
    [TestCase(150, 70685.834)]
    public void CalculateArea_CircleByRadius_Correct(double radius, double area)
    {
        var algorithm = new CircleAreaByRadius(radius);

        var result = algorithm.CalculateArea();
        
        Assert.That(Math.Abs(result - area), Is.LessThanOrEqualTo(0.01));
    }
}