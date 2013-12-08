using System;

namespace WürfelPoker_bsp39
{
	class MainClass
	{
		static int[] PlayerA = new int[9];
		static int[] PlayerB = new int[9];

		// Main
		public static void Main (string[] args)
		{
			PokerRounds ();
		} // Ende Main



		// Zufallswürfel Generator
		static int RandomGenerator (int min, int max)
		{
			Random random = new Random ((int)DateTime.Now.Ticks);
			return random.Next (min, max);
		} // Ende


		// Spielrunde
		static void PokerRounds ()
		{
			for (int i = 0; i < 10; i++) 
			{
				int codeA = RollingPlayerA ();
				int codeB = RollingPlayerB ();
				// If Conditions für (a) - (e)
				Console.WriteLine (codeA);						
			}
		}

		// Vergleiche A und B
		static int ComparePlayerRolls ()
		{
			int leer = 0;
			return leer;
		}




		// PlayerA Rolling
		static int RollingPlayerA ()
		{
			int resultA = 0;
			int rolling1 = RandomGenerator (1, 6);
			int rolling2 = RandomGenerator (1, 6);			
			int rolling3 = RandomGenerator (1, 6);
			// Fall (a) drei verschiedene Augenzahlen
			if (rolling1 != rolling2 && rolling1 != rolling3 && rolling2 != rolling3) {
				/*Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n three different cards");*/
				resultA = 1;
			}
			// Fall (b) ein Paar
			else if ((rolling1 == rolling2 && rolling1 !=rolling3) || (rolling1 == rolling3 && rolling1 != rolling2) || (rolling2 == rolling3 && rolling2 != rolling1)) {
				/*	Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a pair");*/
				resultA = 2;
			}
			// Fall (d) ein Triple
			else if (rolling1 == rolling2 && rolling1 == rolling3 && rolling2 == rolling3) {
				/*	Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a triple");*/
				resultA = 3;
			} 
			return resultA;


		} // Ende PlayerA

		// PlayerB Rolling
		static int RollingPlayerB ()
		{
			int resultB = 0;
			int rolling1 = RandomGenerator (1, 6);
			int rolling2 = RandomGenerator (1, 6);			
			int rolling3 = RandomGenerator (1, 6);
			// Fall (a) drei verschiedene Augenzahlen
			if (rolling1 != rolling2 && rolling1 != rolling3 && rolling2 != rolling3) {
				/*	Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\ndifferent cards");*/
				resultB = 1;
			}
			// Fall (b) ein Paar
			else if ((rolling1 == rolling2 && rolling1 !=rolling3) || (rolling1 == rolling3 && rolling1 != rolling2) || (rolling2 == rolling3 && rolling2 != rolling1)) {
				/*	Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a pair");*/
				resultB = 2;
			}
			// Fall (d) ein Triple
			else if (rolling1 == rolling2 && rolling1 == rolling3 && rolling2 == rolling3) {
				/*	Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a triple");*/
				resultB = 3;
			} 
			return resultB;

		} // Ende PlayerB
	}
}
