/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp15
 */ 

using System;

namespace bsp15
{

	/* 15. (1P) Eine Formel zur Generierung von Primzahlen ist Eulers Primzahlformel:

									p(x) = x2 + x + 41 
									
					Implementiere diese Funktion als generatePrime() mit entsprechendem Rückgabewert.
					überprüfe anschließend die Behauptung, dass die oben angegebene Formel für x = 0,1,2... Primzahlen liefert,
					empirisch für alle x:0 ≤ x < 100 steht. Nutze dazu die isPrime() Funktion.
					Gib dabei für jedes x aus, ob p(x) prim oder nicht prim ist:

					p(0) = 41 ist prim.
					p(1) = 43 ist prim.
					...
					p(65) = 4331 ist nicht prim.
					...
	*/



	class MainClass
	{
		public static void Main (string[] args)
		{
				isPrime ( generatePrime(2) );	

		}


		// write the generatePrime()function
		public static int generatePrime( int genNum )
		{
			genNum = (((genNum * genNum) + genNum) + 41);
			Console.Write ("P(" + ")" + " = " + genNum);
			return genNum;
		} 


		// implement isPrime function to check the formular
		public static bool isPrime( int eNum )
		{
			for ( int counter = 1; counter < 100; counter ++ ) 
			{
				if (eNum % counter == 0) {
					Console.WriteLine ( " is Prime!" );
					return false;
				} else {
					Console.WriteLine( " is not Prime" );
				}
			}

			return true; 
		}

		// TODO for loop inside the Main!

	}
}
