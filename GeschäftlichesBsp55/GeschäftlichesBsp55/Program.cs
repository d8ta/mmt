using System;

class Article
{
	public uint artikelnummer;
	public string name;
	public double preis;

	public Article()
	{
		artikelnummer = 000;
		name = null;
		preis = 0.00;
	}

	public Article(uint artikelnummer, string name, double preis)
	{
		this.artikelnummer = artikelnummer;
		this.name = name;
		this.preis = preis;
	}


	public void print()
	{
		Console.WriteLine (artikelnummer + " \\ " + name + " \\ " + preis + " €");
	}
}


class Programm
{
	public static void Main()
	{
		Article Article1 = new Article (001, "Butter", 2.99);
		Article Article2 = new Article (002, "Kaffee", 5.99);
		Article Article3 = new Article ();

		Article3.print ();
		Article1.print ();
		Article2.print ();


	}
}