using System;

namespace bsp30
{

	/* 30. (2P)Schreibe 5 Funktionen, welche von einem eindimensionalen Fließkommazahlen-Array (Parameter der Funktion) beliebiger Größe 
	 * 			Durchschnitt
	 * 			Summe
	 * 			Standardabweichung
	 * 			Minimum
	 * 			Maximum 
	 * 
	 * der Daten berechnen und zurückgeben. */

	class MainClass
	{
	
		public static void Main (string[] args)
		{
			Console.WriteLine( SingleArray(5));
		}





		static int SingleArray (int n)
		{
		// creates a new double array with slots from 0 - 9
		double [] data = new double [10]; 

			int i = 0;
		// fill the array with data
		for (n = 0; n < 10; n++) 
		{
			i += 1;
			data[n] = i;
			} return i;
		

		}

	} 
	
}
