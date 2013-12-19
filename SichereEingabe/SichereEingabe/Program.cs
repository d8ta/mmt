using System;

namespace SichereEingabe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a number");
			double foo = secureDoubleInput();
		}

		static double secureDoubleInput()
		{
			string stringInput;
			double result;
			bool succes = true;

			do {
				if (!succes) 
				{
					Console.WriteLine("again pls.");
				}
				stringInput = Console.ReadLine();
				succes = double.TryParse(stringInput, out result);
			} while (!succes);
			return result;
		}

	}
}
