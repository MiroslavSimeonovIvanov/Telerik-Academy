using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int countStars = n;
        int countDots = n - countStars;

        for (int i = 1; i <= (n / 2); i++)
        {
            Console.Write(new string ('.', countDots));
            Console.Write(new string('*', countStars));
            Console.WriteLine(new string('.', countDots));
            countStars -= 2;
            countDots++;
        }

        Console.Write(new string('.', n / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', n / 2));

        countStars = 3;
        countDots = (n - countStars) / 2;

        for (int i = 1; i <= (n / 2); i++)
        {
            Console.Write(new string('.', countDots));
            Console.Write(new string('*', countStars));
            Console.WriteLine(new string('.', countDots));
            countStars = countStars + 2;
            countDots--;
        }
    }
}
