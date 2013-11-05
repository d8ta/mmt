using System;

namespace bsp16
{
	class MainClass
	{

		/* (1P) Berechne die Summe aller Quadratzahlen zwischen 0 und einer eingegebenen Zahl mit Hilfe einer while-Schleife. Bei Eingabe von 100 also z.B. 1+4+9+16+...+100. */

		public static void Main (string[] args)
		{
			// TODO Falscheingabe vermeiden; Funktionen vergleichen lassen; 
			Console.WriteLine(sumWithLoop (64));;

		} // end of Main



		// function sumWithFormular
		public static int sumWithFormular ( int userNum ) {

			int sum = 0; 
			while (sum == 0) {

				for (int counter = 0; counter * counter <= userNum; counter ++) {

					sum = (counter * (counter + 1) * ((2 * counter) + 1)) / 6; 

				} 
			}

			return sum;

		} // end of function



		// function sumWithLoop
		public static int sumWithLoop ( int userNum ) {

			int sum = 0; 
			while (sum == 0) {
			
				for (int counter = 0; counter * counter <= userNum; counter ++) {
				
						sum = sum + (counter * counter);
				} 
			}

			return sum;
			 
		} // end of function


	
	
	
	
	}
}
