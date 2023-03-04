using System;
					
public class Program
{
	public static void Main()
	{
		try
    {
			 int numerator = Int32.Parse(Console.ReadLine());
			 int denominator = Int32.Parse(Console.ReadLine());
			 // division generates DivideByZeroException if
			 // denominator is 0
			 int result = numerator / denominator;
      Console.WriteLine(result);  
		}
		catch(FormatException formatException)
		{
      Console.WriteLine(formatException.Message);
		}
		catch(DivideByZeroException divideByZeroException)
		{
      Console.WriteLine( divideByZeroException.Message,"Attempted to Divide by Zero");
		}
	}
}
