using System;

class Program
{
	static void Main (string[] args)
	{
		//Read in width.
		Console.WriteLine ("Dieses Programm berechnet den Glas- und Holzbedarf für ein Fenster.");
		Console.WriteLine ("Geben Sie bitte die Breite des Fensters ein (cm).");
		string userWidth = Console.ReadLine ();
		double width = double.Parse (userWidth);

		// Read in height.
		Console.WriteLine ("Geben Sie bitte die Höhe des Fensters ein (cm).");
		string userHeight = Console.ReadLine ();
		double height = double.Parse (userHeight);

		// Compute length of required wood.
		double length = 2 * (width + height);

		// Compute glass area.
		double area = width * height;

		// Print length and area.
		Console.WriteLine ("Die notwendige Länge des Holzes ist " + length + "cm.");
		Console.WriteLine ("Die notwendige Glasfläche ist " + area + "cm^2.");
	}
}
