using System;

interface IPrintAll
{
	void print();
}

interface IChangeData
{
	void daten();
}

class Article : IPrintAll, IChangeData
{
	protected uint artikelnummer;
	protected string name;
	protected double preis;

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

	// Virituelle Printmethode
	public virtual void print()
	{
		Console.WriteLine(artikelnummer + " \\ " + name + " \\ " + preis + " €");
	}


	// a) Preis und Name verändern
	public void daten()
	{
		Console.WriteLine("Möchten Sie Daten verändern? (1) für Name und (2) für Preis:");
		string userInputYesNo = Console.ReadLine();
		int userNumYesNo = int.Parse(userInputYesNo);
		if (userNumYesNo == 1)
		{
			Console.WriteLine("Geben Sie den neuen Namen ein: ");
			this.name = Console.ReadLine();
		}
		else
		{
			Console.WriteLine("Geben Sie den neuen Preis ein: ");
			string neuerPreis = Console.ReadLine();
			double neuerIntPreis = double.Parse(neuerPreis);
			this.preis = neuerIntPreis;
		}
	}

	// b) Steuerprozente zuschlagen
	public double addTax(float p)
	{
		this.preis = this.preis * (1 + (p / 100));
		return this.preis;
	}

}


// d) Unterklassen generieren und base nutzen

class Book : Article
{
	protected string autor;
	protected uint jahr;

	public Book()
		: base()
	{
		autor = null;
		jahr = 1900;
	}

	public Book(string autor, uint jahr, uint artikelnummer, string name, double preis)
		: base(artikelnummer, name, preis)              //so funktionierts zum Beispiel
	{									
		this.autor = autor;						
		this.jahr = jahr;
	}


	// für Book-Klasse
	public override void print()
	{
		Console.WriteLine(artikelnummer + " \\ " + name + " \\ " + preis + " €" + " \\ " + autor + " \\ " + jahr);
	}
}

class DVD : Article
{
	protected string regisseur;
	protected uint produktionsjahr;

	public DVD()
		:base()
	{
		regisseur = "Steven Spielberg";
	}

	public DVD(string regisseur, uint produktionsjahr, uint artikelnummer, string name, double preis)
		:base(artikelnummer, name, preis)
	{
		this.regisseur = regisseur;
		this.produktionsjahr = produktionsjahr;
	}

	public override void print()
	{
		Console.WriteLine(artikelnummer + " \\ " + name + " \\ " + preis + " €" + " \\ " + regisseur + " \\ " + produktionsjahr);
	}
}

class PC : Article
{
	protected string Prozessortyp;
	protected string Grafikkartentyp;

	public PC()
		:base()
	{
		Prozessortyp = "Intel";
		Grafikkartentyp = "Nvidia";
	}

	public PC(string Prozessortyp, string Grafikkartentyp, uint artikelnummer, string name, double preis)
		:base(artikelnummer, name, preis)
	{
		this.Prozessortyp = Prozessortyp;
		this.Grafikkartentyp = Grafikkartentyp;
	}

	public override void print()
	{
		Console.WriteLine(artikelnummer + " \\ " + name + " \\ " + preis + " €" + " \\ " + Prozessortyp + " \\ " + Grafikkartentyp);
	}
}


class Programm
{
	public static void Main()
	{
		//		Article Article1 = new Article (001, "Butter", 2.99);
		//		Article Article2 = new Article ();
		//
		//		Article1.print ();
		//		Article1.addTax (19);
		//		Article1.print ();

//		Book Buch1 = new Book();
//		Book Buch2 = new Book("Daniel", 1979, 333, "Testbuch", 200);
//
//		Buch2.print();
//		Buch1.print ();


//		DVD DVD1 = new DVD ();
//		DVD DVD2 = new DVD ("Guilaum del Toro", 2003, 34523, "Pans Labyrinth", 19.90);
//
//		DVD1.print ();
//		DVD2.print ();

		PC PC1 = new PC ();
		PC PC2 = new PC ("Apple", "AMD", 1324, "MacBook", 1800);

		PC1.print ();
		PC2.print ();



	}
}