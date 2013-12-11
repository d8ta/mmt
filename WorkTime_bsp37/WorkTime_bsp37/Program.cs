using System;
using System.IO;

namespace WorkTime_bsp37
{
	class MainClass
	{
		static string fileMessage = string.Empty;

		public static void Main (string[] args)
		{
			WorkTimes ("/Users/danielraudschus/Documents/C#/Textfiles/work-times.txt");

		}

		// Textfile einlesen
		static string WorkTimes(string filename)
		{
			StreamReader textreader = new StreamReader(filename);
			fileMessage = string.Empty;


			while (!textreader.EndOfStream) {
				fileMessage += textreader.ReadLine ();
				fileMessage += '\n';
			}
			textreader.Close();
			Console.WriteLine (fileMessage);
			return fileMessage;
		}
	}
}
