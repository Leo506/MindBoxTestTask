using TestTask.Algorithms;
using TestTask.Algorithms.Factory;

namespace TestTaskTests;

[TestFixture]
public class AlgorithmFactoryTests
{
    [Test]
    public void GetAlgorithm_ForCircle_ReturnsCircleAreaByRadius()
    {
        var factory = new CircleAlgorithmFactory(1);

        var result = factory.GetAlgorithm();
        
        Assert.That(result.GetType(), Is.EqualTo(typeof(CircleAreaByRadius)));
    }

    [Test]
    public void GetAlgorithm_ForTriangle_ReturnsTriangleAreaBySides()
    {
        var factory = new TriangleAlgorithmFactory(new double[]{ 1, 1, 1 });

        var result = factory.GetAlgorithm();
        
        Assert.That(result.GetType(), Is.EqualTo(typeof(TriangleAreaBySides)));
    }
}