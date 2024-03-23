// See https://aka.ms/new-console-template for more information







public static double CalculateAverage(int[] numbers) {
    double totalSum = 0; // Zmiana z 'sum' na 'totalSum'
    foreach (int number in numbers) {
        totalSum += number;
    }
    return numbers.Length > 0 ? totalSum / numbers.Length : 0;
}