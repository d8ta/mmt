using System;

	class Color 
	{
		// Variablen festlegen
		private uint red;
		private uint green;
		private uint blue;

	// Konstruktor für Color, wenn über 255 Fehler und 0 setzten.
		public Color(uint r = 0, uint g = 0, uint b = 0) 
		{
			if ((r > 255) || (g > 255) || (b > 255)) {
				Console.WriteLine("Fehler! Ungueltiger Parameter. Es wird Schwarz gesetzt.");
				red = 0; green = 0; blue = 0;
		}
		else {
			red = r; green = g; blue = b;
		}
	}


	// Konstruktor für Color
	public Color(char c) 
	{ 	
		//gültige Eingaben: 'r', 'g', 'b', sonst Schwarz
		red = 0; green = 0; blue = 0;
		switch (c) 
		{
		case 'r':
			red = 255; 
			break;
		
		case 'g':
			green = 255;
			break;
		
		case 'b':
			blue = 255;
			break;
		
		default:
			throw new Exception("Wrong parameter! Color not constructed.");
		}
	}


	// Methode zum mixend von Farben
	public void mix(Color c) 
	{
		uint r = red + c.red;
		uint g = green + c.green;
		uint b = blue + c.blue;
		if (r > 255) r = 255;
		if (g > 255) g = 255;
		if (b > 255) b = 255;
		red = r; green = g; blue = b;
	}



	public void print() 
	{
		Console.WriteLine("r: " + red + ", g: " + green + ", b: " + blue);
	}

};



class Program 
{
	public static void Main() 
	{
		try 
		{
			// Neue Instanz (c1) der Klasse Color erstellen
			Color c1 = new Color(255, 0, 0); //Rot
			c1.print(); // gibt "r: 255, g: 0, b: 0" aus.

			// Neue Instanz (green)
			Color green = new Color('g'); //Gruen
			green.print();

			// Neue Instanz/Farbe (black)
			Color black = new Color(); //Schwarz
			black.print();

			Color c2 = new Color(1000, 0, 256); //ungueltig --> Schwarz
			c2.print();

			Color c3 = new Color('x'); //ungueltig --> korrekter Abbruch des Konstruktors
			c3.print();

			c1.mix(green); //c1 wird Gelb (Rot und Gruen --> Gelb!)
			c1.print(); // gibt "r: 255, g: 255, b: 0" aus.

		} 

		catch (Exception e) 
		{
			Console.WriteLine(e.Message);
		}
	}
}

