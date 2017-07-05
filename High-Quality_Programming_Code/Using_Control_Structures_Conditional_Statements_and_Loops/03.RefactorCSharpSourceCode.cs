using System;

class ForLoop
{
    const int DEVILS_NUMBER = 666;

    for (int index = 0; index < 100; index++)
    {
		    if (index % 10 == 0)
	      {
		        Console.WriteLine(arrayOfNumbers[index]);
	      }
        else if (arrayOfNumbers[index] == DEVILS_NUMBER)
	      {
		        Console.WriteLine("Value Found");
	      }
	  }    
}
