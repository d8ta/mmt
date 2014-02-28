using System;

class Square
{
	public double a;

	public Square (double a)
	{
		this.a = a;
	}

	// Kopieren
	public Square copy()
	{
		return new Square (a);
	}

	// Umfang ermitteln
	public static double umfang (Square neu)
	{
		return neu.a * neu.a;
	}

	// Fläche aus gegebenem Umfang ermitteln
	public static double flaeche (double umfang)
	{
		return (umfang / 4) * (umfang / 4);
	}

	// Seitenlänge verdoppeln
	public static void makeDouble (Square neu)
	{
		neu.a = neu.a * 2;
	}

	// Skalieren in %
	public void scale (double prozent)
	{
		this.a = this.a * (1 + (prozent/100));
	}

	// Ergebnise zeigen
	public void print()
	{
		Console.WriteLine ("Seitenlänge: " + a);
	}
}

class Programm
{
	public static void Main()
	{
		Square klein = new Square (0.1);
		Square kopie;
		double area;

		kopie = klein.copy ();
		kopie.print ();

		kopie.scale (120);
		kopie.print ();

		double umfang = Square.umfang (kopie);
		area = Square.flaeche (umfang);
		Square.makeDouble (kopie);
		kopie.print ();



	}
}
