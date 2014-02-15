/* 1310601027, fhs36118
 * Daniel Raudschus
 * ue08 bsp45
 * */

using System;

// 45. Implementiere eine Klasse Sparbuch 
class Konto
{
	private decimal kontostand;

	// Hebt betrag in Euro ab und liefert true, sofern dies möglich ist. Ansonsten wird false zurück gegeben und nichts abgehoben.
	public bool abheben (decimal betrag)
	{
		if (kontostand < betrag) {
			return false;
		}
		kontostand = kontostand - betrag;
		return true;
	}
	// Zahlt betrag Euro in das Sparbuch ein.
	public void einzahlen (decimal betrag)
	{
		kontostand = kontostand + betrag;
	}
	// Printen des Kontostandes
	public void printKontostand()
	{
		Console.WriteLine("Der Kontostand beträgt: " + kontostand);
	}
	// Soll das Sparbuch mit start vielen Euro erzeugen (default 0.0)
	public void Sparbuch (decimal start)
	{
		kontostand = start;
	}
};

class KontoTest
{
	// Erzeuge in Main() zwei verschiedene Sparbücher und teste die Funktionalität.
	public static void Main()
	{
		Konto DanielsKonto;
		DanielsKonto = new Konto();
		DanielsKonto.Sparbuch (0);
		DanielsKonto.einzahlen (210);
		DanielsKonto.abheben (10);
		DanielsKonto.printKontostand();


		Konto AnnesKonto;
		AnnesKonto = new Konto();
		AnnesKonto.Sparbuch (1000);
		AnnesKonto.einzahlen (1000);
		AnnesKonto.abheben (3000);
		AnnesKonto.printKontostand();
	}
};
// Ende Aufgabe 45
