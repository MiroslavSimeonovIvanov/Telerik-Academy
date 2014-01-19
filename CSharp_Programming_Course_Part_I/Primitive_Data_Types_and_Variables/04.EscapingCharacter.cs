using System;

class EscapingCharacter
{
    static void Main()
    {
        string variableOne = @"The ""use"" of quotations causes difficulties.";
        string variableTwo = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(variableOne + "\n" + variableTwo);
    }
}
