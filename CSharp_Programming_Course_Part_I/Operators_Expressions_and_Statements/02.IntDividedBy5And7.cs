using System;

class IntDividedBy5And7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("The number can be divided by 5 and 7 in the same time.");
        }
        else
        {
            Console.WriteLine("The number can't be divided by 5 and 7 in the same time.");
        }
    }
}
