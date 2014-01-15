/* The statement of the problem:
 * Write an if statement that examines two integer variables and 
 * exchanges their values if the first one is greater than the second one.
 */

using System;

class ExamineAndExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Please enter two integer numbers.");

        // Here we read the numbers from the console.
        Console.Write("The first number is: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("The second number is: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNumber = 0;

        if (firstNumber > secondNumber)
        {
            biggerNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = biggerNumber;
        }

        Console.WriteLine("{0}\n{1}", firstNumber, secondNumber);
    }
}
