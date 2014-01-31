/* The statement of the problem:
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly.
 */

using System;

class RepetitionOfNumberInArray
{
    // Creating method that counts how many times a given number appears in the array.
    static void SearchForNumberRepetition(int enteredNumber, int[] array)
    {
        int counter = 0;
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == enteredNumber)
            {
                counter++;
            }            
        }
        Console.WriteLine("The number {0} appears in the given array {1} times.", enteredNumber, counter);
    }
    static void Main()
    {
        // Reading the input data.
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Creating an array with 15 elements.
        int[] arrayOfNumbers = new int[15];

        Console.WriteLine("Please enter the elements of the array: ");

        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            Console.Write("Array[{0}] = ", index);
            arrayOfNumbers[index] = int.Parse(Console.ReadLine());
        }

        // Printing the result.
        SearchForNumberRepetition(number, arrayOfNumbers);
    }
}
