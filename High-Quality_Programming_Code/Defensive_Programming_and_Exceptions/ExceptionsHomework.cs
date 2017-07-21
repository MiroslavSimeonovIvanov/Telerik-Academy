using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] dataArray, int startIndex, int count)
    {
        if (startIndex > dataArray.Length)
        {
            throw new IndexOutOfRangeException("Your index must be less than or equal to the array length.");
        }

        if (startIndex < 0)
        {
            throw new ArgumentException("Index should be positive.");
        }

        List<T> result = new List<T>();

        for (int index = startIndex; index < startIndex + count; index++)
        {
            result.Add(dataArray[index]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string data, int count)
    {
        if (data == null || data.Length == 0)
        {
            throw new NullReferenceException("You should enter some text.");
        }

        if (count > data.Length)
        {
            throw new IndexOutOfRangeException("Invalid count!");
        }

        StringBuilder result = new StringBuilder();

        for (int index = data.Length - count; index < data.Length; index++)
        {
            result.Append(data[index]);
        }

        return result.ToString();
    }

    public static void CheckPrimeNumber(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number < 0)
            {
                throw new Exception();
            }
        }
    }

    public static void Main()
    {
        var substring = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substring);

        var subarray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarray));

        var fullDataArray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", fullDataArray));

        var emptyArray = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyArray));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        try
        {
            CheckPrimeNumber(23);
            Console.WriteLine("23 is prime.");
        }
        catch (Exception)
        {
            Console.WriteLine("The number is not positive!");
        }

        try
        {
            CheckPrimeNumber(33);
            Console.WriteLine("33 isn't prime.");
        }
        catch (Exception)
        {
            Console.WriteLine("The number is not positive!");
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new CSharpExam(0),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new SimpleMathExam(2),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
