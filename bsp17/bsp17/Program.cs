/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp17
 * */

using System;

namespace bsp17
{
	class MainClass  // TODO Ergebnisse stimmen nicht, letzte zahl wird nicht angezeigt!
	{

		/* 17. (2P) Schreibe eine Methode printPrimeFactors, die zu einer eingegebenen Zahl die Zerlegung in Primfaktoren ausgibt.
				Beispiel: 60 hat die Primfaktorzerlegung 2*2*3*5.
				Tipp: Zur Lösung der Aufgabe soll das Programm die ganzen Zahlen t ≥ 2 in aufsteigender Reihenfolge betrachten. 
				Wenn t echter Teiler von n ist, gib t aus und vermindere n durch entsprechende Division. Andernfalls mache mit dem nächsten t weiter.
				Verwende die Methode ohne Rückgabewert, aber mit der zu zerlegenden Zahl als Parameter. Die Methode gibt die Zerlegung aus. 
				In Main soll die Zahl eingelesen und die Methode aufgerufen werden.
		*/


		public static void Main (string[] args)
		{

			// call userInput and printPrimeFactor
			Console.WriteLine( "type in a number an the programm gives back all\nprimenumbers existing in your number");
			int userNum = int.Parse (Console.ReadLine ());
			printPrimeFactor (userNum);
		}

		public static void printPrimeFactor (int userNum) 
		{
			for (int counter = 2; counter < userNum;) 
			{
				if (userNum >= 2) 
				{
					if (userNum % counter == 0) 
					{
						userNum = userNum / counter;
						Console.Write (counter + " * ");
					} 
					else 
					{
						counter ++;
					}
				} 

			}

	}
}
}
