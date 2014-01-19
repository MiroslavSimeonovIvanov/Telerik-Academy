using System;

class StringVariables
{
    static void Main()
    {
        string variableOne = "Hello";
        string variableTwo = "World";
        object container = variableOne + " " + variableTwo;
        string variableThree = (string)container;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The final result is " + variableThree + ".");
    }
}
