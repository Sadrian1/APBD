// See https://aka.ms/new-console-template for more information

public static class ArrayUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.", nameof(numbers));
        }

        long sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}