using System;
					
public class Finally
{
	public static void Main()
	{
    	Console.WriteLine( "Calling DoesNotThrowException" );
	    DoesNotThrowException();
    }
	
	
	public static void DoesNotThrowException()
	{
		// try block does not throw any exceptions
		try
		{
			Console.WriteLine( "In DoesNotThrowException" );
		}

		// this catch never executes
		catch
		{
			Console.WriteLine( "This catch never executes" );
		}

		// finally executes because corresponding try executed
		finally
		{
			Console.WriteLine(
				"Finally executed in DoesNotThrowException" );
		}

		Console.WriteLine( "End of DoesNotThrowException" );

	} // end method
}

