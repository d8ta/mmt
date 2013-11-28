using System;
using System.Linq;
using System.IO;

namespace bsp31b
{	
	class MainClass
	{
		static double[] data = new double[0]; 

		// main
		static void Main (string[] args)
		{
			readInNumbersFile ();
			Console.WriteLine("Summe: " + Summe());
			Console.WriteLine("Durchschnitt: " + Durchschnitt());
			Console.WriteLine("Maximum: " + Maximum());
			Console.WriteLine("Minimum: " + Minimum());
			Console.WriteLine("Standardabweichung: " + Standardabweichung());
		} // end of main


		// readInNumbersCommandLine function
		static void readInNumbersFile()
		{

			try
			{
				string file = @"/Users/danielraudschus/Documents/numbers.txt";
				StreamReader reader = new StreamReader(file);
				int arrayLengthFromFile = int.Parse(reader.ReadLine());
				data = new double[arrayLengthFromFile];

				while (!reader.EndOfStream)
				{
					for (int i = 0; i < data.Length; i++)
					{
						data[i] = double.Parse(reader.ReadLine());
					}
				} 
				//printing out the array
				Console.WriteLine("here is your array: ");
				for (int i = 0; i < data.Length; i++)
				{
					Console.WriteLine(data[i]);
				}
			}
			catch (Exception e) 
			{
				Console.WriteLine ("Falsche Eingabe " + e.Message);
			}
			} // end of function



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

