using System;

enum KontoStatus
{
	aktiv,
	geschlossen,
	gesperrt
};

class Konto
{
	protected decimal balance;
	private KontoStatus status;
	private string name;

	public Konto(decimal balance, KontoStatus status, string name)
	{
		this.balance = balance;
		this.status = status;
		this.name = name;
	}


	// Methode zum printen
	public void print()
	{
		Console.WriteLine ("Konto von: " + this.name);
		Console.WriteLine ("Guthaben: " + this.balance);
		Console.WriteLine ("Status: " + this.status);
	}

}


class MainClass
{
	public static void Main (string[] args)
	{
		// neuer Status für enum KontoStatus
		KontoStatus WirdGeprueft;
		WirdGeprueft = KontoStatus.gesperrt;

		Konto Anne = new Konto (2345, KontoStatus.aktiv, "Anne");
		Konto Daniel = new Konto (345, WirdGeprueft, "Daniel");

		Anne.print ();
		Console.WriteLine ("\n---------------------------------------");
		Daniel.print ();

	}

}

