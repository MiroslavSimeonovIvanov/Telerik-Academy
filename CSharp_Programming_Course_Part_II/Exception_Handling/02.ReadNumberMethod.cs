/* The statement of the problem:
 * Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
 * If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class ReadNumberMethod
{
    // Creating the method ReadNumber.
    static void ReadNumber(int start, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number out of range!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have entered number that is not valid!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    static void Main()
    {
        // Creating the range with two integer variables.
        int startNumber = 1;
        int endNumber = 100;
        
        for (int counter = 0; counter < 10; counter++)
        {
            ReadNumber(startNumber, endNumber);
        }
    }
}
