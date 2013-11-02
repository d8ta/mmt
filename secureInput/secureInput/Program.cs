using System;

namespace secureInput
{
	class MainClass
	{


		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a Number:");
			double foo = secureDoubleInput ();  // ??
		}


		static double secureDoubleInput()
		{

			string stringInput;
			double result;
			bool success = true;

			do {
				if (!success) {
					Console.WriteLine ("Enter a valid Number!");
				}
				stringInput = Console.ReadLine ();
				success = double.TryParse (stringInput, out result); // ??
			} 
			while (!success);

			return result;
		}
	
	
	
	
	
	}
}
