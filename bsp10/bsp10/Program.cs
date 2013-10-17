/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp10
 * */

using System;

namespace bsp10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 10. (2P) Schreibe ein Programm, das einen Monat (Zahl von 1 bis 12) und Jahr (z.B. 2013) einliest und die Anzahl der Tage des Monats ausgibt.
			 * • Verwende ifs!
			 * • Das Programm muss auch mit Schaltjahren zurechtkommen.
			 * • Die Schlaltjahrregel muss korrekt angewendet werden (auch mit 100er und 400er Jahren)! (Siehe Wikipedia.)Teste gründlich!
			 */ 


			// userinput in month and year
			Console.WriteLine ("Please type in a month and a year and the programm gives you the amount of days in this month! " +
			"\n 1.) type in the month as a number (1-12): ");
			string userMonth = Console.ReadLine ();

			Console.WriteLine ("2.) type in the year: ");
			string userYear = Console.ReadLine ();

			int month = int.Parse (userMonth);
			int year = int.Parse (userYear);

			const int MONTH_THIRTY_ONE = 31;
			const int MONTH_THIRTY = 30;
			const int LEAP_FEB = 28; 

			//TODO if statement for month

			// if statement
			if (year % 4 == 0 || year % 100 != 0 || year % 400 == 0) {

				if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
					Console.WriteLine ("The " + month.ToString() + ". month in " + year.ToString() + " have " + MONTH_THIRTY_ONE.ToString() + " days.");
				} else if (month == 2) {
					Console.WriteLine ("The " + month.ToString() + ". month in " + year.ToString() + " have " + LEAP_FEB.ToString() + " days.");
				} else {
					Console.WriteLine ("The " + month.ToString() + ". month in " + year.ToString() + " have " + MONTH_THIRTY.ToString() + " days.");
				}

			} else {

				if (month == 1 || month == 3 || month == 5 || month ==7 || month == 8 || month == 10 || month == 12) {
					Console.WriteLine ("The " + month.ToString() + ". month in " + year.ToString() + " have " + MONTH_THIRTY_ONE.ToString() + " days.");
			} else {
					Console.WriteLine ("The " + month + ". month in " + year.ToString() + " have " + MONTH_THIRTY.ToString() + " days.");
				}
			}
		
		}
	}
}
