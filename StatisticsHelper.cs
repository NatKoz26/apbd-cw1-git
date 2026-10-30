public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0; // Zabezpieczenie przed pustą tablicą
            
        return (double)CalculateSum(numbers) / numbers.Length;
    }
    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0]; // Pierwszy element jako startowy - rozwiązuje problem ujemnych liczb
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}
