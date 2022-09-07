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

        if (!IsCorrectTriangle())
            throw new ArgumentException("Such a triangle does not exists");

        var factory = new TriangleAlgorithmFactory(_sides);
        _areaAlgorithm = factory.GetAlgorithm();
    }

    public override double GetArea() => _areaAlgorithm.CalculateArea();

    private bool IsCorrectTriangle()
    {
        if (_sides[0] + _sides[1] <= _sides[2])
            return false;

        if (_sides[0] + _sides[2] <= _sides[1])
            return false;

        if (_sides[1] + _sides[2] <= _sides[0])
            return false;

        return true;
    }
}