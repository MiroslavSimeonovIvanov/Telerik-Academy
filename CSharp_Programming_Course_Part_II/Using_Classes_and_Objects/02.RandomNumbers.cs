/* The statement of the problem:
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class RandomNumbers
{
    // Create method that generates and prints to the console 10 random values in the range [100, 200].
    static void GeneratorOfRandomNumbers()
    {
        Random generator = new Random();

        for (int counter = 0; counter < 10; counter++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int randomNumbers = generator.Next(100, 201);
            Console.Write("{0} ", randomNumbers);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }
    static void Main()
    {
        // Print the result.
        Console.WriteLine("*** Generate Random Numbers ***");
        Console.WriteLine();
        GeneratorOfRandomNumbers();
        Console.WriteLine();
    }
}
