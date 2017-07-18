using System;

namespace Abstraction
{
    public class Figure
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My area is {1:f2}.",
                circle.PerimeterOfCircleByGivenRadius(), circle.AreaOfCircleByGivenRadius());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My area is {1:f2}.",
                rect.PerimeterOfRectangle(), rect.AreaOfRectangle());
        }
    }
}
