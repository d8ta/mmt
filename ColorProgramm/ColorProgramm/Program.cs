using System;

class Color
{
	public uint rot;
	public uint gruen;
	public uint blau;

	public Color (uint rot, uint gruen, uint blau)
	{
		this.rot = rot;
		this.gruen = gruen;
		this.blau = blau;

		if (rot > 255 || gruen > 255 || blau > 255) {
			Console.WriteLine ("Fehlerhafte Eingabe, die Farbe wird auf schwarz gesetzt");
			rot = 0;
			gruen = 0; 
			blau = 0;
		}
	}

	public Color()
	{
		rot = 0;
		gruen = 0; 
		blau = 0;
	}

	public Color (char c)
	{
		switch (c) {
		case 'r':
			rot = 255;
			gruen = 0;
			blau = 0;
			break;

		case 'g':
			rot = 0;
			gruen = 255;
			blau = 0;
			break;

		case 'b':
			rot = 0;
			gruen = 0;
			blau = 255;
			break;

		default:
			Console.WriteLine ("Fehlerhafte Eingabe, das Programm wird abgebrochen!");
			break;
		}
	}


	public void mix(Color c) {
		rot = rot + c.rot;
		gruen = gruen + c.gruen;
		blau = blau + c.blau;
		if (rot > 255) {
			rot = 255;
		}
		if (gruen > 255) {
			gruen = 255;
		} 
		if (blau > 255) {
			blau = 255;
		}
	}

	public void printAll()
	{
		Console.WriteLine(" Rot: " + this.rot + " Grün: " + this.gruen + " Blau: " + this.blau);
	}
}


class Programm
{
	public static void Main()
	{
		Color c1 = new Color (255, 0, 0);
		Color green = new Color ('g');
		Color black = new Color ();
		Color c2 = new Color (1000, 0, 25);
		Color c3 = new Color ('x');
		c1.mix (green);


		c1.printAll ();
//		green.printAll ();
//		black.printAll ();
//		c2.printAll ();
//		c3.printAll ();
	}
}














































//using System;
//
//class Color {
//	public Color(uint r = 0, uint g = 0, uint b = 0) {
//		if ((r > 255) || (g > 255) || (b > 255)) {
//			Console.WriteLine("Fehler! Ungueltiger Parameter. Es wird Schwarz gesetzt.");
//			red = 0; green = 0; blue = 0;
//		}
//		else {
//			red = r; green = g; blue = b;
//		}
//	}
//
//	public Color(char c) { //gültige Eingaben: 'r', 'g', 'b', sonst Schwarz
//		red = 0; green = 0; blue = 0;
//		switch (c) {
//		case 'r':
//			red = 255; 
//			break;
//		case 'g':
//			green = 255;
//			break;
//		case 'b':
//			blue = 255;
//			break;
//		default:
//			throw new Exception("Wrong parameter! Color not constructed.");
//			break;
//		}
//	}
//
//	public void mix(Color c) {
//		uint r = red + c.red;
//		uint g = green + c.green;
//		uint b = blue + c.blue;
//		if (r > 255) r = 255;
//		if (g > 255) g = 255;
//		if (b > 255) b = 255;
//		red = r; green = g; blue = b;
//	}
//
//	public void print() {
//		Console.WriteLine("r: " + red + ", g: " + green + ", b: " + blue);
//	}
//
//	private uint red;
//	private uint green;
//	private uint blue;
//};
//
//class Program {
//	public static void Main() {
//		try {
//
//
//			Color c1 = new Color(255, 0, 0); //Rot
//			c1.print(); // gibt "r: 255, g: 0, b: 0" aus.
//			Color green = new Color('g'); //Gruen
//			green.print();
//			Color black = new Color(); //Schwarz
//			black.print();
//			Color c2 = new Color(1000, 0, 256); //ungueltig --> Schwarz
//			c2.print();
//			Color c3 = new Color('x'); //ungueltig --> korrekter Abbruch des Konstruktors
//			c3.print();
//			c1.mix(green); //c1 wird Gelb (Rot und Gruen --> Gelb!)
//			c1.print(); // gibt "r: 255, g: 255, b: 0" aus.
//
//
//		} catch (Exception e) {
//			Console.WriteLine(e.Message);
//		}
//	}
//}
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
////using System;
////
////class Color
////{
////	// Membervariablen
////	private uint r; 		// -> weil uint nicht negativ sein kann (einfacher weil kein "if r < 0" nötig)
////	private uint g;
////	private uint b;
////
////	private uint red; 	
////	private uint green;
////	private uint blue;
////
////
////
////	// Erster Konstruktor
////	public Color (uint r, uint g, uint b)
////	{
////		this.r = r;
////		this.g = g;
////		this.b = b;
////
////		// Falls zu hohe Werte eingegeben werden
////		if ((r > 255) || (g > 255) || (b > 255)) 
////		{
////			Console.WriteLine ("Fehlerhafter Farbcode, Farbe wird auf Schwarz gesetzt!");
////			r = 0; g = 0; b = 0;	
////		} else {
////			red = r; green = g; blue = b;
////		}
////
////	}
////
//////	// Damit auch Aufrufen über namen mgl ist!
//////	uint red = r;
//////	uint green = g;
//////	uint blue = b;
////
////	// Zweiter Konstruktor
////	public Color(char c)
////	{
////		red = 0; green = 0; blue = 0;
////		switch (c) 
////		{
////		case 'r':
////			red = 255;
////
////		case 'g':
////			green = 255;
////
////		case 'b':
////			blue = 255;
////
////		default:
////			throw new Exception("Das ist kein regulärer Farbcode. Durchführung nicht möglich");
////			break;
////		}
////	}
////
////	// Methode um Farben zu mixen
////	public void mix(Color c)
////	{
////		uint r = red + c.red;
////		uint g = green + c.green;
////		uint b = blue + c.blue;
////		if (r > 255) r = 255;
////		if (g > 255) g = 255;
////		if (b > 255) b = 255;
////		red = r; green = g; blue = b;
////	} 
////
////
////	public void print()
////	{
////		Console.WriteLine ("r: " + red + "g: " + green + "b: " + blue);
////	}
////}
////
////
////
////class Programm
////{
////	public static void Main ()
////	{
////		Color c1 = new Color (255,0,0);
////		Color green = new Color ('g');
////		c1.mix(green);
////		c1.print ();
////	}
////}
