/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp21
 * */

using System;

namespace bsp21
{
	class MainClass
	
		/* 21.(2P) Erweitere das Zahlenratespiel aus dem vorigen Übungsblatt dahingehend, dass der Spieler... 
			  * • ... die obere Grenze des Ratebereichs am Beginn wählen kann
				• ... eine maximale Anzahl an Rateversuchen eingeben kann
				• ... nicht mehr Rateversuche eingeben kann, als es verschiedene Zahlen zu raten gibt
				• ... bei jedem Rateversuch informiert wird, der wievielte Rateversuch gerade kommt
				• ... ungültige Eingaben immer wiederholen muss, sie aber nicht als Rateversuch gezählt werden
				• ... nach jedem Rateversuch informiert wird, wieviele Rateversuche noch zur Verfü̈gung stehen
				• ... vor dem letzten Rateversuch zusa ̈tzlich hingewiesen wird, dass es nun tatsächlich der letzte Rateversuch ist
				• ... nach dem letzten fehler haften Rateversuch eine Meldung kommt, dass das Spiel vorüber ist, und was die richtige Zahl gewesen wa ̈re
				• ... bei Erfolg das Raten beendet wird, und eine Gewinnmeldung kommt
				• ... bei Erfolg im allerletzten Rateversuch zusätzlich eine Meldung Das war knapp! oder dergleichen ausgegeben wird
				• ... am Ende jeweils das gesamte Spiel wiederholen kann (mit neuer Konfiguration) oder beenden
				• ... am Ende des Programms eine Statistik ausgegeben wird, wie viele Spiele gewonnen, wie viele verloren wurden	
				*/
	{
		public static void Main (string[] args)
		{


						// create the random number
						Random num = new Random ();
						int randomNum = (num. Next(1,1001));

						// tell the user
						Console.WriteLine ("We play a little game! The program gives you a random number between 1 - 1000.\n" +
						                   "You have to guess the number until you get a hit! Good luck .. ");

						// loop and counter
						int counter = 1; 
						int uNumber = 0;
						while (uNumber != randomNum) {

							// user input
							String userNum = Console.ReadLine ();
							int uNum = int.Parse (userNum);

							if (uNum > 1000 && uNum < 1) {
								Console.WriteLine ("your number has to be between 1 - 1000");
								userNum = Console.ReadLine ();
								uNum = int.Parse (userNum);

							} else if (uNum < randomNum && uNum > 0) {
								Console.WriteLine ("your guess is to low! Try again.");
								counter++;

							} else if (uNum > randomNum && uNum < 1001) {
								Console.WriteLine ("Your guess is to high! Try again.");
								counter++;

							} else if (uNum == randomNum) {
								Console.WriteLine ("you WIN! You needed " + counter.ToString () + " tries");

							} else if (uNum < 0) {
								Console.WriteLine ("your number has to be between 1 - 1000");

							} else if (uNum > 1000) {
								Console.WriteLine ("your number has to be between 1 - 1000");
							}

						}
					}
				}
			}

