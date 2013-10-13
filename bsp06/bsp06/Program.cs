/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo1 bsp06
 * */

using System;

namespace bsp06
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 6. (2P) Schreibe auf Basis der vorigen Nummer ein Programm, welches eine natürliche Zahl korrekt auf einen gewissen Stellenwert runden kann,
			 * zB die Zahl 75894 wäre auf 10er gerundet 75890, auf 100er gerundet 75900, auf 1000er gerundet 76000, und auf 10000er gerundet 80000. 
			 * Das Programm soll zuerst vom Benutzer die Zahl, danach den gewünschten Stellenwert abfragen, und das Ergebnis ausgeben.
			 */

			// Usereingabe
			Console.WriteLine ("Bitte geben sie eine natürliche Zahl ein, das Programm wird diese korrekt runden:");
			String userNumber = Console.ReadLine ();
			double num = double.Parse (userNumber);

			Console.WriteLine ("Auf welche Stelle soll gerundet werden? Geben Sie 10 für runden auf 10er Stelle an. Für runden auf 100er Stelle geben Sie 100 an." +
				"Um auf die 1000er Stelle zu runden geben Sie bitte 1000 ein.:");
			String userIndex = Console.ReadLine ();
			int index = int.Parse (userIndex);

			// Rundungsoperation für Eingabe
			double roundDec = num / index;

			// Addieren von 0,5 und umwandeln in Int um Rundungsergebnis zu erhalten
			roundDec = roundDec + 0.5;
			int roundNum;
			roundNum = (int)roundDec;

			// write the rounded number to the console
			roundNum = roundNum * index;
			Console.WriteLine ("Auf die " + index+ "er Stelle gerundet ergibt sich " + roundNum);
		}
	}
}
