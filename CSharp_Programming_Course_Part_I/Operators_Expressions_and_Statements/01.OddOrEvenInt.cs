using System;

class OddOrEvenInt
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else if (number % 2 != 0)
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
