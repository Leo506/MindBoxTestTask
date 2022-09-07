using TestTask.Algorithms;
using TestTask.Algorithms.Factory;

namespace TestTask;

public class Triangle : Shape
{
    private readonly double[] _sides;

    private IAreaAlgorithm _areaAlgorithm;
    
    public Triangle(double x, double y, double z)
    {
        _sides = new double[3];
        _sides[0] = x;
        _sides[1] = y;
        _sides[2] = z;


        var factory = new TriangleAlgorithmFactory(_sides);
        _areaAlgorithm = factory.GetAlgorithm();
    }

    public override double GetArea() => _areaAlgorithm.CalculateArea();
}