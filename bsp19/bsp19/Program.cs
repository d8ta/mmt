using System;

namespace bsp18
{
	class MainClass
	{

		/*	(2) Schreibe ein Programm, das mithilfe einer selbstgeschriebenen Schleife (nicht mithilfe einer C#- Funktion) eine Potenz mit beliebiger Basis und ganzzahligem Exponenten ausgeben kann: also an, fu ̈r beliebiges a und ganzzahliges n. Basis und Exponent werden vom Benutzer eingegeben.
			•BenutzezurBerechnung1eineFunktionpotenzmitentsprechendenParameternundRu ̈ckgabewert. • ZurWiederholung:fu ̈reineZahlan ista·a·a·...·a,wobeidasan-MalalsFaktorauftritt(n≥1). • Fu ̈r n < 0 ist der Kehrwert zu bilden (a−n = 1/an).
			• Achtung: a0 = 1!!!
		*/



		// Main function
		public static void Main (string[] args)
		{

			Console.WriteLine ( potenz (2 , 10) ) ;

		} 
		// end of Main


		// function potenz
		public static double potenz ( double basis, double exponent ) {

			double result = 1;

			for ( double i = 0; i < exponent ; i ++ ) {

				result = result * basis; 

			} 
			return result;
		}   

	}
}
