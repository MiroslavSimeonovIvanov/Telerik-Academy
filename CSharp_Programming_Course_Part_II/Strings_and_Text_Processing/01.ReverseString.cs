/* The statement of the problem:
 * Write a program that reads a string, reversed it and prints the result at the console.
 * Example: "sample"  "elpmas".
 */

using System;
using System.Text;

class ReverseString
{
    static string StringReversal(string originalString)
    {
        StringBuilder reversedString = new StringBuilder();
        for (int index = originalString.Length - 1; index >= 0; index--)
        {
            reversedString.Append(originalString[index]);
        }
        return reversedString.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Please, enter a string: ");
        string originalString = Console.ReadLine();

        Console.WriteLine("The reversed string: {0}", StringReversal(originalString));        
    }
}
