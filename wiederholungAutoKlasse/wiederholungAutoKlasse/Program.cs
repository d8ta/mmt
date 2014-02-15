using System;

class Auto
{
	public string marke;
	public string farbe;
	public double tankvolumen;
	public double tankinhalt;
	public double kmStand;
	public double verbrauch; // Liter pro 100km
	public bool kaputt;

	// Konstruktor für die Klasse Auto
	public Auto (string marke, string farbe, double tankvolumen, 
		double tankinhalt, double kmStand, double verbrauch, bool kaputt)
	{
		this.marke = marke;
		this.farbe = farbe;
		this.tankvolumen = tankvolumen;
		this.tankinhalt = tankinhalt;
		this.kmStand = kmStand;
		this.verbrauch = verbrauch;
		this.kaputt = kaputt;
	}

	// Methode um zu tanken
	public void tanken(double liter)
	{
		if (this.tankinhalt > tankvolumen) {
			Console.WriteLine("Es passen nicht mehr als " + this.tankvolumen + " Liter in ihren Tank");
		} else {
			this.tankinhalt += liter;
		}
	}

	// Methode um zu fahren
	public void fahren(double km)
	{
		// TODO: darf nur soviele fahren wie tankinhalt zulässt
		if (((this.tankinhalt / 100) * km) > this.tankinhalt) {
			this.kaputt = true;
			Console.WriteLine ("Tankanzeige : " + this.tankinhalt);
		} else {
			this.kmStand += km;
		}
	}

	// Print alle Infos über das jeweilige Fahrzeug in die Konsole
	public void printInfo()
	{
		Console.WriteLine ("Marke: " + this.marke);
		Console.WriteLine ("Farbe: " + this.farbe);
		Console.WriteLine ("Tankvolumen: " + this.tankvolumen);
		Console.WriteLine ("Tankfüllung: " + this.tankinhalt);
		Console.WriteLine ("Kilometerstand: " + this.kmStand);
		Console.WriteLine ("Verbrauch auf 100 Km: " + this.verbrauch);
		Console.WriteLine ("Beschädigungen? : " + this.kaputt);
	}
}


class AutoDemo
{
	public static void Main()
	{
		Auto Golf = new Auto ("VW", "Silber", 0, 0, 99000, 6.75, true);

		Golf.printInfo ();
	}
};


