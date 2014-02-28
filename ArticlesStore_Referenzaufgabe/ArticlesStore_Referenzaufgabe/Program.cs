// 1310601035, fhs36126
// Franz Rest; slight adaptions, comments/notes made by G.Mitterlechner.
// ue09 bsp56

using System;

class Article
{
	private int Artikelnummer;
	private string Name;
	private double Preis;
	// implementation of auto-increment:
	private static int actualArtikelnummer; 
	// There is only a single instance of this variable 
	// for the whole class, no matter how many Article-instances
	// are created.

	// default constructor
	public Article() {}

	// constructor
	public Article(string Name, double Preis)
	{
		this.Name = Name;
		this.Preis = Preis;
		Artikelnummer = actualArtikelnummer;
		actualArtikelnummer++;
	}

	// NOTE: the following Getter and Setter-Methods can be 
	// (auto-)created in a much shorter way: see "C# properties", e.g. 
	// http://msdn.microsoft.com/en-us/library/x9fsa0sw.aspx or
	// http://msdn.microsoft.com/en-us/library/bb384054.aspx
	public int GetNR()
	{
		return Artikelnummer;
	}

	public double GetPrice()
	{
		return Preis;
	}

	public void SetPrice(double Preis)
	{
		this.Preis = Preis;
	}

	public string GetName()
	{
		return Name;
	}

	public void SetName(string Name)
	{
		this.Name = Name;
	}

	public virtual void Print()  //virtual because it gets overridden!
	{
		Console.WriteLine("----------------------------------");
		Console.WriteLine("Artikelnummer: " + Artikelnummer);
		Console.WriteLine(Name);
		Console.WriteLine("Preis: {0:0.00} Euro", Preis);
	}

	// returns new Price
	public double withTax(float p)
	{
		return (Preis / 100 * p) + Preis;
	}

	// adds Tax to price
	public void addTax(float p)
	{
		Preis = (Preis * p/100) + Preis;
	}

	public virtual void edit()   
	{
		string answer;
		Console.WriteLine("----------------------------------");
		Console.WriteLine("Editieren des Artikels mit Nr.: " + Artikelnummer);
		Console.WriteLine("Wollen Sie den Namen ändern?");
		answer = Console.ReadLine();

		// NOTE: the following lines of code are duplicated many times.
		// This should be avoided, e.g. by using a helper function for
		// checking the input answer.
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Namen ein!");
			Name = Console.ReadLine();
		}

		Console.WriteLine("Wollen Sie den Preis ändern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Preis ein!");
			bool OK = false;
			while (!OK)
			{
				answer = Console.ReadLine();
				OK = double.TryParse(answer, out Preis);
				if (!OK) Console.WriteLine("Geben Sie einen gültigen Preis ein! (#.00))");
			}
		}
	}
}


class Book : Article
{
	private string Autor;
	private string Verlag;

	public Book(string Name, double Preis, string Autor, string Verlag) : 
	base(Name,Preis)   //call constructor from base class (Article!)
	{
		this.Autor = Autor;
		this.Verlag = Verlag;
	}

	public override void Print()
	{
		base.Print();   // call Print() from base class (Article!)
		Console.WriteLine("Autor: " + Autor);
		Console.WriteLine("Verlag; " + Verlag);
	}

	public string GetAutor()
	{
		return Autor;
	}

	public string GetVerlag()
	{
		return Verlag;
	}

	public override void edit()
	{
		string answer;
		base.edit();  

		Console.WriteLine("Wollen Sie den Autor 鋘dern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Autor ein!");
			Autor = Console.ReadLine();
		}
		Console.WriteLine("Wollen Sie den Verlag 鋘dern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Verlag ein!");
			Verlag = Console.ReadLine();
		}
	}
}


class DVD : Article
{
	private string Publisher;
	private string Regisseur;

	public DVD(string Name, double Preis, string Publisher, string Regisseur) : 
	base(Name, Preis)
	{
		this.Publisher = Publisher;
		this.Regisseur = Regisseur;
	}

	public override void Print()
	{
		base.Print();
		Console.WriteLine("Publisher: " + Publisher);
		Console.WriteLine("Regisseur: " + Regisseur);
	}

	public string GetPublisher()
	{
		return Publisher;
	}

	public string GetRegisseur()
	{
		return Regisseur;
	}

	public override void edit()
	{
		string answer;

		base.edit();

		Console.WriteLine("Wollen Sie den Publisher 鋘dern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Publisher ein!");
			Publisher = Console.ReadLine();
		}

		Console.WriteLine("Wollen Sie den Regisseur 鋘dern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Regisseur ein!");
			Regisseur = Console.ReadLine();
		}
	}
}
class PC : Article
{
	private string Hersteller;
	private string Betriebssystem;

