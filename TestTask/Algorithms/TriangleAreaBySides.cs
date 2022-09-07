using TestTask.Utils;

namespace TestTask.Algorithms;

public class TriangleAreaBySides : IAreaAlgorithm
{
    private readonly double[] _sides;
    private readonly double _semi_perimeter;

    private const double Tolerance = 0.01;

    public TriangleAreaBySides(double[] sides)
    {
        _sides = sides;

        foreach (var side in _sides)
        {
            _semi_perimeter += side;
        }

        _semi_perimeter *= 0.5;
    }

    public double CalculateArea()
    {
        if (!IsRightTriangle())
            return Math.Sqrt(
                _semi_perimeter * (_semi_perimeter - _sides[0]) * (_semi_perimeter - _sides[1]) * (_semi_perimeter - _sides[2]));
        
        var hypotenuse = MathUtils.Max<double>(_sides);
        var product = _sides.Where(side => !(Math.Abs(side - hypotenuse) < Tolerance))
            .Aggregate(1.0, (current, side) => current * side);

        return 0.5 * product;

    }

    private bool IsRightTriangle()
    {
        var hypotenuse = MathUtils.Max<double>(_sides);

        var sum = _sides.Where(side => !(Math.Abs(side - hypotenuse) < Tolerance)).Sum(side => Math.Pow(side, 2));

        return Math.Abs(Math.Pow(hypotenuse, 2) - sum) < Tolerance;
    }
}