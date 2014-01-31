/* The statement of the problem:
 * Write a method that returns the last digit of given integer as an English word.
 * Examples: 512  "two", 1024  "four", 12309  "nine".
 */

using System;

class TheNameOfLastDigitMethod
{
    // Creating the method that returns the last digit of given integer as an English word.
    static void NameForADigit(int enteredNumber)
    {
        int lastDigit = enteredNumber % 10;

        switch (lastDigit)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("ERROR!");
                break;
        }
    }
    static void Main()
    {
        // Here we want from the user to enter an integer number.
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calling the method and see the result.
        NameForADigit(number);
    }
}
