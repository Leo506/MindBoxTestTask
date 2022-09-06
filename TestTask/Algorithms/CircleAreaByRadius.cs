namespace TestTask.Algorithms;

public class CircleAreaByRadius : IAreaAlgorithm
{
    private readonly double _radius;

    public CircleAreaByRadius(double radius) => _radius = radius;

    public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
}