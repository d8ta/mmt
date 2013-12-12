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
		static int[] AddingHours = new int[5];

		public static void Main (string[] args)
		{
			WorkTimes (textfile);
			WriteWorkTimes ();
			//AddTimes (textfile);
			//WriteArray ();

		}

		// Textfile einlesen
		static string WorkTimes(string filename)
		{
			StreamReader textreader = new StreamReader(filename);
			fileMessage = string.Empty;
			while (!textreader.EndOfStream) {
				DiffWorkTimes(textreader.ReadLine());
			}
			textreader.Close();
			return fileMessage;
		} // Ende



		// Textfile einlesen
		static string AddTimes(string filename)
		{
			StreamReader timereader = new StreamReader(filename);
			fileMessage = string.Empty;
			while (!timereader.EndOfStream) {
					fileMessage = timereader.ReadLine ();
			}
			timereader.Close();
			return fileMessage;
		} // Ende


		// Stunden in Array einlesen
		static void WriteArray()
		{
			for (int i = 0; i < AddingHours.Length; i++) {
				AddingHours [i] = int.Parse(fileMessage);
				Console.WriteLine (AddingHours [i]);
			}
		}



		// Differenz zwischen Anfang und Ende errechnen
		static void DiffWorkTimes(string lines)
		{
			int starthours = int.Parse(lines.Substring (0, 2));
			int endhours = int.Parse(lines.Substring (6, 2));
			int startmins = int.Parse(lines.Substring (3, 2));
			int endmins = int.Parse (lines.Substring(9, 2));
			int hours = 0;
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
			StreamWriter textwriter = new StreamWriter ("/Users/danielraudschus/Documents/C#/Textfiles/total-work-time.txt");
			textwriter.WriteLine ("{0}h {1}m", diffHours, diffMins); // TODO: Stunden und Minuten addieren
			textwriter.Close ();
		}
	}
}
