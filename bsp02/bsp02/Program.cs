using System;

namespace bsp02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 2. (1P) Schreibe ein Programm, das die Seitenlä̈nge und Höhe (in cm, als Fließkommazahl) 
			 * einer Pyramide mit quadratischer Grundflä̈che einliest und danach das Volumen in Milliliter ausgibt.
			 * Benutze die forma- tierte Ausgabe (Kapitel 2) um genau 3 Nachkommastellen auszugeben.
			 * Verhindere die Eingabe negativer Werte!
			 */

			// Formel für Pyramide V = 1/3 * G * h

			// Usereingabe von Seitenlänge und Höhe
			Console.WriteLine ("Geben Sie die Seitenlänge ein:");
			String userLength = Console.ReadLine ();
			Console.WriteLine ("Gebein Sie die Höhe ein:");
			String userHeigth = Console.ReadLine ();

			// String in Fließkommanummer umwandeln
			float length = float.Parse(userLength);
			float heigth = float.Parse (userHeigth);

		}
	}
}
