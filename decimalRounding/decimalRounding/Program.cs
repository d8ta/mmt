using System;


namespace decimalRounding
{
	class Program
	{
		static void Main(string[] args)
		{
			// user notification
			Console.WriteLine("type in a decimal number (i.E. 12,45).") ;

			// store user input into a string and make them a floating point number
			string userNumber = Console.ReadLine() ;
			float floatNumber = float.Parse(userNumber) ;

			// add 0,5 to the float number
			floatNumber = floatNumber + 0.5f;

			// store float number into an integer to loose the last digits 
			int roundNumber = (int)floatNumber;

			// use console to print out the number
			Console.WriteLine("the number is " + roundNumber);

			// ends the console if you push a button
			Console.ReadKey() ;
		}
	}
}
