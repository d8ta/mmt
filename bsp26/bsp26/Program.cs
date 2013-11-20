using System;

namespace bsp26
{
	class MainClass
	{
		const double PI = 3.14159;
		static double output = 0;
		static int n = 0;
		static int m = 0;

		public static void Main (string[] args)
		{
			approximationOfPi();
		}
		// function for the approximation of Pi
		static void approximationOfPi ()
		{
			for (m = 1; m <= 10000; m++) {
				for (n = 1; n <= 500; n++) {
					if (output != PI) {
						
					} else {
						Console.WriteLine (output);
					}
				} 
			}
		}
		// end of function

		/*
		// function loop through N
		static int loopN ()
		{
			int n;
			for (n = 1; n <= 1000; n++) {
			}
			return n;
		}
		// end of function
		// function loop trough M
		static int loopM ()
		{
			int m;
			for (m = 1; m <= 1000; m++) {
			}
			return m;
		}
		// end of function */
	}
}
