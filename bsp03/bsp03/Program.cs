/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueoo bsp03
 * */

using System;

namespace bsp03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 3. (2P) Schreibe ein Programm, das eine Anzahl von Stunden, Minuten und Sekunden einliest, und die Gesamtanzahl an Sekunden ausgibt.
			 * Danach soll das Programm eine Gesamtanzahl von Sekunden einlesen, und daraus Stunden, Minuten und die restlichen Sekunden berechnen und ausgeben.
			 */

			// Usereingabe von Stunden
			Console.WriteLine ("Bitte geben Sie eine Anzahl von Stunden an:");
			String userHours = Console.ReadLine ();
			Console.WriteLine ("Bitte geben Sie eine Anzahl von Minuten an:");
			String userMinutes = Console.ReadLine ();
			Console.WriteLine ("Bitte geben Sie eine Anzahl von Sekunden an:");
			String userSeconds = Console.ReadLine ();

			double hours = double.Parse (userHours);
			double minutes = double.Parse (userMinutes);
			double seconds = double.Parse (userSeconds);

			// Umrechnen in Sekunden
			hours = hours * 3600;
			minutes = minutes * 60;

			double sumSeconds = hours + minutes + seconds;
			
			Console.WriteLine("Ihre Eingabe ergibt " + sumSeconds + " Sekunden.");

			// Usereingabe von Sekunden
			Console.WriteLine ("Bitte geben Sie eine Anzahl von Sekunden an:");
			String userSec = Console.ReadLine ();

			double sec = double.Parse (userSec);

			// Umrechnen in Stunden
			double restH = sec % 3600; 
			double h = (sec - restH) / 3600; 


			// Umrechnen in Minuten
			double restM = restH % 60; 
			double m = (restH - restM) / 60; 


			// Restliche Sekunden
			double s = restM;

			Console.WriteLine ("Ihre Eingabe ergibt " + h + " Stunden, " + m + " Minuten und " + s + " Sekunden.");

		}
	}
}
