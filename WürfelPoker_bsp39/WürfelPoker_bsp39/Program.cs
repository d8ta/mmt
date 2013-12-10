using System;

namespace WürfelPoker_bsp39
{
	class MainClass
	{
		//static int[] PlayerA = new int[9];
		//static int[] PlayerB = new int[9];

		static int PlayerA = 0;
		static int PlayerB = 0;
		static int sumA = 0;
		static int sumB= 0;

		// Main
		public static void Main (string[] args)
		{
			Runtime ();
		} // Ende Main

		// Runden des Spiels
		static void Runtime()
		{
			for (int i = 0; i < 9; i++) {
				PokerRound ();
			}
			while (PlayerA == PlayerB || PlayerA - PlayerB < 2) {
				PokerRound ();
			} 	
			CompareThePlayers ();


		}

		// Gewinnfeststellung
		static void CompareThePlayers ()
		{
			Console.WriteLine ("\n\t\aPlayer A has " + PlayerA + " Points\n" +
				"\n\tPlayer B has " + PlayerB + " Points.");
			if (PlayerA > PlayerB) {
				Console.WriteLine ("\nCongratulations Player A, you won!");
			} else {
				Console.WriteLine ("\nCongratulations Player B, you won!");
			}
		}

		// Zufallswürfel Generator
		static int RandomGenerator (int min, int max)
		{
			Random random = new Random ((int)DateTime.Now.Ticks);
			return random.Next (min, max);
		} // Ende

		// Spielrunde
		static void PokerRound ()
		{
			int caseA = RollingPlayerA ();
			int caseB = RollingPlayerB ();
			// If Conditions für (a) - (e)
			if (caseA == 1 && caseB == 1)
			{
				if (sumA > sumB) {
					PlayerA += 1;
				} else if (sumB > sumA) {
					PlayerB += 1;
				} else if (sumA == sumB) { // Wenn Gleiche Punktzahl dann bekommt keiner einen Punkt
					PlayerB += 0;
					PlayerA += 0;
				}
			} else if (caseA == 1 && caseB == 2 || caseB == 3) { 
				PlayerB += 1;
			} else if (caseB == 1 && caseA == 2 || caseA == 3) {
				PlayerA += 1;
			} else if (caseA == 2 && caseB == 2) {
				if (sumA > sumB) {
					PlayerA += 1;
				} else if (sumB > sumA) {
					PlayerB += 1;
				} else if (sumA == sumB) { // Wenn Gleiche Punktzahl dann bekommt keiner einen Punkt
					PlayerB += 0;
					PlayerA += 0;
				}
			} else if (caseA == 2 && caseB == 3) {
				PlayerB += 1;
			} else if (caseB == 2 && caseA == 3) {
				PlayerA += 1;
			} else if (caseA == 3 && caseB == 3) {
				if (sumA > sumB) {
					PlayerA += 1;
				} else if (sumB > sumA) {
					PlayerB += 1;
				} else if (sumA == sumB) { // Wenn Gleiche Punktzahl dann bekommt keiner einen Punkt
					PlayerB += 0;
					PlayerA += 0;
				}

			}
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
				Console.WriteLine ("\nPlayer A  has three different eyes");
				resultA = 1;
				Console.WriteLine(sumA = rolling1 + rolling2 + rolling3);
			}
			// Fall (b) ein Paar
			else if ((rolling1 == rolling2 && rolling1 !=rolling3) || (rolling1 == rolling3 && rolling1 != rolling2) || (rolling2 == rolling3 && rolling2 != rolling1)) {
				Console.WriteLine ("\nPlayer A rolls a pair, nice one");
				resultA = 2;
				Console.WriteLine(sumA = rolling1 + rolling2 + rolling3);
			}
			// Fall (d) ein Triple
			else if (rolling1 == rolling2 && rolling1 == rolling3 && rolling2 == rolling3) {

				Console.WriteLine ("\nPlayer A rolls a triple... wohooo");
				resultA = 3;
				Console.WriteLine(sumA = rolling1 + rolling2 + rolling3);
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
				Console.WriteLine ("\nPlayer B  has three different eyes");
				resultB = 1;
				Console.WriteLine(sumB = rolling1 + rolling2 + rolling3);
				Console.WriteLine ("\n\n");

			}
			// Fall (b) ein Paar
			else if ((rolling1 == rolling2 && rolling1 !=rolling3) || (rolling1 == rolling3 && rolling1 != rolling2) || (rolling2 == rolling3 && rolling2 != rolling1)) {
				Console.WriteLine ("\nPlayer B rolls a pair, nice one");
				resultB = 2;
				Console.WriteLine(sumB = rolling1 + rolling2 + rolling3);
				Console.WriteLine ("\n\n");

			}
			// Fall (d) ein Triple
			else if (rolling1 == rolling2 && rolling1 == rolling3 && rolling2 == rolling3) {
				Console.WriteLine ("\nPlayer B rolls a triple... wtf");
				resultB = 3;
				Console.WriteLine(sumB = rolling1 + rolling2 + rolling3);
				Console.WriteLine ("\n\n");

			} 
			return resultB;
		} // Ende PlayerB
	}
}
