using System;

namespace dArray
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] array2d = new int[,] {
				{00,01},
				{10,11},
				{20,21},
				{30,31},
			};

			array2d [2, 1] = 25; // Setzt Zeile 2 Pos. 1 zu 25 (war vorher 21)


			}
	}
}
