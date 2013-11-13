using System;

namespace arrays
{
	class MainClass
	{
		// TODO debuggen!

		static void read10valuesFroumUI()
		{
			int[] intArray = new int[10]; // typische Arrayschreibweise
			for (int i = 0; i < intArray.Length; i++) {
				intArray [i] = 0;
			}
		}


		static void Main (string[] args)
		{
			Console.WriteLine (read10valuesFroumUI());
		}
	}
}
