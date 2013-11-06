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

			for (int counter = 0; counter <= 100; counter ++) 
			{ 

				int resultNum = ( generatePrime (counter) );
				if (isPrime (generatePrime(counter))) 
				{
					Console.WriteLine("p(" + counter + ") = " + resultNum + " is prime!");
				} 
				else
				{
					Console.WriteLine("p(" + counter + ") = " + resultNum + " is not prime!");
				}

			}

		} // end of main




		// write the generatePrime()function
		public static int generatePrime( int num )
		{
			int genNum = (((num * num) + num) + 41);
			return genNum;

		} // end of function




		// implement isPrime function to check the formular
		public static bool isPrime( int eNum )
		{
			for (int counter = 2; counter < eNum; counter ++) 
			{
				if (eNum % counter == 0) 
				{
					return false;
				}
			}

			return true; 
		} // end of function



	}
}
