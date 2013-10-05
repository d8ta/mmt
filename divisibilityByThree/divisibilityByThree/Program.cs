using System;

namespace divisibilityByThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Berechne die Summe aller durch 3 teilbaren Zahlen zwischen 0 und 100 mit Hilfe einer for-Schleife.


			// define the range 0 - 100
			int num = 100;
			int sum = 0;

			// for loop to go from 0 - 100
			for (int i = 1; i <= num; i++) {
				if (i % 3 == 0) {

					// add the new i to the sum from the last loop
					sum = sum + i;	
				} 

			}

			// give out the number 
			Console.WriteLine ("the sum is " + sum);
		}
	}
}
