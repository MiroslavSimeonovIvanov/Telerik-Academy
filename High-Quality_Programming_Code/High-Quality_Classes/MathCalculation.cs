using System;

namespace CohesionAndCoupling
{
    public class MathCalculation
    {
        public static double DistanceBetweenTwoPointsInTwoDimensionalSpace(double xOneCoordinate, double yOneCoordinate,
            double xTwoCoordinate, double yTwoCoordinate)
        {
            double distance = Math.Sqrt((xTwoCoordinate - xOneCoordinate) * (xTwoCoordinate - xOneCoordinate) +
                (yTwoCoordinate - yOneCoordinate) * (yTwoCoordinate - yOneCoordinate));
            return distance;
        }

        public static double DistanceBetweenTwoPointsInThreeDimensionalSpace(double xOneCoordinate, double yOneCoordinate,
            double zOneCoordinate, double xTwoCoordinate, double yTwoCoordinate, double zTwoCoordinate)
        {
            double distance = Math.Sqrt((xTwoCoordinate - xOneCoordinate) * (xTwoCoordinate - xOneCoordinate) +
                (yTwoCoordinate - yOneCoordinate) * (yTwoCoordinate - yOneCoordinate) +
                (zTwoCoordinate - zOneCoordinate) * (zTwoCoordinate - zOneCoordinate));
            return distance;
        }

        public static double VolumeOfRectangularCuboid(double width, double height, double depth)
        {
            if (width <= 0 || height <= 0 || depth <= 0)
            {
                throw new ArgumentException("The width, the height and the depth should be positive.");
            }

            double volume = width * height * depth;
            return volume;
        }

        public static double DiagonalOfRectangularCuboid(double width, double height, double depth)
        {
            if (width <= 0 || height <= 0 || depth <= 0)
            {
                throw new ArgumentException("The width, the height and the depth should be positive.");
            }

            double diagonal = Math.Sqrt((width * width) + (height * height) + (depth * depth));
            return diagonal;
        }

        public static double DiagonalOfRectangleByGivenWidthAndHeight(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("The width and the height should be positive.");
            }

            double diagonal = Math.Sqrt((width * width) + (height * height)); ;
            return diagonal;
        }

        public static double DiagonalOfRectangleByGivenWidthAndDepth(double width, double depth)
        {
            if (width <= 0 || depth <= 0)
            {
                throw new ArgumentException("The width and the depth should be positive.");
            }

            double diagonal = Math.Sqrt((width * width) + (depth * depth));
            return diagonal;
        }

        public static double DiagonalOfRectangleByGivenHeightAndDepth(double height, double depth)
        {
            if (height <= 0 || depth <= 0)
            {
                throw new ArgumentException("The height and the depth should be positive.");
            }

            double diagonal = Math.Sqrt((height * height) + (depth * depth));
            return diagonal;
        }
    }
}
