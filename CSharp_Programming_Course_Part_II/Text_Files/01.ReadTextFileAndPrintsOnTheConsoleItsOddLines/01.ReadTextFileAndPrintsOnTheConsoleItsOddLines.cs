/* The statement of the problem:
 * Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.IO;

class ReadTextFileAndPrintsOnTheConsoleItsOddLines
{
    // Create a method that prints the odd lines of text file.
    static void PrintOddLines(StreamReader reader) 
    {
        using (reader)
        {
            string line = reader.ReadLine();

            // With if-else statement we scan for the lines in the text file and print only those that are odd.
            for (int lineNumber = 1; line != null; lineNumber++)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
            }
        }
    }
    static void Main()
    {
        StreamReader reader = new StreamReader("Data.txt");
        PrintOddLines(reader);
    }
}
