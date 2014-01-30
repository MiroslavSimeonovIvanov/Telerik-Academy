/* The statement of the problem:
 * Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print "Invalid number".
 * In all cases finally print "Good bye". 
 * Use try-catch-finally.
 */

using System;

class SquareRootOfNumber
{
    // Here we create method that will calculate square root of a number.
    static void SquareRoot(int enteredNumber)
    {
        Console.WriteLine("The square root of number {0} is {1}.", enteredNumber, Math.Sqrt(enteredNumber));
    }
    static void Main()
    {
        // With try-catch-finally construction we cover all unusual situations.
        try
        {
            Console.Write("Please enter a positive integer number: ");
            int number = int.Parse(Console.ReadLine());

            SquareRoot(number);
        }
        catch (OverflowException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid integer number!");
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid integer number!");
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Good Bye!");
        }
    }
}
