/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo4 bsp25
 * */

using System;

namespace bsp25
{
	/* 25.(4P) Schreibe ein Programm mit einer Methode, die eine Sanduhr 5n-mal nebeneinander ausgibt;
				 * also für n = 3 (Anzahl der Sanduhren) und b = 5 (Breite einer Sanduhr)
				 */
	class MainClass
	{
		// function main
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type in n and b.\n" +
			"n is the amoung of hourglasses and b is the width of each hourglass:\n\n" +
			"Start with b (width of hourglass):");
			int b = checkUserInput (1, int.MaxValue);

			Console.WriteLine ("Now type in b (amount of printed hourglasses):");
			int n = checkUserInput (1, int.MaxValue);

			hourglass (b, n);

		}
		// end of main
		// function checkUserInput
		static int checkUserInput (int min, int max)
		{
			bool inputIsOk;
			int userInput;

			do {
				inputIsOk = int.TryParse (Console.ReadLine (), out userInput);

				if ((inputIsOk == true) && (userInput >= min) && (userInput <= max))
					inputIsOk = true;
				else {
					inputIsOk = false;
					Console.WriteLine ("This value is invalid!");
				}
			} while (inputIsOk == false);
			return userInput;
		}
		// end of function
		// start of function hourglas
		static void hourglass (int b, int n)
		{
			// part 1
			for (int lineCounter = b; lineCounter > 0; lineCounter--) { // zählt die Linien ab z.b. 4 Lines
				for (int hgCounter = 1; hgCounter <= n; hgCounter++) {		// zählt wieviele Hourglas dargestellt werden sollen
					for (int counter = 1; counter <= (b - lineCounter); counter++) {
						Console.Write (" ");				// setzt einen Teil der symbolplätze auf " "
					}
					for (int starCounter = 0; starCounter <= (lineCounter * 2 - 1); starCounter++) { // fügt die sterne ein
						if (starCounter % 2 == 0) {			// sorgt für einen Abstand Platz zwischen den Sternen
							Console.Write ("*");		// gerade zeilen kriegen den stern
						} else {
							Console.Write (" ");		// ungerade eine leerzeile
						}
					}
					for (int space = 1; space <= (b - lineCounter); space++) {
						Console.Write (" ");	
					}
				}
				Console.Write ("\n");
			}

			// part 2
			for (int lineCounter = 2; lineCounter <= b; lineCounter++) {
				for (int hgCounter = 1; hgCounter <= n; hgCounter++) {
					for (int space = 1; space <= (b - lineCounter); space++) {
						Console.Write (" ");
					}
					for (int starCounter = 0; starCounter <= (lineCounter * 2 - 1); starCounter++) {
						if (starCounter % 2 == 0) {
							Console.Write ("*");
						} else {
							Console.Write (" ");
						}
					}
					for (int space = 1; space <= (b - lineCounter); space++) {
						Console.Write (" ");
					}
				}
				Console.Write ("\n");
			}

		}
		//end of function
	}
}


