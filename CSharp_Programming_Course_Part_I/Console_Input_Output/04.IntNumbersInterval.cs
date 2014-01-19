/* The statement of the problem:
 * Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.
 */

using System;

class IntNumbersInterval
{
    static void Main()
    {
        // Reading the two positive integer numbers.
        Console.WriteLine("Please enter two positive integer numbers.");

        Console.Write("a = ");
        int numberOne = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int numberTwo = int.Parse(Console.ReadLine());

        int counter = 0; /* With this int variable we count the numbers,
                          * which the remainder of the division by 5 is 0.
                          */

        for (int i = numberOne; i <= numberTwo; i++) // Here we run through all numbers between numberOne and numberTwo.
        {
            if (i % 5 == 0)
                counter++;
        }

        // Printing the result.
        Console.WriteLine("p({0},{1}) = {2}", numberOne, numberTwo, counter);
    }
}
