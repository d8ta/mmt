/* 1310601027, fhs36118
 * Daniel Raudschus
 * ue09 bsp50
 * */

using System;

// Klasse Mensch implementieren
class Mensch 
{
	public string vorname;
	public string nachname;
	public int alter;
	public bool verheiratet;
	public string geschlecht;

	// Konstruktor
	public Mensch (string vorname, string nachname, int alter, bool verheiratet, string geschlecht)
	{
		this.vorname = vorname;
		this.nachname = nachname;
		this.alter = alter;
		this.verheiratet = verheiratet;
		this.geschlecht = geschlecht;
	}

	public bool heiraten (Mensch partner)
	{
		if (kannHeiraten(partner)) {
			if (this.geschlecht == "Mann") {
				partner.nachname = this.nachname;
				partner.verheiratet = true;
				this.verheiratet = true;
				Console.WriteLine ("Just Married! " + this.vorname + " & " + partner.vorname);
			} else {
				this.nachname = partner.nachname;
				partner.verheiratet = true;
				this.verheiratet = true;
				Console.WriteLine ("Just Married! " + this.vorname + " & " + partner.vorname);
			}
		}
		return false;
	}

	// Prüft den verheiratet status
	public bool kannHeiraten (Mensch partner)
	{
		if (partner.verheiratet == false && this.verheiratet == false) {
			if (this.geschlecht == "Mann" && partner.geschlecht == "Frau" || this.geschlecht == "Frau" && partner.geschlecht == "Mann") {
				if (partner.alter > 18 & this.alter > 18) {
					Console.WriteLine ("Heiraten ist möglich");
					return true;			
				} else {
					Console.WriteLine ("Zum heiraten müssen beide Partner volljährig sein!");
					return false;
				}
			} else {
				Console.WriteLine ("In vielen Ländern sind gleichgeschlechtliche Beziehungen verboten.... auch in diesem Program dürft Ihr vorerst nicht heiraten (wir arbeiten dran! ;-))");
				return false;
			}
		} else {
			Console.WriteLine ("Heirat nicht möglich, da ist wohl schon jemand verheiratet?!");
			return false;
		}
	}

	public void print()
	{
		Console.WriteLine ("________________");
		Console.WriteLine (this.vorname);
		Console.WriteLine (this.nachname);
		Console.WriteLine (this.alter);
		Console.WriteLine (this.verheiratet);
		Console.WriteLine (this.geschlecht);
	}
}


class MenschDemo
{
	static void Main()
	{
		Mensch Person1 = new Mensch("Daniel", "Taggeselle", 34, false, "Mann");
		Mensch Person2 = new Mensch("Anne", "Raudschus", 30, false, "Frau");
		Mensch Person3 = new Mensch("Peter", "Parker", 22, false, "Mann");
		Mensch Person4 = new Mensch("Bat", "Girl", 19, false, "Frau");

		Person1.heiraten (Person2);

//		Person1.print ();
//		Person2.print ();
//		Person3.print ();
//		Person4.print ();
	}
};