/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp16
 * */

using System;

namespace bsp16
{
	class MainClass			// TODO wert ist falsch... Summe ist falsch!!! 
	{

		/* (1P) Berechne die Summe aller Quadratzahlen zwischen 0 und einer eingegebenen Zahl mit Hilfe einer while-Schleife.
		 * Bei Eingabe von 100 also z.B. 1+4+9+16+...+100.
		 */

		public static void Main (string[] args)
		{
			// user input
			Console.WriteLine ( "Type in a quadratic number (2, 4, 9, 16 ...).\nThe program sums up all quadratic number from " +
				"zero to your number");
			int input = int.Parse (Console.ReadLine ());


			while (input % 2 != 0) 
			{
				Console.WriteLine ( "Your input has to be a quadratic number\n(Tipp: your number has to be divisible by 2!)") ;
				input = int.Parse (Console.ReadLine ());

			}

			int resultLoop = sumWithLoop (input);
			int resultForm = sumWithFormular (input);

			if (resultLoop == resultForm) {				               
				Console.WriteLine ("you got " + resultLoop + " for the loop,\n" +
				"and " + resultForm + " for the formular. You did it!");
			} else 
			{
				Console.WriteLine ("you got " + resultForm + " for the loop,\n" +
				"and " + resultLoop + " for the formular. There is a mistake!");

			}
		} // end of Main




		// function sumWithFormular
		public static int sumWithFormular ( int userNum ) 
		{
			int sum = 0; 
			while (sum == 0) 
			{
				for (int counter = 0; counter * counter <= userNum; counter ++) 
				{
					// formular for sum
					sum = (counter * (counter + 1) * ((2 * counter) + 1)) / 6; 
				} 
			}

			return sum;

		} // end of function




		// function sumWithLoop
		public static int sumWithLoop ( int userNum ) 
		{
			int sum = 0; 
			while (sum == 0) 
			{
				for (int counter = 0; counter * counter <= userNum; counter ++) 
				{
						// sum without formular
						sum = sum + (counter * counter);
				} 
			}

			return sum;
			 
		} // end of function

	}
}
