/* The statement of the problem:
 * Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0
 * and solves it (prints its real roots).
 */

using System;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("------ Quadratic equation ------");
        Console.WriteLine("ax\u00B2 + bx + c = 0");
        Console.WriteLine("Please enter the quadratic coefficients a, b and c.");

        // In the next rows we want the user to enter the quadratic coefficients a, b and c.
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Here we calculate the discriminant and x, x1, x2.
        double D = (b * b) - (4 * a * c);
        double x = -b / (2 * a);
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);

        // With this if statements we cover all cases of the cases of the task.
        if (a == 0)
        {
            Console.WriteLine("If a = 0, then the equation is linear, not quadratic.");
        }

        if (D > 0)
        {
            Console.WriteLine("Discriminant D = {0}", D);
            Console.WriteLine("x1 = {0:F2} and x2 = {1:F2}", x1, x2);
        }

        if (D == 0)
        {
            Console.WriteLine("x = {0}", x);
        }

        if (D < 0)
        {
            Console.WriteLine("The discriminant is negative, then there are no real roots.");
        }
    }
}
