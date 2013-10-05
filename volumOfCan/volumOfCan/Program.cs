using System;

namespace volumOfCan
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Schreibe ein Programm, das die Fullmenge eines liegenden Kreiszylinders berechnet (Formel, siehe Wikipedia).
			 * Eingabe: L (Länge), r (Radius), h (Fullhohe). Teste das Programm mit den Werten einer Limonaden-,
			 * Energy-Drink-, Bierdose, etc. Protokolliere deine Tests, indem du die Konsolenausgabe als Kommentar im Quellcode speicherst.
			 * Verwende großzugig Hilfsvariablen fur Zwischenergebnisse, um dieU bersicht zu bewahren.
			 */ 

			// Variables for length, radius and filling height
			double length = 1 ;
			double radius = 1 ;
			double fillingHeight = 1 ;

			// Calculation for the can with the following formula: 
			// V = r^2 * L (arccos (r-h / r) - (r-h) wurzel 2rh-h^2 / r^2)
			double root = Math.Sqrt (((2 * radius * fillingHeight) - (fillingHeight * fillingHeight)) / (radius * radius));

			double volume = (radius * radius * length) * (Math.Acos((radius - fillingHeight) / radius) - (radius - fillingHeight) * root);

			// print the volume to the console
			Console.WriteLine("Volume of the can: " + volume);
		}
	}
}
