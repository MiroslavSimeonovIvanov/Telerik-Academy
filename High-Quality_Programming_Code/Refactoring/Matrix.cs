using System;
using System.Collections.Generic;

namespace Matrix
{
    public class RotatingWalkInMatrix
    {
        public static readonly IReadOnlyList<int> DirectionX = new int[] { 1, 1, 1, 0, -1, -1, -1, 0 };
        public static readonly IReadOnlyList<int> DirectionY = new int[] { 1, 0, -1, -1, -1, 0, 1, 1 };
        public const int ARRAY_LENGTH = 8;

        public static void ChangeInMatrix(ref int directionByX, ref int directionByY)
        {
            int currentDirection = 0;

            for (int index = 0; index < ARRAY_LENGTH; index++)
            {
                if (DirectionX[index] == directionByX && DirectionY[index] == directionByY)
                {
                    currentDirection = index;
                }
            }

            if (currentDirection == 7)
            {
                directionByX = DirectionX[0];
                directionByY = DirectionY[0];
                return;
            }

            directionByX = DirectionX[currentDirection + 1];
            directionByY = DirectionY[currentDirection + 1];
        }

        public static bool VerifyMatrix(int[,] arrayOfIntegers, int row, int column)
        {
            int arrayOfIntegersLength = arrayOfIntegers.GetLength(0);

            for (int index = 0; index < ARRAY_LENGTH; index++)
            {
                int walkByX = row + DirectionX[index];

                if (walkByX >= arrayOfIntegersLength || walkByX < 0)
                {
                    DirectionX[index] = 0;
                }

                int walkByY = column + DirectionY[index];

                if (walkByY >= arrayOfIntegersLength || walkByY < 0)
                {
                    DirectionY[index] = 0;
                }

                if (arrayOfIntegers[walkByX, walkByY] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Main()
        {
            int arraySize = 3;
            int[,] matrix = new int[arraySize, arraySize];
            int row = 0;
            int column = 0;
            int directionByX = 1;
            int directionByY = 1;
            int step = 1;

            while (true)
            {
                matrix[row, column] = step;

                if (!VerifyMatrix(matrix, row, column))
                {
                    break;
                }

                bool isRowInBounds = (row + directionByX >= arraySize) || (row + directionByX < 0);
                bool isColumnInBounds = (column + directionByY >= arraySize) || (column + directionByY < 0);

                while (isRowInBounds || isColumnInBounds || matrix[row + directionByX, column + directionByY] != 0)
                {
                    ChangeInMatrix(ref directionByX, ref directionByY);
                }

                row += directionByX;
                column += directionByY;
                step++;
            }

            for (int matrixRow = 0; matrixRow < arraySize; matrixRow++)
            {
                for (int matrixColumn = 0; matrixColumn < arraySize; matrixColumn++)
                {
                    Console.Write("{0,3}", matrix[matrixRow, matrixColumn]);
                }

                Console.WriteLine();
            }
        }
    }
}
