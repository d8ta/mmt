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
			// TODO implement user input via terminal
			printChessboard(16);
		}
		// end Main




		// start function
		public static void printChessboard (int userNum)
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
							Console.Write ("O");
						} else {
							Console.Write ("X");
						}
					} 
					// if line is even set even counternumbers = O
					else 
					{
						// set non-even counternumbers = O
						if (counter % 2 != 0) {
							Console.Write ("X");
						} else {
							Console.Write ("O");
						}
					}
				}
			}
		}
		// end of function
	}
}
