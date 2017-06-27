using System;

public class Numbers
{
    const int NUMBER = 6;

    // Here we convert the given integer constant to string.
    public static void ConvertToString(bool isString)
    {
        if (isString == true)
        {
            string numberLikeString = NUMBER.ToString();
            Console.WriteLine(numberLikeString);
        }
    }

    public static void Main()
    {
        Numbers.ConvertToString(true);
    }
}