	public PC(string Name, double Preis, string Hersteller, string Betriebssystem): base(Name, Preis)
	{
		this.Hersteller = Hersteller;
		this.Betriebssystem = Betriebssystem;
	}

	public override void Print()
	{
		base.Print();
		Console.WriteLine("Hersteller: " + Hersteller);
		Console.WriteLine("Betriebssystem: " + Betriebssystem);
	}

	public string GetHersteller()
	{
		return Hersteller;
	}

	public string GetBetriebssystem()
	{
		return Betriebssystem;
	}

	public override void edit()
	{
		string answer;
		base.edit();

		Console.WriteLine("Wollen Sie den Hersteller 鋘dern!");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") || 
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie den neuen Hersteller ein!");
			Hersteller = Console.ReadLine();
		}

		Console.WriteLine("Wollen Sie das Betriebssystem 鋘dern?");
		answer = Console.ReadLine();
		if (
			(answer == "Ja") ||
			(answer == "ja") || 
			(answer == "j") || 
			(answer == "JA")
		)
		{
			Console.WriteLine("Geben Sie das neue Betriebssystem ein!");
			Betriebssystem = Console.ReadLine();
		}
	}
}


class Store
{
	// array for storing all kinds of different articles:
	private Article[] articles;
	// index that points to the next empty field in the articles array:
	private int actualindex;

	public Store(int size)
	{
		articles = new Article[size];
	}

	public bool addArticle(Article a)
	{
		// NOTE: in the original version, the
		// check was done by "actualindex > articles.Length", which
		// leads to a null-reference exception when the array is full
		// and another article is to be added.
		if (actualindex >= articles.Length)
			return false;

		articles[actualindex] = a;
		actualindex++;
		return true;
	}

	public Article findArticle(int artNr)
	{
		// NOTE: in the original version, "i < articles.Length"
		// checked, which leads to a null-reference exception, if
		// the array is not full!!!
		for (int i = 0; i < actualindex; i++)
		{
			if (articles[i].GetNR() == artNr)
				return articles[i];
		}
		return null;
	}

	public void printAll()
	{
		//NOTE: see above
		for (int i = 0; i < actualindex; i++)
			articles[i].Print();
	}

	public void addTaxes(float p)
	{
		//NOTE: see above
		for (int i = 0; i < actualindex; i++)
		{
			articles[i].addTax(p);  // delegate the taxation to the article

			// NOTE: the original code does the following instead...
			/*
			double price = articles[i].GetPrice();
			articles[i].SetPrice(price + (price / 100 * p));
			*/
			//... which is code duplication and should be avoided.
		}
	}

	public double computeTotalPrice()
	{
		double totalprice = 0;
		//NOTE: see above
		for (int i = 0; i < actualindex; i++)
			totalprice += articles[i].GetPrice();

		return totalprice;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Article eins = new Article("Irgendwas", 10.50);
		Article zwei = new Article("NochWasAnderes", 20);
		Book book = new Book("Buch", 10.50, "Autor", "Verlag");
		DVD DvD = new DVD("Film", 20.99, "Herr Publisher", "Mr. Regisseur");
		//Note: this is also possible:
		Article Computer = new PC("PC", 100.50, "Dell", "Windows 8");

//		eins.Print();
//		zwei.Print();
//		book.Print();
//		DvD.Print();
//		Computer.Print();

//		 eins.edit();
//		 book.edit();
//		 DvD.edit();
//		Computer.edit();

		Store store = new Store(3);

		// NOTE: the original store does not check
		// whether a new article can be stored!
		bool result;
		result = store.addArticle(eins);
		result = result && store.addArticle(book);
		result = result && store.addArticle(Computer);
		result = result && store.addArticle(zwei);
		if (!result) 
			Console.WriteLine(
				"Some article(s) have not been added, as the store is full"
			);


		Console.WriteLine(
			"Gesamtpreis der gespeicherten Artikel: " +
			store.computeTotalPrice()
		);

		Console.WriteLine();

		store.printAll();
		Console.WriteLine("---------------------------");

		// NOTE: the original code does not check whether
		// the searched article exists!
		Article searchedArticle = store.findArticle(2);
		if (searchedArticle != null) {
			Console.WriteLine("Artikel gefunden!");
			searchedArticle.Print();
		}
		else {
			Console.WriteLine("Artikel nicht gefunden!");
		}

		Console.WriteLine("------------------------");
		Console.WriteLine("Brutto-Preis von Artikel 0: " + eins.withTax(20));
		Console.WriteLine(
			"Gesamtpreis der gespeicherten Artikel: " + 
			store.computeTotalPrice()
		);
		Console.WriteLine("20% Steuer wird nun 黚erall aufgeschlagen.");
		store.addTaxes(20);
		Console.WriteLine(
			"Gesamtpreis nach Steueraufschlag: " + 
			store.computeTotalPrice()
		);
	}
}
