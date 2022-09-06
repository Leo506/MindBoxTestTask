using TestTask.Algorithms;
using TestTask.Algorithms.Factory;

namespace TestTask;

public class Circle : Shape
{
    public double Radius { get; private set; }

    public IAreaAlgorithm AreaAlgorithm { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;

        var factory = new CircleAlgorithmFactory(radius);
        AreaAlgorithm = factory.GetAlgorithm();
    }

    public override double GetArea() => AreaAlgorithm.CalculateArea();
}