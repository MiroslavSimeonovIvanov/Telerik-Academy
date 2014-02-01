/* The statement of the problem:
 * Write a program that allocates array of 20 integers
 * and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 */

using System;

class InitializeElementsOfArray
{
    static void Main()
    {
        // Here we allocate array of 20 integers.
        int[] array = new int[20];

        // Initialize each element of the array by its index multiplied by 5.
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
        }

        // Print the result.
        Console.WriteLine(string.Join(", ", array));
    }
}
