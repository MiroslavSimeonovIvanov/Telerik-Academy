/* The statement of the problem:
 * Write a program that prints all the numbers from 1 to N.
 */

using System;

class PrintNumbersFrom1ToN
{
    static void Main()
    {
        // Here we want from the user to enter number N.
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // With for cycle we run through all numbers from 1 to N and print them.
        for (int numbers = 1; numbers <= n; numbers++)
        {
            Console.Write("{0} ", numbers);
        }

        Console.WriteLine();
    }
}
