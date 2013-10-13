using System;

namespace bsp02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 2. (1P) Schreibe ein Programm, das die Seitenlä̈nge a und Höhe h (in cm, als Fließkommazahl) 
			 * einer Pyramide mit quadratischer Grundflä̈che einliest und danach das Volumen in Milliliter ausgibt.
			 * Benutze die forma- tierte Ausgabe (Kapitel 2) um genau 3 Nachkommastellen auszugeben.
			 * Verhindere die Eingabe negativer Werte!
			 */

			// Usereingabe von Seitenlänge und Höhe
			Console.WriteLine ("Geben Sie die Seitenlänge in cm ein:");
			String userLength = Console.ReadLine ();
			Console.WriteLine ("Gebein Sie die Höhe in cm ein:");
			String userHeigth = Console.ReadLine ();

			// String in Fließkommanummer umwandeln
			float length = float.Parse(userLength);
			float heigth = float.Parse (userHeigth);

			// Länge zum Quadrad & 1/3 als Kommazahl
			float einDrittel = 1/3f;
			float grundfläche = (length * length);

			/* Anwenden der Pyramidenformel im Code
			 * Formel für Pyramide V = 1/3 * G * h
			 */ 
			float volume = einDrittel * grundfläche * heigth;

			//  Ausgabe der Fliesskommazahl
			Console.WriteLine ("Die Pyramide hat ein Volumen von " + volume + " cm.");

		}
	}
}
