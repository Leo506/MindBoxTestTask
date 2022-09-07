namespace TestTask.Utils;

public static class MathUtils
{
    public static T Max<T>(T[]? array) where T : IComparable
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array can not be empty");

        var max = array[0];
        foreach (var item in array)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }

        return max;
    }
}