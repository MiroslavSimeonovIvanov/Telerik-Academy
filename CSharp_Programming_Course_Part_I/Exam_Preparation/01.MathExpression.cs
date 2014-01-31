using System;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double numerator = (n * n) + (1 / (m * p)) + 1337;
        double denominator = n - (128.523123123 * p);
        m = (int)(m % 180);
        double sinus = Math.Sin(m);
        double result = (numerator / denominator) + sinus;

        Console.WriteLine("{0:F6}", result);
    }   
}
