using System;

namespace RechteckWdhBsp46
{
	class Rechteck
	{
		private uint laenge;
		private uint breite;

		// Konstruktor
		public Rechteck (uint laenge, uint breite)
		{
			this.laenge = laenge;
			this.breite = breite;
		}

		// Flächenberechnung
		public double flaeche()
		{
			uint flaeche = laenge * breite;
			return flaeche;
		}

		// Vergleichsmethode
		public bool istGroesserAls (Rechteck r)
		{
			if (this.flaeche() > r.flaeche()) {
				return true;
			} else {
				return false;
			}
		}

		// Printmethode
		public void print(Rechteck r)
		{
			if (this.istGroesserAls(r)) {
				Console.WriteLine ("Das erste Rechteck ist grösser");
			} else {
				Console.WriteLine ("Das erste Rechteck ist kleiner");
			}
		}
	}


	class Programma
	{
		public static void Main ()
		{
			try {
				Rechteck A = new Rechteck (2, 2);
				Rechteck B = new Rechteck (12, 32);
				A.print (B);
			} catch (Exception e) {
				Console.WriteLine ("There was a problem!", e);
			}

		}
	}
}
