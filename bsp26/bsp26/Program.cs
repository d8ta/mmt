/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo4 bsp26
 * */

using System;

namespace bsp26
{
	class MainClass
	{
		const double PI = 3.141592;

		public static void Main (string[] args)
		{
			approximationOfPi (10000);
		}
		// function for the approximation of Pi
		static void approximationOfPi (int range)
		{
			for (double m = 1; m < range; m++) {
				for (double n = 1; n < range; n++) {
					double output = n / m;
					if ((output >= PI) && (output <= PI + 0.000001))
						Console.WriteLine (n + "  " + m);
				}
			}
		}
	}
}