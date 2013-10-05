using System;

namespace sumOfQuadrat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 	Berechne die Summe aller Quadratzahlen zwischen 0 und einer eingegebenen Zahl mit Hilfe einer
				while Schleife! Bei Eingabe von 100 also z.B. 1+4+9+16+...+100. Das Ergebnis soll am Ende ausgegeben werden.
				Achte auf die korrekte Handhabung wenn die Eingabe keine Quadratzahl ist 1
			*/

			// ask the user to type in a number
			Console.WriteLine ("give in a number:");
			String userNumber = Console.ReadLine ();
			double num = double.Parse (userNumber);

			int i = 0;

			// while loop operation
			while (i >= num)
				i ++;
			int allNum = i;
		}
	}
}
