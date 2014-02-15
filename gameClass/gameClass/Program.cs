using System;


// Klasse Spiel erstellen
class Spiel
{
	public SpielStatus status;
	public string name;
	public double preis;
	public bool adult;

	// Konstruktor
	public Spiel (SpielStatus status, string name, double preis, bool adult)
	{
		this.status = status;
		this.name = name;
		this.preis = preis;
		this.adult = adult;
	}

	// Alle Spiele Printen
	public void printGames()
	{
		Console.WriteLine("Status: " + this.status);
		Console.WriteLine("Name: " + this.name);
		Console.WriteLine("Preis: " + this.preis);
		Console.WriteLine("ab 18: " + this.adult);
		Console.WriteLine("##########################");

	}
}

enum SpielStatus
{
	verliehen,
	verkauft,
	beschädigt,	bestellt,
	verboten,
}


class Videothek
{

	// Main
	public static void Main()
	{
		Spiel Eins = new Spiel (SpielStatus.verboten, "Doom 3", 49.95, true);
		Spiel Zwei = new Spiel (SpielStatus.verliehen ,"Guild Wars 2", 23.99, false);


		Eins.printGames ();
		Zwei.printGames ();
	}
}