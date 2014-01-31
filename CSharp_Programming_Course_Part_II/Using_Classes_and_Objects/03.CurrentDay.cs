/* The statement of the problem:
 * Write a program that prints to the console which day of the week is today.
 * Use System.DateTime.
 */

using System;

class CurrentDay
{
    // Creating method that uses DateTime.Today and DayOfWeek.
    static void WhichDayOfTheWeekIsToday()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("And there came a day, a day unlike any other and that day is {0}.", today.DayOfWeek);
    }
    static void Main()
    {
        // Print the result.
        WhichDayOfTheWeekIsToday();
    }
}
