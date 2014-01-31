/* The statement of the problem:
 * Write a method that checks if the element at given position
 * in given array of integers is bigger than its two neighbours (when such exist).
 */

using System;

class ChecksIfElementIsBiggerThanItsNeighbours
{
    // Create a method that checks if element at given position in array of integers is bigger than its two neighbours.
    static void ChecksElementInArrayIsBiggerThanItsNeighbours(int index, int[] array)
    {
        int elementOnFirstPosition = array[0];
        int elementOnLastPosition = array[9];

        if ((index == 0) && (elementOnFirstPosition > array[1]))
        {
            Console.WriteLine("Element {0} at position {1} is bigger than it right neighbour.", array[index], index);
        }
        else if ((index == 9) && (elementOnLastPosition > array[8]))
        {
            Console.WriteLine("Element {0} at position {1} is bigger than it left neighbour.", array[index], index);
        } 

        if ((array[index] > array[index - 1]) && (array[index] > array[index + 1]))
        {
            Console.WriteLine("Element {0} at position {1} is bigger than its neighbours.", array[index], index);
        }
        else
        {
            Console.WriteLine("There isn't an element in the array that is bigger than its neighbours.");
        }        
    }
    static void Main()
    {
        // Here we want from the user to enter the position of the element.
        Console.Write("Please enter the position of the element: ");
        int position = int.Parse(Console.ReadLine());

        // Creating an int array with 10 elements. 
        int[] arrayOfNumbers = new int[10];

        Console.WriteLine("Please enter the elements of the array: ");

        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            arrayOfNumbers[index] = int.Parse(Console.ReadLine());
        }

        // Print the result.
        ChecksElementInArrayIsBiggerThanItsNeighbours(position, arrayOfNumbers);
    }
}
