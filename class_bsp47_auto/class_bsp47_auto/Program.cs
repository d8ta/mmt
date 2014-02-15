/* 1310601027, fhs36118
 * Daniel Raudschus
 * ue08 bsp47
 * */

using System;

// 47. Implementiere eine Klasse Auto 
class Auto
{
	public string marke;
	public string farbe;
	public double tankvolumen;
	public double tankinhalt;
	public double kmStand;
	public double verbrauch; // pro 100 Km
	public bool kaputt;

	// Method für tanken anlegen (Volumen darf nicht überschritten werden)
	public void tanken(double liter)
	{
		if (this.tankvolumen < (this.tankinhalt + liter)) {
			this.tankinhalt = this.tankvolumen;
			Console.WriteLine ("Der Tank ist mit " + tankvolumen + " Litern gefüllt. Sie können nicht mehr tanken");
		} else {
			this.tankinhalt += liter;
		}
	}
	// Methode für fahren anlegen (Darf nur so gross sein wie mit Tankinhalt mgl.)
	public void fahren(double kilometer)
	{
		kmStand += kilometer;
		if (kilometer * (this.verbrauch / 100) > this.tankinhalt) {
			Console.WriteLine ("Sie haben Ihren Tank leer gefahren");
			this.tankinhalt = 0;
			this.kaputt = true;
		}
	}

	// Methode zum Zeigen des aktuellen Status aller Variablen
	public void printInfo()
	{
		Console.WriteLine("Marke: " + this.marke);
		Console.WriteLine("Farbe: " + this.farbe);
		Console.WriteLine("Tankvolumen: " + this.tankvolumen);
		Console.WriteLine("Tankinhalt: " + this.tankinhalt);
		Console.WriteLine("KM Stand: " + this.kmStand);
		Console.WriteLine("Verbrauch auf 100 Km: " + this.verbrauch);
		Console.WriteLine("Fahruntüchtig?: " + this.kaputt);
		Console.WriteLine (" --- ENDE ---\n");
	}
};



	class KlasseAuto
{
	static void Main()
	{
		Auto Golf;
		Golf = new Auto();
		Golf.marke = "Volkswagen";
		Golf.farbe = "Schwarz";
		Golf.tankvolumen = 45;
		Golf.tankinhalt = 0;
		Golf.kmStand = 100000;
		Golf.verbrauch = 7.5;
		Golf.kaputt = false; 

		Golf.tanken (55);
		Golf.fahren (29);
		Golf.printInfo ();


		Auto Swift;
		Swift = new Auto();
		Swift.marke = "Suzuki";
		Swift.farbe = "Schwarz";
		Swift.tankvolumen = 40;
		Swift.tankinhalt = 33;
		Swift.kmStand = 2000;
		Swift.verbrauch = 6.75;
		Swift.kaputt = false; 

		Swift.fahren (300);
		Swift.tanken (30);
		Swift.printInfo ();
	}
};
// Ende Aufgabe 47
