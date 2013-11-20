using System;

namespace bsp26
{
	class MainClass
	{
		const double PI = 3.14;  // TODO: 3.141592 = 355/113
		static double output;
		static double n;
		static double m;

		public static void Main (string[] args)
		{
			approximationOfPi ();
		}
		// function for the approximation of Pi
		static void approximationOfPi ()
		{
			for (m = 0; m <= 10000; m++) {

					for (n = 0; n <= 10000; n++) {
						output = n / m;
						if (output == PI) {
							Console.WriteLine (n + "  " + m);
						}
					}

				} 
			}
		}
	}
