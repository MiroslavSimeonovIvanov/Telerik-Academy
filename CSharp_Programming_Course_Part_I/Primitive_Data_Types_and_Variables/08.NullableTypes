using System;

class NullableTypes
{
    static void Main()
    {
        int? variableOne = null;
        double? variableTwo = null;
        Console.WriteLine("VariableOne = {0}\n" + "VariableTwo = {1}", variableOne, variableTwo);
        variableOne = variableOne + null;
        variableTwo = variableTwo + null;
        Console.WriteLine("VariableOne = {0}\n" + "VariableTwo = {1}", variableOne, variableTwo);
        variableOne = variableOne + 1;
        variableTwo = variableTwo + 15.19;
        Console.WriteLine("VariableOne = {0}\n" + "VariableTwo = {1}", variableOne, variableTwo);
        Console.WriteLine("{0};{1}", variableOne.GetValueOrDefault(), variableTwo.GetValueOrDefault());
    }
}
