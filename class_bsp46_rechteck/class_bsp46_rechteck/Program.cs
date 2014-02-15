/* 1310601027, fhs36118
 * Daniel Raudschus
 * ue08 bsp46
 * */

using System;

// 46. Implementiere eine Klasse Rechteck 
class Rechteck
{
	public double laenge;
	public double breite;

	public double flaeche()
	{
		double flaeche = laenge * breite;
		return flaeche;
	}


	public bool istGroesserAls(Rechteck r)
	{
		double flaeche1 = flaeche ();
		double flaeche2 = r.flaeche ();
		if (flaeche1 > flaeche2) {
			Console.WriteLine ("Das Erste Rechteck ist grösser");
			return false;
		} else if (flaeche1 == flaeche2) {
			Console.WriteLine ("Beide sind gleich gross!");
		} else {
			Console.WriteLine ("Das Zweite Rechteck ist grösser");
		}
		return true;
	}

};

class RechteckPrüfen
{
	static void Main()
	{
		Rechteck Erstes;
		Erstes = new Rechteck();
		Erstes.laenge = 2.3334;
		Erstes.breite = 453.63;

		Rechteck Zweites;
		Zweites = new Rechteck();
		Zweites.laenge = 44.34;
		Zweites.breite = 234.434;

		Erstes.istGroesserAls (Zweites);
	}
};
// Ende Aufgabe 46
