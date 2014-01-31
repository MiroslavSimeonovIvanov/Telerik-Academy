/* The statement of the problem:
 * Write a method that reverses the digits of given decimal number.
 * Example: 256  652
 */

using System;

class ReverseTheDigitsOfGivenDecimalNumber
{
    // Creating a method that reverse the digits of number. 
    static void ReverseNumber(int enteredNumber)
    {
        int reversedNumber = 0;
        while (enteredNumber != 0)
        {
            reversedNumber = reversedNumber * 10 + enteredNumber % 10;
            enteredNumber = enteredNumber / 10;
        }
        Console.WriteLine("Reversed number: {0}", reversedNumber);
    }
    static void Main()
    {
        // Read the number.
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        // Print the result.
        ReverseNumber(number);
    }
}
