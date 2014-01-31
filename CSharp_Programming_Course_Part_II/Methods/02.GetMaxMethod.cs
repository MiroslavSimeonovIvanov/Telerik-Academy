/* The statement of the problem:
 * Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console
 * and prints the biggest of them using the method GetMax().
 */

using System;

class GetMaxMethod
{
    // Creating the GetMax method.
    static int GetMax(int firstNumber, int secondNumber)
    {
        int biggerNumber = firstNumber;
        if (secondNumber > firstNumber)
        {
            biggerNumber = secondNumber;
        }
        return biggerNumber;
    }
    static void Main()
    {
        // Read three numbers from the console.
        Console.Write("Please enter the fisrt number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        
        int biggerFromTwo = GetMax(firstNumber, secondNumber);
        int largestFromThree = GetMax(biggerFromTwo, thirdNumber);

        // Printing the largest of those three numbers.
        Console.WriteLine("The largest of the three numbers is {0}.", largestFromThree);
    }
}
