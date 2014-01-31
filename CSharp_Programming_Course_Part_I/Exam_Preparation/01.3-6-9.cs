using System;

class Program
{
    static void Main()
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());
        
        if (b == 3)
        {
            long sum = a + c;
            long resultOfSum = sum % 3;
            if (resultOfSum == 0)
            {
                long result = sum / 3;
                Console.WriteLine(result);
                Console.WriteLine(sum);
            }
            else if (resultOfSum != 0)
            {
                long result = sum % 3;
                Console.WriteLine(result);
                Console.WriteLine(sum);
            }
        }

        if (b == 6)
        {
            long product = a * c;
            long resultOfProduct = product % 3;
            if (resultOfProduct == 0)
	        {
                long result = product / 3;
                Console.WriteLine(result);
                Console.WriteLine(product);

            }
            else if(resultOfProduct != 0)
	        {
                long result = product % 3;
                Console.WriteLine(result);
                Console.WriteLine(product);
	        }               
         }

        if (b == 9)
        {
            long divide = a % c;
            long resultOfDivide = divide % 3;
            if (resultOfDivide == 0)
            {
                long result = divide / 3;
                Console.WriteLine(result);
                Console.WriteLine(divide);
            }
            else if (resultOfDivide != 0)
            {
                long result = divide % 3;
                Console.WriteLine(result);
                Console.WriteLine(divide);                
            }
        }
    }
}
