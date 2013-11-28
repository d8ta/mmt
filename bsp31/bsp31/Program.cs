using System;
using System.Linq;

namespace bsp31
{

	class MainClass
	{
		static double[] data = new double[0];

		// main
		static void Main (string[] args)
		{
			readInNumbersCommandLine ();
			Console.WriteLine("Summe: " + Summe());
			Console.WriteLine("Durchschnitt: " + Durchschnitt());
			Console.WriteLine("Maximum: " + Maximum());
			Console.WriteLine("Minimum: " + Minimum());
			Console.WriteLine("Standardabweichung: " + Standardabweichung());
		} // end of main



		// function to read in usernumbers
		static void readInNumbersCommandLine()
		{
			Console.WriteLine("enter the length of your array: ");
			int arraylength = checkInput(0, int.MaxValue);
			data = new double[arraylength];

			////filling the array with user input
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write("enter a number you wish to hold in your array: ");
				data[i] = checkInputDouble(0, double.MaxValue);

			}
			//printing out the array
			Console.WriteLine("here is your array: ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.WriteLine(data[i]);
			}
		} // end of function




		// check user input for negative numbers or strings
		static double checkInputDouble (double min, double max)
		{
			bool inputIsOK;
			double userInput;

			do {
				inputIsOK = double.TryParse (Console.ReadLine (), out userInput);

				if ((inputIsOK == true) && (userInput >= min) && (userInput <= max)) {
					inputIsOK = true;
				} else {
					inputIsOK = false;
					Console.WriteLine ("try again, your input is wrong!");
				}
			} while (inputIsOK == false);
			return userInput;
		} // end of function



		// check user input for negative numbers or strings
		static int checkInput (int min, int max)
		{
			bool inputIsOK;
			int userInput;

			do {
				inputIsOK = int.TryParse (Console.ReadLine (), out userInput);

				if ((inputIsOK == true) && (userInput >= min) && (userInput <= max)) {
					inputIsOK = true;
				} else {
					inputIsOK = false;
					Console.WriteLine ("try again, your input is wrong!");
				}
			} while (inputIsOK == false);
			return userInput;
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

