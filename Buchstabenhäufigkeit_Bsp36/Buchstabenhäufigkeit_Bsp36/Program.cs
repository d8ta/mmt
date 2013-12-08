using System;
using System.IO;
using System.Diagnostics;

namespace Buchstabenhäufigkeit_Bsp36  // TODO: Exception Handling; Asserts; Histogramm mit #
{
	class MainClass
	{
		const int CODE_OF_a = 97; //ASCII code für a
		static int[] alphabet = new int[27]; // Int Array für Alphabet + 1 für Sonderzeichen

		// Main
		public static void Main (string[] args)
		{
			CharacterSorting ();
			ShowHistogram ();
		}

		static string ReadFile(string file)
		{
				StreamReader reader = new StreamReader (file);
				string TextFile = string.Empty; // Leerer String

				while (!reader.EndOfStream) 
				{
					TextFile = TextFile + reader.ReadLine (); // Füllt Textfile mit Text aus dem File	
				}
				reader.Close ();
				return TextFile;

		} // Ende

		// Alle Characters im Array abspeichern
		static void CharacterSorting ()
		{
			string text = ReadFile ("/Users/danielraudschus/Documents/C#/Textfiles/Netzwerkbericht.txt");
			text.ToLower ();
			for (int i = 0; i < text.Length; i++)
			{         
				for (int j = 0; j < alphabet.Length; j++) // Loop durch Array/Alphabet und speichern im Array
				{
					if (text[i] == (char) j + CODE_OF_a)
					{
						alphabet [j]++;
					}
				}
			}
		} // Ende


		// Anzeigen aller Buchstabenhäufigkeiten
		static void ShowHistogram ()
		{
			for (int i = 0; i < alphabet.Length; i++) 
			{
				Console.WriteLine (alphabet[i]);	

				// TODO: Ausgabe anpassen wie auf Übungszettel beschrieben und in Prozent angeben lassen
			}
		} // Ende
	}
}
