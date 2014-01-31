/* The statement of the problem:
 * Write a method that asks the user for his name
 * and prints “Hello, <name>” (for example, “Hello, Peter!”).
 * Write a program to test this method.
 */

using System;

public class UsernameMethod
{
    // Creating a method for printing the user's name.
    public static void PrintUserName(string userName)
    {
        string name = userName;
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        // Changing the foreground color for user's enjoyment.
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        // Calling the method.
        PrintUserName(userName);
    }
}
