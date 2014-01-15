/* The statement of the problem:
 * Write a program that prints all the numbers from 1 to N,
 * that are not divisible by 3 and 7 at the same time.
 */

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        // Read the input number N.
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // With for cycle we run through all numbers from 1 to N.
        // We print only these numbers that are not divisible by 3 and 7 at the same time.
        for (int numbers = 1; numbers <= n; numbers++)
        {
            if (!(numbers % 3 == 0 && numbers % 7 == 0))
            {
                Console.Write("{0} ", numbers);
            }
        }

        Console.WriteLine();
    }
}
