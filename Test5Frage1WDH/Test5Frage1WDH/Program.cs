using System;

class Square {
	private double a;

	public Square(double a) {
		this.a = a;
	}

	// liefert ein neues Quadrat welches identisch zum aktuellen Objekt ist
	public Square copy() {
		return new Square(this.a);   
	}

	//liefert den Umfang des \"ubergebenen \"Quadrats 
	public static double circumference(Square s) {
		return 4*s.a;
	}

	// liefert den Flächeninhalt eines beliebigen Quadrats bei gegebenem Umfang
	public static double area(double umfang) {
		return (umfang/4)*(umfang/4);
	}

	//verdoppelt die Seitenl\ange des übergebenen Quadrats
	public static void makeDouble(Square s) {  
		s.a = 2*s.a;
	}


	// vergrößert die Seitenl\"ange des aktuellen Quadrats
	// um "percent" viele Prozent:
	public void scale(double percent) {
		this.a = this.a*(1 + percent/100);
	}

	public void print() {
		Console.WriteLine("a: " + a);
	}

}

class Program {

	public static void Main() {
		Square klein = new Square(13);
		Square kopie;

		klein.print ();
		klein.print ();
        double area;
        kopie = klein.copy();
        kopie.print();
	    kopie.scale(120);
        kopie.print();
	    double c = Square.circumference(kopie);
		Console.WriteLine("Circumference: " + c);
	    area = Square.area(c);
		Console.WriteLine("Area: " + c);
        Square.makeDouble(kopie);
        kopie.print();
	}
}