using System;
using System.Linq;

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
		static double[] data; 

		// main
		static void Main (string[] args)
		{
			data = new double[6]
			{2, 4, 6, 8, 10, 12};
			Console.WriteLine("Summe: " + Summe());
			Console.WriteLine("Durchschnitt: " + Durchschnitt());
			Console.WriteLine("Maximum: " + Maximum());
			Console.WriteLine("Minimum: " + Minimum());
			Console.WriteLine("Standardabweichung: " + Standardabweichung());
		} // end of main


		// function for the sum
		static double Summe()
		{ 
			double sum = 0;
			for (int i = 0; i < data.Length; i++)
				{
					sum += data[i];
				}
			return sum;	
		} // end of function



		// function for average
		static double Durchschnitt ()
		{
			double average = Summe() / data.Length;
			return average;
		} // end of function



		// function for max
		static double Maximum()
		{
			double max = data.Max();
			return max;
		} // end of function



		// function for min
		static double Minimum()
		{
			double min = data.Min();
			return min;
		} // end of function



		// function for standard deviation
		static double Standardabweichung()
		{ 
			double average = Durchschnitt();
			double sumOfSquares = data.Select(val => (val - average) * (val - average)).Sum();
			double sd = Math.Sqrt(sumOfSquares / data.Length);
			return sd;
		} // end of function
	} 
}
