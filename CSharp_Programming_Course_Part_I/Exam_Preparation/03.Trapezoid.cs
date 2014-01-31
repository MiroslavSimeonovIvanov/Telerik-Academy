using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int countStars = n;
        int countDots = n;

        Console.Write(new string('.', countDots));
        Console.WriteLine(new string('*', countStars));

        int countOuterDots = n - 1;
        int countInnerDots = n - 1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', countOuterDots));
            Console.Write('*');
            Console.Write(new string('.', countInnerDots));
            Console.WriteLine('*');
            countOuterDots--;
            countInnerDots++;
        }
        
        Console.WriteLine(new string('*', 2 * countStars));
    }
}
