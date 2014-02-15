using System;

enum Races
{
	Norn,
	Human,
	Charr,
	Sylvari,
	Asura
};

enum Classes
{
	Ranger,
	Warrior,
	Engineer,
	Mage,
	Thief,
	Worker
};

enum Essen
{
	Strong,
	Middle,
	Weak
}

class Character
{
	private string name;
	private Races whatRace;
	private Classes whatClass;
	private uint Lifepower;
	private Essen whatToEat;
	private bool alive;



	// Default Konstruktor
	public Character()
	{
		name = null;
		whatRace = Races.Human;
		whatClass = Classes.Worker;
		Lifepower = 100;
		alive = true;
	}

	// "This" Konstruktor
	public Character(string name, Races whatRace, Classes whatClass, uint Lifepower, bool alive)
	{
		this.name = name;
		this.whatRace = whatRace;
		this.whatClass = whatClass;
		this.Lifepower = Lifepower;
		this.alive = alive;
	}

	// Am Leben?
	public bool amLeben()
	{
		if (this.Lifepower > 0) {
			return true;
		} else {
			return false;
			alive = false;
		}
	}

	// Hinterhalt verringert LP
	public uint Angriff(uint damage)
	{
		if (this.amLeben()) {
			if (damage > this.Lifepower) {
				Console.WriteLine ("\t\"" + name + " ist gestorben\"");
				this.Lifepower = 0;
			} else {
				Console.WriteLine ("\t\"" + name + " wurde angegriffen und verliert " + damage + "\"");
				this.Lifepower -= damage;
			}

		} else {
			Console.WriteLine (name + " liegt bereits am Boden");
		}
		return this.Lifepower;
	} 

	// Charakter soll Essen und LP bekommen
	public uint Essen()
	{
		Console.WriteLine ("\t\"" + name + " hat gegessen\"");
		this.Lifepower += 65;
		if (this.Lifepower > 100) {
			this.Lifepower = 100;
		} return Lifepower;
	}

	// Print all out
	public void PrintAll()
	{
		Console.WriteLine ("\n----------------------------\n");
		Console.WriteLine ("Charaktername: " + name);
		Console.WriteLine ("Rasse: " + whatRace);
		Console.WriteLine ("Klasse: " + whatClass);
		Console.WriteLine ("Lebensenergie: " + Lifepower);
	}

	// Print all out
	public void PrintLP()
	{
		Console.WriteLine ("\t" + name + " hat jetzt " + Lifepower + " Lebensenergie übrig");
	}
}


class Programm
{
	public static void Main()
	{
		Character Thorin = new Character ("Thorin Eisenschild",Races.Charr, Classes.Engineer, 100, true);
		Thorin.PrintAll ();

		Character Hild = new Character ("Hild Sturmkrähe", Races.Norn, Classes.Ranger, 100, true);
		Hild.PrintAll ();
		Thorin.Angriff (20);
		Thorin.Angriff (20);
		Thorin.Essen ();
		Thorin.Angriff (80);

		Thorin.PrintAll ();

	}
}


