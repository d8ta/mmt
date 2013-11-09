using System;

namespace bsp24
{

	/*	24. (2P)Schreibe ein Programm, das mithilfe einer Methode printChessboard ein Schachbrettmuster aus gibt, wobei die 
	 	weißen Felder mit O und die schwarzen Felder mit X kodiert sein sollen. Die Größe des Schachbretts soll durch Eingabe einer geraden Ganzzahl 
	 	(= Parameter der Methode) konfigurierbar sein. Für Grö̈ße 4 ergibt sich z.B.:
	 	
      			OXOX
      			XOXO
      			OXOX
      			XOXO

		Erweitere nun die Methode, so dass außer der Anzahl der Zeilen noch die beiden Symbole als Parameter Übergeben bekommt.
		Der Benutzer soll sich in Main die Symbole per Kommandozeileneingabe aussuchen können.
	*/


	class MainClass
	{
		// start Main
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type in a number and the program will show\n" +
				"your a chessboard graphic with your number^2\n");
			int userInput = int.Parse (Console.ReadLine ());

			Console.WriteLine ("Now choose your symbols you want to see in the graphic\n" +
				"(for example symbol X and symbol O...)\n" +
				"First Symbol:");
			string symbol_O = (Console.ReadLine ());
			Console.WriteLine ("Second Symbol:");
			string symbol_X = (Console.ReadLine ());

			printChessboard(userInput, symbol_O, symbol_X);
		}
		// end Main




		// start function
		public static void printChessboard (int userNum, string symbol_O, string symbol_X)
		{
			// print lines (amount of userNum)
			for (int counter = 0; counter < userNum; counter ++) {
				Console.WriteLine ();

				// print symbols (amount of userNum)
				for (int symbolCounter = 0; symbolCounter < userNum; symbolCounter ++) {
					// if line non-even  
					if (symbolCounter % 2 != 0) {
						// set non-even counternumbers = X
						if (counter % 2 != 0) {
							Console.Write (symbol_O);
						} else {
							Console.Write (symbol_X);
						}
					} 
					// if line is even set even counternumbers = O
					else 
					{
						// set non-even counternumbers = O
						if (counter % 2 != 0) {
							Console.Write (symbol_X);
						} else {
							Console.Write (symbol_O);
						}
					}
				}
			}
		}
		// end of function

	}
}
