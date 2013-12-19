using System;
using System.IO;

namespace WorkTime_bsp37
{
	class MainClass
	{
		static string fileMessage = string.Empty;
		static string textfile = "/Users/danielraudschus/Documents/C#/Textfiles/work-times.txt";
		static int diff = 0;
		static int diffHours = 0;
		static int diffMins = 0;

		public static void Main (string[] args)
		{
			WorkTimes (textfile);
			WriteWorkTimes ();
		}

		// Textfile einlesen
		static string WorkTimes(string filename)
		{

			try
			{
			StreamReader textreader = new StreamReader(filename);
			while (!textreader.EndOfStream) {
				DiffWorkTimes(textreader.ReadLine());
			}
			textreader.Close();
			} catch (FileNotFoundException) {
				Console.WriteLine ("File not Found!");
			}
			return fileMessage;
		} // Ende
	

		// Differenz zwischen Anfang und Ende errechnen
		static void DiffWorkTimes(string lines)
		{
			int starthours = int.Parse(lines.Substring (0, 2));
			int endhours = int.Parse(lines.Substring (6, 2));
			int startmins = int.Parse(lines.Substring (3, 2));
			int endmins = int.Parse (lines.Substring(9, 2));
			diffMins = (endmins - startmins);
			if (endhours < starthours) {
				diffHours = ((endhours + 24) - starthours);
			} else {
				diffHours = (endhours - starthours);
			}


			Console.WriteLine ("{0}h {1}m", diffHours, diffMins) ;
		}

		// In Textfile schreiben
		static void WriteWorkTimes()
		{
			StreamWriter textwriter = new StreamWriter ("/Users/danielraudschus/Documents/C#/Textfiles/total-work-time.txt"); // Schreit nur die letzte Zeile...
			textwriter.WriteLine ("{0}h {1}m", diffHours, diffMins);
			textwriter.Close ();



		}
	
	}
}
