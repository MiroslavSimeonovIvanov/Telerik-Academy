using System;

public class Statistics
{
    public static void PrintMaximum(double[] arr, int count)
    {
        double max = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine(max);
    }

    public static void PrintMinimum(double[] arr, int count)
    {
        double min = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine(min);
    }

    public static void PrintAverage(double[] arr, int count)
    {
        double container = 0;
        double average = 0;

        for (int i = 0; i < count; i++)
        {
            container += arr[i];
        }

        average = (container / count);
        Console.WriteLine(average);
    }
}
