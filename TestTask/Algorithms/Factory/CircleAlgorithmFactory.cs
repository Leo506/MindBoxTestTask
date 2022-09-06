namespace TestTask.Algorithms.Factory;

public class CircleAlgorithmFactory : AlgorithmFactory
{
    private readonly double _radius;

    public CircleAlgorithmFactory(double radius) => _radius = radius;

    public override IAreaAlgorithm GetAlgorithm() => new CircleAreaByRadius(_radius);
}