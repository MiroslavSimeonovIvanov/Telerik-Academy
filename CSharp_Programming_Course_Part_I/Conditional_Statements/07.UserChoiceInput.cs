/* The statement of the problem:
 * Write a program that, depending on the user's choice inputs int, double or string variable.
 * If the variable is integer or double, increases it with 1.
 * If the variable is string, appends "*" at its end.
 * The program must show the value of that variable as a console output.
 * Use switch statement.
 */

using System;

class UserChoiceInput
{
    static void Main()
    {
        // Here we want from the user to enter 0, 1 or 2.
        Console.Write("Please enter 0, 1 or 2: ");
        int inputData = int.Parse(Console.ReadLine());

        switch (inputData)
        {
            case 0:
            case 1:
                Console.Write("Enter a number: ");
                double intDoubleNumber = double.Parse(Console.ReadLine());
                intDoubleNumber++;
                Console.WriteLine("The value of the integer/double variable is {0}.", intDoubleNumber);
                break;
            case 2:
                Console.Write("Enter a string: ");
                string sequenceOfChars = Console.ReadLine();
                Console.WriteLine("The value of the string variable is " + sequenceOfChars + "*.");
                break;
            default:
                Console.WriteLine("Your choice is wrong! Please be careful.");
                break;
        }
    }
}
