/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueoo bsp04
 * */

using System;

namespace bsp04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			/* 4. (2P) Schreibe ein Programm, das einen beliebigen (ganzzahligen) Geldbetrag in 10er, 5er, und 1er Scheine/Munzen wechselt.
			 * Bedingung:es sollen möglichst viele große Einheiten verwendet werden.
			 */

			// Usereingabe
			Console.WriteLine ("Geben Sie einen ganzzahligen Geldbetrag ein:");
			String userMoney = Console.ReadLine ();
			int money = int.Parse (userMoney);

			// Usereingabe in 10er umwandeln und Rest feststellen
			int ten = money / 10;
			int restOfTen = money % 10;

			// Rest in 5er umwandeln und neuen Rest feststellen
			int five = restOfTen / 5;
			int one = restOfTen % 5;

			// 10er, 5er und 1er ausgeben
			Console.WriteLine("Ihr Geldbetrag beinhaltet " + ten + " Zehner, " + five + " Fünfer und " + one + " Einer.");
		}
	}
}
