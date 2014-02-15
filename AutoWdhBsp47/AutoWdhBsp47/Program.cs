using System;

namespace AutoWdhBsp47
{
	class Auto
	{
		public string marke;
		public string farbe;
		public uint tankvolumen;
		public uint tankinhalt;
		public double kmStand;
		public uint verbrauch;
		public bool kaputt;

		// default Konstruktor
		public Auto()
		{
			marke = null;
			farbe = null;
			tankvolumen = 0;
			tankinhalt = 0;
			kmStand = 0;
			verbrauch = 0;
			kaputt = false;
		}

		// "this" Konstruktor
		public Auto (string marke, string farbe, uint tankvolumen, uint tankinhalt, double kmStand, uint verbrauch, bool kaputt)
		{
			this.marke = marke;
			this.farbe = farbe;
			this.tankvolumen = tankvolumen;
			this.tankinhalt = tankinhalt;
			this.kmStand = kmStand;
			this.verbrauch = verbrauch;
			this.kaputt = kaputt;
		}

		// Tankmethode
		public void tanken (uint liter)
		{
			tankinhalt += liter;
			if (tankinhalt > tankvolumen) {
				tankinhalt = tankvolumen;
				Console.WriteLine ("Der Tankvorgang wurde unterbrochen, da ihr Tank voll ist!");
			}
		}
		// Fahrmethode
		public void fahren (double km)
		{
			kmStand += km;
			if ((km * (this.verbrauch / 100)) > this.tankinhalt) {
				Console.WriteLine ("\nIhr Tank ist leer\n");
				kaputt = true;
			} else {
				kaputt = false;
			}
		}

		// Printmethode
		public void print()
		{
			Console.WriteLine ("Marke: " + marke);
			Console.WriteLine ("Farbe: " + farbe);
			Console.WriteLine ("Tankvolumen: " + tankvolumen);
			Console.WriteLine ("Tankinhalt: " + tankinhalt);
			Console.WriteLine ("Kilometerstand: " + kmStand);
			Console.WriteLine ("Verbrauch auf 100Km: " + verbrauch);
			Console.WriteLine ("Beschädigt: " + kaputt);
			Console.WriteLine ("\n-------------------------------\n");
		}
	}


	class Programm
	{
		public static void Main ()
		{
			Auto Golf = new Auto ("Volkswagen", "Schwarz", 80, 30, 990000, 7, false);
			Auto Swift = new Auto ("Suzuki", "Schwarz", 60, 10, 34000, 6, false);
			Swift.print ();
			Swift.tanken (20);
			Swift.fahren (5000);
			Swift.print ();
			Golf.print ();
		}
	}
}
