/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueoo bsp05
 * */

using System;

namespace bsp05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 5. (2P) Schreibe ein Programm, das eine Dezimalzahl einliest, sie korrekt auf- bzw. abrundet, und das Ergebnis ausgibt.
			 * Bsp: 12,49 ergibt 12, die Zahl 12,5 ergibt 13.Benutze ausschließlich die arithmetischen Operatoren sowie die Typumwandlung
			 * von float bzw. double zu integer, aber NICHT Rundungsfunktionen von C#.
			 * Tipp: evtl. ist es vorteilhaft, 0.5 zur eingegebenen Zahl zu addieren.
			 */

			// Usereingabe
			Console.WriteLine ("Geben Sie eine Dezimalzahl z.B. 12,45 ein, um sie exakt auf eine ganze Zahl runden zu lassen.");
			String userNumber = Console.ReadLine ();
			float decimalNumber = float.Parse (userNumber);

			// Usernumber runden indem 0.5 addiert wird und das Ergebnis von float zu int durch Casting umgewandelt wird und dadurch die Dezimalstellen wegfallen.
			decimalNumber = decimalNumber + 0.5f;
			int roundNumber;
			roundNumber = (int)decimalNumber;

			Console.WriteLine ("Ihre Dezimalzahl hat den gerundeten Wert von " + roundNumber+  ".");

		}
	}
}
