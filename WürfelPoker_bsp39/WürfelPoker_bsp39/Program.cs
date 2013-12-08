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
			//PokerRound ();
			RollingPlayerA ();

		} // Ende Main



		// Zufallswürfel Generator
		static int RandomGenerator (int min, int max)
		{
			Random random = new Random ((int)DateTime.Now.Ticks);
			return random.Next (min, max);
		} // Ende


		// Spielrunde
		//static int PokerRound (int SumA, int SumB)
		//{

		//}

		// PlayerA Rolling
		static void RollingPlayerA ()
		{
			int sumA;
			Console.WriteLine ("Player A is rolling the dice 3x\n" +
				"the results is :");
			int rolling1 = RandomGenerator (1, 6);
			int rolling2 = RandomGenerator (1, 6);			
			int rolling3 = RandomGenerator (1, 6);

			// Fall (a) drei verschiedene Augenzahlen
			if (rolling1 != rolling2 && rolling1 != rolling3 && rolling2 != rolling3) {
				// Ruft Funkt. auf die, bei 3 verschiedenen Werten je Spieler dem mit der hörheren Summe einen Pkt. gibt
				//SumOfThreeDiff ();
				Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\ndifferent cards");

			}

			// Fall (b) ein Paar
			else if ((rolling1 == rolling2 && rolling1 !=rolling3) || (rolling1 == rolling3 && rolling1 != rolling2) || (rolling2 == rolling3 && rolling2 != rolling1)) {
				// Ruft Funktion auf die Prüft welcher Spieler ein Pair hat und gibt diesem dann einen Pkt.
				//Pairs (); // Fall (c)
				Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a pair");

			}

			// Fall (d) ein Triple
			else if (rolling1 == rolling2 && rolling1 == rolling3 && rolling2 == rolling3) {
				// Ruft Funktion auf die Prüft welcher Spieler ein Triple hat und gibt diesem dann einen Pkt.
				//Triples (); // Fall (e)
				Console.WriteLine (rolling1);
				Console.WriteLine (rolling2);
				Console.WriteLine (rolling3);
				Console.WriteLine ("\n a triple");
			}

			// Fehler
			else 
			{
				Console.WriteLine ("Something went wrong!");
			}
		}
	}
}
