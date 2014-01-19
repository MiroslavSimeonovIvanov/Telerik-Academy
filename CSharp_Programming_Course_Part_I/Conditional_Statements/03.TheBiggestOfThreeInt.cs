/* The statement of the problem:
 * Write a program that finds the biggest of three integers using nested if statements.
 */

using System;

class TheBiggestOfThreeInt
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers.");

        // Here we read the numbers from the console.
        Console.Write("first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        // Check which of the numbers is the biggest.
        if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0)
        {
            Console.WriteLine("The numbers are equal to 0.");
        }

        if (firstNumber == secondNumber && secondNumber == thirdNumber && firstNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal.");
        }

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The first number is greater.");
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The second number is greater.");
            }
            else
            {
                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                {
                    Console.WriteLine("The third number is greater.");
                }
            }
        }
    }
}
