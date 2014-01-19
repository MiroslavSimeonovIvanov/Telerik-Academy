using System;

class AreaOfRectangle
{
    static void Main()
    {
        Console.Write("Please enter the length of the rectangle: ");
        float length = float.Parse(Console.ReadLine());

        Console.Write("Now enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("The area of the rectangle is {0}.", length * width);
    }
}
