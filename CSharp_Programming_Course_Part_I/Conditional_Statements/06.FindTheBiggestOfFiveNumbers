/* The statement of the problem:
 * Write a program that finds the greatest of given 5 variables.
 */

using System;

class FindTheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers.");

        // Here we want from the user ot enter five integer numbers.
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.Write("Fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());

        Console.Write("Fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        // With if-else construction we run through all the numbers and find which one is the biggest.
        if (firstNumber > secondNumber && firstNumber > thirdNumber
            && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine("The first number is the biggest.");
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber
                && secondNumber > fourthNumber && secondNumber > fifthNumber)
            {
                Console.WriteLine("The second number is the biggest.");
            }
        }

        if (thirdNumber > firstNumber && thirdNumber > secondNumber
            && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine("The third number is the biggest.");
        }
        else
        {
            if (fourthNumber > firstNumber && fourthNumber > secondNumber
                && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
            {
                Console.WriteLine("The fourth number is the biggest.");
            }
        }

        if (fifthNumber > firstNumber && fifthNumber > secondNumber
            && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
        {
            Console.WriteLine("The fifth number is the biggest.");
        }
    }
}
