/* The statement of the problem:
 * Write a program that reads a year from the console and checks whether it is a leap.
 * Use DateTime.
 */

using System;

class IfYearIsALeap
{
    static void Main()
    {
        // Read the input data.
        Console.Write("User please enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // With if-else statement and DateTime method IsLeapYear we check whether the year is leap or not.
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("The year you have entered is not leap.");
        }
    }
}
