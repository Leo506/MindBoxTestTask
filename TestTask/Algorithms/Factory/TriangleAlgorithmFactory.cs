namespace TestTask.Algorithms.Factory;

public class TriangleAlgorithmFactory : AlgorithmFactory
{
    private readonly double[] _sides;

    public TriangleAlgorithmFactory(double[] sides) => _sides = sides;

    public override IAreaAlgorithm GetAlgorithm() => new TriangleAreaBySides(_sides);
}