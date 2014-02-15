using System;

enum Geschlecht
{
	männlich,
	weiblich,
	nicht_definiert,
};

class Mensch
{
	public string vorname;
	public string nachname;
	public int alter;
	public bool verheiratet;
	public Geschlecht status;
	// Neu!
	public string ehepartner;
	public int anzahlKinder;

	// Konstruktor
	public Mensch (string vorname, string nachname, int alter, bool verheiratet, Geschlecht status, string ehepartner, int anzahlKinder)
	{
		this.vorname = vorname;
		this.nachname = nachname;
		this.alter = alter;
		this.verheiratet = verheiratet;
		this.status = status;
		// Neu!
		this.ehepartner = ehepartner;
		this.anzahlKinder = anzahlKinder;
	}


	// Kind zeugen
	public Mensch zeugeKindMit (Mensch partner)
	{
		string[] girls = { "Anne", "Christine", "Mira" };
		string[] boys = {"Daniel", "André", "Klaus"};

		Random random = new Random ();
		int rnd = random.Next (0, 4);
		this.anzahlKinder = 1;
		partner.anzahlKinder = 1;

		if (kannKindZeugenMit(partner)) 
		{
			if (rnd % 2 == 0 && this.status == Geschlecht.weiblich) 
			{
				return new Mensch (girls [rnd], this.nachname, 0, false, Geschlecht.weiblich, null, 0);	
			}
			else if (rnd % 2 == 0 && this.status == Geschlecht.männlich) 
			{
				return new Mensch (girls[rnd], partner.nachname, 0, false, Geschlecht.weiblich, null, 0);
			}
			else if (rnd % 2 != 0 && this.status == Geschlecht.weiblich) 
			{
				return new Mensch (boys[rnd], this.nachname, 0, false, Geschlecht.männlich, null, 0);
			} 
			else if (rnd % 2 != 0 && this.status == Geschlecht.weiblich) 
			{
				return new Mensch (boys[rnd], partner.nachname, 0, false, Geschlecht.männlich, null, 0);
			}
		} return null;



	}


	// Prüfen ob Kinder mgl.
	public bool kannKindZeugenMit (Mensch partner)
	{
		if (this.alter >= 18 && partner.alter >= 18) 
		{
			if (this.status != partner.status) 
			{

				return true;
					
			} else {
				return false;
			}
		} return false;
	}


	// Prüfen ob Heirat mgl.
	public bool kannHeiraten(Mensch partner)
	{
		if (this.verheiratet != true && partner.verheiratet != true) 
		{
			if (this.status != partner.status) 
			{
				if (this.alter >= 18 && partner.alter >= 18) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			} 
			else 
			{
				return false;
			}
		} 
		else 
		{
			return false;
		} 
	}


	// Menschen verheiraten
	public bool heiraten (Mensch partner)
	{
		if (kannHeiraten(partner)) 
		{
			this.verheiratet = true;
			partner.verheiratet = true;
			Console.WriteLine ("Just Married! " + this.vorname + " & " + partner.vorname);
			this.ehepartner = partner.vorname;
			partner.ehepartner = this.vorname;

			if (this.status == Geschlecht.männlich) 
			{
				partner.nachname = this.nachname;
			} else 
			{
				this.nachname = partner.nachname;	
			}
			return true;
		} 
		else 
		{
			Console.WriteLine ("Heiraten nicht möglich");
			return false;
			this.ehepartner = null;
			partner.ehepartner = null;
		}
	}


	// Print Methode
	public void print()
	{
		Console.WriteLine ("\n<3 <3 <3 <3 <3 <3 <3 <3 <3 <3\n");
		Console.WriteLine ("Vorname: " + vorname);
		Console.WriteLine ("Nachname: " + nachname);
		Console.WriteLine ("Alter: " + alter);
		Console.WriteLine ("Verheiratet: " + verheiratet);
		Console.WriteLine ("Geschlecht: " + status);
		Console.WriteLine ("Partner: " + ehepartner);
		Console.WriteLine ("Wieviele Kinder: " + anzahlKinder);
	}
}


class ProgrammMensch
{
	public static void Main()
	{
		Mensch P1 = new Mensch ("Daniel", "Taggeselle" , 34, false, Geschlecht.männlich, null, 0);
		Mensch P2 = new Mensch ("Anne", "Raudschus", 30, false, Geschlecht.weiblich, null, 0);

		P1.kannHeiraten (P2);
		P1.heiraten (P2);
		P1.kannKindZeugenMit (P2);
		P1.zeugeKindMit (P2);
		P1.print();
		P2.print();
	}
}

