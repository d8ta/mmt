/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp13
 * */

using System;

namespace bsp13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 13. (2P) Programmiere folgendes Spiel: das Programm würfelt eine (ganze) Zahl zwischen 1und 1000, die der Spieler nicht wissen darf.
			 * Er soll sie nun erraten, indem er ü̈ber die Konsole nach und nach Versuche ab gibt. Das Programm antwortet ihm dabei nur Die gesuchte Zahl ist kleiner! oder
			 * Die gesuchte Zahl ist größer! Das Spiel ist beendet nachdem der Spieler die Zahl erraten hat, wonach das Programm TREFFER! ausgeben soll.
			 * Zusätzlich soll das Programm ausgeben wieviele Rateversuche Spieler B gebraucht hat.
			 * Fü̈r eine Zufallszahl muss zuerst ein Zufallsgenerator erzeugt werden (Random r = new Random(); und danach davon eine Zufalls zahl erzeugt werden (r.Next(a, b);),
			 * wobei eine ganze Zahl zwischen a (inklusive) und b (exklusive!) erzeugt wird. Gibt der Benutzer einen Wert kleiner als 1 oder größer als 1000 ein, 
			 * soll er auf seinen Fehler aufmerksam gemacht werden, und eine neue Eingabe eingefordert werden. Ein solcher ungülter Eingabeversuch soll nicht als Rateversuch 
			 * gezählt werden.
			 */

			// create random number
			Random num = new Random ();
			int randomNum = (num. Next(1,1001));

			// say hello and explain
			Console.WriteLine ("We play a little game! The program gives you a random number between 1 - 1000.\n" +
			                   "You have to guess the number until you get a hit! Good luck .. ");

			// loop and counter the loop
			int counter = 0;
			int uNumber = 0;
			while (uNumber != randomNum) {

				// user input
				String userNum = Console.ReadLine ();
				int uNum = int.Parse (userNum);


				if (uNum >= 1000 && uNum <= 1) {
					Console.WriteLine ("your number has to be between 1 - 1000");
					userNum = Console.ReadLine ();
					uNum = int.Parse (userNum);
				} else {
			
					// if usernumber is a hit
					if (uNum == randomNum) {
						Console.WriteLine ("you WIN! You needed " + counter.ToString() + " tries");
						break;
					} else if (uNum < randomNum) {
						Console.WriteLine ("your guess is to low! Try again.");
						counter++;
					} else if (uNum > randomNum) {
						Console.WriteLine ("Your guess is to high! Try again.");
						counter++;
					}
			
				}ölkölkölklö
			}
		}
	}
}
