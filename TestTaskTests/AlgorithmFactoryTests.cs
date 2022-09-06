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
}