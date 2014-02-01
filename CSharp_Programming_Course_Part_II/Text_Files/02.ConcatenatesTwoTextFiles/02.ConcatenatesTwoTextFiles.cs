/* The statement of the problem:
 * Write a program that concatenates two text files into another text file.
 */

using System;
using System.IO;

class ConcatenatesTwoTextFiles
{    
    static void Main()
    {
        // Read two text files and then concatenate them in third one.
        StreamReader readFirstTextFile = new StreamReader("FirstTextFile.txt");
        StreamReader readerSecondTextFile = new StreamReader("SecondTextFile.txt");
        StreamWriter writer = new StreamWriter("Concatenated.txt");

        using (readFirstTextFile)
        {
            using (readerSecondTextFile)
            {
                using (writer)
                {
                    string textOne = readFirstTextFile.ReadToEnd();
                    string textTwo = readerSecondTextFile.ReadToEnd();
                    writer.Write(textOne + "\r\n" + textTwo);
                }
            }
        }
    }
}
