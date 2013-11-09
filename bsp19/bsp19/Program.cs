/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp19
 * */

using System;

namespace bsp19
{
	class MainClass
	{

		/*	(2) Schreibe ein Programm, das mithilfe einer selbstgeschriebenen Schleife (nicht mithilfe einer C#- Funktion) eine Potenz 
		 * 	mit beliebiger Basis und ganzzahligem Exponenten ausgeben kann: also an, für beliebiges a und ganzzahliges n. Basis und Exponent werden vom Benutzer eingegeben.
		 * 		•Benutze zur Berechnung eine Funktion potenz mit entsprechenden Parametern und Rückgabewert.
		 * 		• Zur Wiederholung: für eine Zahl a^n ist a·a·a·...·a, wobei das a n- Mal als Faktor auftritt (n≥1).
		 * 		• Für n < 0 ist der Kehrwert zu bilden (a−n = 1/an).
		 * 		• Achtung: a0 = 1!!!
		*/



		// Main function
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type in a Basis and a Exponent.\nThe programm will calculate the correct number for you\n");
			Console.WriteLine ("Basis:");
			double basis = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Exponent:");
			double exponent = double.Parse (Console.ReadLine ());

			double result = potenz (basis, exponent);
			Console.WriteLine (basis + "^" + exponent + " = " + result);
		} 
		// end of Main


		// function potenz
		public static double potenz ( double basis, double exponent ) {

			double result = 1;

			if (exponent < 0) {
			
				exponent = exponent * (-1);
				for (double i = 0; i < exponent; i ++) {

					result = result * basis; 

				} 	result = 1 / result; // kehrwert

			}
			else 
			{
				for ( double i = 0; i < exponent ; i ++ ) {

				result = result * basis; 
			
			} 
			
			} return result;
			// end of Main

	}


}
}

