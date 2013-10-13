using System;

namespace neaterPrinting
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// INFO: Die WriteLine Funktion rundet !!!

			double i = 150 ;
			double f = 1234.56789 ;
			Console.WriteLine ( "i: {1:0} f: {0:0.00}", f, i ) ;

			// # meint: plaziere einen Digit, wenn verfügbar 
			Console.WriteLine ( "i: {0:#,##0} f: {1:##,##0.00}", i, f );


			// Zahlenausgabe als String
			Console.WriteLine("Aufgabe i = " + i.ToString("000000000.000000000"));

			Console.WriteLine ( "i: {0,5:0} f: {1,22:0.00}", i, f ) ;
			Console.WriteLine ( "i: {0,10:0} f: {1,1:###'.##}", 22, 123 ) ;


		}
	}
}
