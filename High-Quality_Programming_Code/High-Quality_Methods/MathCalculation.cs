using System;

namespace Methods
{
    public class MathCalculation
    {
        public static double AreaOfTriangleByGivenThreeSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            bool isAAndBGreaterThanC = (sideA + sideB) > sideC;
            bool isBAndCGreaterThanA = (sideB + sideC) > sideA;
            bool isCAndAGreaterThanB = (sideC + sideA) > sideB;

            if (isAAndBGreaterThanC == false || isBAndCGreaterThanA == false || isCAndAGreaterThanB == false)
            {
                throw new ArgumentException("The sum of the lengths of any two sides must be greater than " +
                "the length of the remaining side.");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;
        }

        public static string EquivalentOfDigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("You should enter positive digit.");
            }
        }

        public static int FindMaxElementInArray(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("You should instantiate the array.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        public static void PrintNumberInDifferentFormats(object number, string format)
        {
            string fixedPointFormat = "f";
            string percentFormat = "%";
            string roundTripFormat = "r";

            if (format != fixedPointFormat && format != percentFormat && format != roundTripFormat)
            {
                throw new FormatException("Please enter argument with valid format.");
            }

            if (format == fixedPointFormat)
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == percentFormat)
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == roundTripFormat)
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static double DistanceBetweenTwoPoints(double xOneCoordinate, double yOneCoordinate, double xTwoCoordinate,
            double yTwoCoordinate, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (yOneCoordinate == yTwoCoordinate);
            isVertical = (xOneCoordinate == xTwoCoordinate);

            double distance = Math.Sqrt((xTwoCoordinate - xOneCoordinate) * (xTwoCoordinate - xOneCoordinate) +
                (yTwoCoordinate - yOneCoordinate) * (yTwoCoordinate - yOneCoordinate));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(AreaOfTriangleByGivenThreeSides(3, 4, 5));

            Console.WriteLine(EquivalentOfDigitAsWord(5));

            Console.WriteLine(FindMaxElementInArray(5, -1, 3, 2, 14, 2, 3));

            PrintNumberInDifferentFormats(1.3, "f");
            PrintNumberInDifferentFormats(0.75, "%");
            PrintNumberInDifferentFormats(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(DistanceBetweenTwoPoints(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }
    }
}
