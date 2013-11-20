using System;

namespace bsp26
{
	class MainClass
	{

		const double PI = 3.14;

		public static void Main (string[] args)
		{
			Console.WriteLine (loopM());
		}

		// function for the approximation of Pi
		static double approximationOfPi (int n, int m)
		{
			double output = 10;
				do {
					output = n/m;
	
			} while (output != PI);
			return output;
		} // end of function

		// function loop through N
		static int loopN(){
			int n;
			for (n = 0; n <= 1000; n ++){

			} return n;
		} // end of function

		// function loop trough M
		static int loopM(){
			int m;
			for (m = 0; m <= 1000; m ++){
				Console.WriteLine (m);
			} return m;
		} // end of function
	}
}
