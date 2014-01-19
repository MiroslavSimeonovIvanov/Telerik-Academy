/* The statement of the problem:
 * Write a program that reads 3 integer numbers from the console and prints their sum.
*/

using System;

class Read3IntNumbersAndTheirSum
{
    static void Main()
    {
        // Changing the color of the console is just for the experiment.
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Here we read the three integer numbers, one by one.
        Console.Write("Please enter the first integer number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second integer number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Please enter the third integer number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        // Declaring a variable sum of type long in which we add the numbers we have entered.
        long sum = (long)firstNum + secondNum + thirdNum;

        // Printing the sum.
        Console.WriteLine("The sum of the numbers you have entered is: {0}", sum);
    }
}
