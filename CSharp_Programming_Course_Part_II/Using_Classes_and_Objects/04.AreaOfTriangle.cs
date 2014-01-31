/* The statement of the problem:
 * Write methods that calculate the surface of a triangle by given:
 *  Side and an altitude to it;
 *  Three sides;
 *  Two sides and an angle between them.
 * Use System.Math.
 */

using System;

class AreaOfTriangle
{
    // Here is the first method that calculates the area of triangle by given side and altitude to it.
    static double AreaOfTriangleByGivenSideAndHeightToIt(double sideB, double height) 
    {
        double area = (sideB * height) / 2;
        return area;
    }
    // The second method calculates the surface by given three sides.
    static double AreaOfTriangleByGivenThreeSides(double sideA, double sideB, double sideC)
    {
        double semiperimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
        return area;
    }
    // And the third method calculates the surface by given two sides and the angle between them.
    static double AreaOfTriangleByGivenTwoSidesAndAngleBetweenThem(double sideA, double sideB, double angleBetweenTwoSides)
    {
        double area = (sideA * sideB * Math.Sin(angleBetweenTwoSides)) / 2;
        return area;
    }
    static void Main()
    {
        // The menu.
        Console.WriteLine("--- Area Of Triangle ---");
        Console.WriteLine();
        Console.WriteLine("User please enter 1, 2 or 3: ");
        Console.WriteLine("1 ---> Area of triangle by given side and height to it");
        Console.WriteLine("2 ---> Area of triangle by given three sides");
        Console.WriteLine("3 ---> Area of triangle by given two sides and angle between them");
        Console.WriteLine();

        // Read user's choice.
        int usersChoice = int.Parse(Console.ReadLine());

        switch (usersChoice)
        {
            case 1:
                {
                    Console.Write("b: ");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.Write("h: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is {0}.", AreaOfTriangleByGivenSideAndHeightToIt(sideB, height));                    
                }
                break;
            case 2:
                {
                    Console.Write("a: ");
                    double sideA = double.Parse(Console.ReadLine());

                    Console.Write("b: ");
                    double sideB = double.Parse(Console.ReadLine());

                    Console.Write("c: ");
                    double sideC = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is {0}.", AreaOfTriangleByGivenThreeSides(sideA, sideB, sideC));
                }
                break;
            case 3:
                {
                    Console.Write("a: ");
                    double sideA = double.Parse(Console.ReadLine());

                    Console.Write("b: ");
                    double sideB = double.Parse(Console.ReadLine());

                    Console.Write("angle: ");
                    double angleBetweenTwoSides = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is {0}.", AreaOfTriangleByGivenTwoSidesAndAngleBetweenThem(sideA, sideB, angleBetweenTwoSides));
                }
                break;
            default:
                Console.WriteLine("ERROR!");
                break;
        }
    }
}
