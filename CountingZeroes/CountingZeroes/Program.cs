using System;

namespace CountingZeroes
{
	class MainClass
	{
		// countzeros method
		public static uint CountZeroes(int[,]arr){
			uint numOfZeroes = 0;
			for (int i = 0; i < arr.GetLength(0); i++) {
				for (int j = 0; j < arr.GetLength(1); j++) 
				{
					if (arr[i,j] == 0) {
						numOfZeroes++;
					}
				}
			} return numOfZeroes;
		}


		// arraymethode
		public static void Array(){

			int[,] arr = new int[10, 10];
			for (int i = 0; i < arr.GetLength(0); i++) {
				for (int j = 0; j < arr.GetLength(1); j++) 
				{
					arr [i, j] = 222 / 2 * 2;
					Console.WriteLine (arr[i,j]);
				}
			}
		}


		// mainmethod
		public static void Main (string[] args)
		{
			Array ();
		}
	}
}
