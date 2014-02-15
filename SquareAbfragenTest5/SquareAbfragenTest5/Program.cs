using System;

class Square
{
	public double a;

	public Square (double a)
	{
		this.a = a;
	}

	// Kopiert das Quadrat
	public Square copy()
	{
		return new Square(a);
	}


	// Umfang ausrechnen
	public static double circumference (Square s)
	{
		double circumference = s.a * 4;
		return circumference;
	}

	// Fläche ausrechnen
	public static double area (double circumference)
	{
		double area = circumference * circumference;
		return area;
	}

	// Seitenlänge verdoppeln
	public static void makeDouble (Square s)
	{
		s.a = s.a * 2;
	}

	// Skalieren
	public void scale (double percent)
	{
		this.a = this.a * (percent + this.a);
	}

	// Ausgabe
	public void print()
	{

	}

}

class Programm
{
	public static void Main()
	{
		Square klein = new Square (0.1);

		// Abrufe
		klein.copy ();
		klein.scale (120);
		Square.circumference (klein);
		Square.area (Square.circumference(klein));
		Square.makeDouble (klein);

		klein.print ();





















	}
}