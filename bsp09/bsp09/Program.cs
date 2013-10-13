/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp09
 * */

using System;

namespace bsp09
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 9. (1P) Schreibe ein Programm, das jeweils mit einer for-Schleife: a) die ASCII-Tabelle ausgibt (alle Zeichen mit ASCII-Kodierung 0 bis 255), 
			 * b) alle Kleinbuchstaben, und c) alle Großbuchstaben, d) alle Ziffern ausgibt.
			 */

			int counter;
			int minimum = 0;
			int maximum = 255;

			// a) for loop to go through the numbers and print it as ASCII
			Console.WriteLine ("\n \n all ASCII letters are: ");
			for (counter = minimum; counter <= maximum; counter ++) {
				char symbol = (char)counter;
				Console.WriteLine (counter.ToString() + " : " + symbol.ToString ());
			}

			// b) lowercase letters
			Console.WriteLine ("\n \n all lowercase letters are: ");
			for (counter = 97; counter <= 122; counter ++) {
				char symbol = (char)counter;
				Console.WriteLine (symbol.ToString ());
			}
		
			// c) uppercase letters
			Console.WriteLine ("\n \n all uppercase letters are: ");
			for (counter = 65; counter <= 90; counter ++) {
				char symbol = (char)counter;
				Console.WriteLine (symbol.ToString ());
				}

			// d) numbers
			Console.WriteLine ("\n \n all numbers are: ");
			for (counter = 48; counter <= 57; counter ++) {
				char symbol = (char)counter;
				Console.WriteLine (symbol.ToString ());
				}
		}
	}
}
