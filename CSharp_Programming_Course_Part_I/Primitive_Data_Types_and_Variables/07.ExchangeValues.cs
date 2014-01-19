using System;

class ExchangeValues
{
    static void Main()
    {
        int variableOne = 5;
        int variableTwo = 10;
        int variableThree;
        Console.WriteLine("variableOne before exchange: " + variableOne);
        Console.WriteLine("variableTwo before exchange: " + variableTwo);
        variableThree = variableOne;
        variableOne = variableTwo;
        variableTwo = variableThree;
        Console.WriteLine("variableOne after exchange: " + variableOne);
        Console.WriteLine("variableTwo after exchange: " + variableTwo);
    }
}
