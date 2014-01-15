/* The statement of the problem:
 * Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
 * Use a sequence of if statements.
 */

using System;

class SignOfAProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers.");

        // Here we want the user to enter three real numbers.
        Console.Write("First number = ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number = ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third number = ");
        double thirdNumber = double.Parse(Console.ReadLine());

        // With if statements we check for the sign of the product.

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product is 0.");
        }

        if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product will be - .");
        }

        if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product will be + .");
        }

        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product will be - .");
        }

        if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product will be + .");
        }

        if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product will be + .");
        }

        if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the produc will be - .");
        }

        if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the produc will be - .");
        }

        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product will be + .");
        }
    }
}
