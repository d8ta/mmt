using System;


//(4P) Vervollständige die struct namens Vector2 fü̈r 2-dimensionale Vektoren: implementiere folgende nicht-statische Methoden

struct Vector2 {
	public double x; //x-Coordinate
	public double y; //y-Coordinate


	//(a) double Magnitude(): liefert die Länge des aktuellen Vektors.
	public double Magnitude()
	{
		double length = Math.Sqrt((x*x) + (y*y));
		return length;
	}


//	(b) Vector2 UnitVector(): liefert den Einheitsvektor (Länge 1) zum aktuellen Vektor (sofern vom
//		Nullvektor verschieden). Der aktuelle Vektor bleibt unverändert.
	public Vector2 UnitVector()
	{
		Vector2 v;
		v.x = (1 / Magnitude() * x); // Einheitsvektor = 1/Vektorlänge * Vektor;
		v.y = (1 / Magnitude() * y);
		return v;
	}

//	(c) Vector2 Add(Vector2 v): liefert den Vektor, der durch Addition von v zum aktuellen Vektor entsteht. Der aktuelle Vektor bleibt unverändert.
	public Vector2 Add(Vector2 v)
	{
		v.x = v.x + x;
		v.y = v.y + y;
		return v;
	}

//	(d) void AddToSelf(Vector2 v): addiert v zum aktuellen Vektor. Der aktuelle Vektor entspricht danach dem Summenvektor.
	public void AddToSelf(Vector2 v)
	{
		x = x + v.x;
		y = y + v.y;
	}

//	(e) Vector2 Scale(double c): liefert den Vektor, der durch Multiplikation von c (Skalierungsfaktor) mit dem aktuellen Vektor entsteht. Der aktuelle Vektor bleibt unverändert.
	public Vector2 Scale(double c)
	{
		Vector2 v;
		v.x = x * c;
		v.y = y * c;
		return v;
	}






	public void print() {
		Console.Write(" ( {0:0.00} |  {1:0.00} ) ", x, y);
	}

	public static void print(Vector2 v) {
		v.print();
	}

	// Negates the current vector
	public void negateSelf() {
		x = -x;
		y = -y;
	}

	// Returns the negated current vector. The currect vector remains unchanged.
	public Vector2 getNegated() {
		Vector2 v;
		v.x = -x;
		v.y = -y;
		return v;
	}

	// Returns the negation of v.
	public static Vector2 negate(Vector2 v) {
		Vector2 newV;
		newV.x = -v.x;
		newV.y = -v.y;
		return newV;
	}

	// Sets the current vector to the zero-vector.
	public void setZero() {
		x = 0;
		y = 0;
	}

	// for structs on stack AND on heap, it works only with ref!!! (structs are value types!!!!)
	public static void setZero(ref Vector2 v) {
		v.x = 0;
		v.y = 0;
	}

}

class Vector2Demo {

	static void Main() {

		Vector2 v;
		v.x = -1.0;
		v.y = 2.0;
		Console.Write(" v: ");
		v.print();	  //calls non-static print()
		Console.WriteLine();

		Vector2 w;
		w.x = 3.0;
		w.y = -4.0;
		Console.Write(" w: " );
		Vector2.print(w);  //calls static print()
		Console.WriteLine();

		v.negateSelf();
		Console.Write("-v: ");
		v.print();
		Console.WriteLine();

		Vector2 negatedW1 = w.getNegated(); //calls non-static getNegated()
		Console.Write("-w: ");
		negatedW1.print();
		Console.WriteLine();

		Vector2 negatedW2 = Vector2.negate(w); //calls static negate()
		Console.Write("-w: " );
		negatedW2.print();
		Console.WriteLine();

		v.setZero();
		Console.Write("v after setZero: " );
		v.print();
		Console.WriteLine();

		Vector2.setZero(ref w);
		Console.Write("v after static setZero: " );
		w.print();
		Console.WriteLine();

		Vector2 a = new Vector2();
		a.x = -11.0;
		a.y = -11.0;
		Vector2.setZero(ref a);
		Console.Write("a (on heap) after static setZero: ");
		a.print();
		Console.WriteLine();

	}

}