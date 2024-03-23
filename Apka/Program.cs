// See https://aka.ms/new-console-template for more information

public static int FindMaxValue(int[] numbers) {
    if (numbers == null || numbers.Length == 0) {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    int maxValue = numbers[0];
    foreach (var num in numbers) {
        if (num > maxValue) {
            maxValue = num;
        }
    }

    return maxValue;
}