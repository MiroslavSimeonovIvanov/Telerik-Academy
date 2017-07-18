using System;

namespace CohesionAndCoupling
{
    public class Utility
    {
        public static void Main()
        {
            Console.WriteLine(File.GetFileNameExtension("example"));
            Console.WriteLine(File.GetFileNameExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine();

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                MathCalculation.DistanceBetweenTwoPointsInTwoDimensionalSpace(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                MathCalculation.DistanceBetweenTwoPointsInThreeDimensionalSpace(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", MathCalculation.VolumeOfRectangularCuboid(3, 4, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathCalculation.DiagonalOfRectangularCuboid(3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", MathCalculation.DiagonalOfRectangleByGivenWidthAndHeight(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathCalculation.DiagonalOfRectangleByGivenWidthAndDepth(3, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathCalculation.DiagonalOfRectangleByGivenHeightAndDepth(4, 5));
        }
    }
}
