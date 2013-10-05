using System;


	class MainClass
	{
		public static void Main (string[] args)
		{
		/* 1. (1P) Schreibe ein Programm, das deinen Vornamen und deinen Nachnamen in zwei string-Variablen einliest.
		 * Danach soll eine scho ̈n formatierte Begru ̈ßung erfolgen (mit Rahmen rundherum, oder unter- strichen etc...).
		 */

		// Benutzer soll Vor- und Nachname eintragen
		Console.WriteLine ("Tragen Sie Ihren Vornamen ein:");
		String userName = Console.ReadLine ();
		Console.WriteLine ("Tragen Sie Ihren Nachnamen ein:");
		String userSurname = Console.ReadLine ();

		Console.WriteLine ();

		// Schreibe den Benutzernamne in die Konsole
		Console.WriteLine ("[Hallo " + userName + " " + userSurname + ". Willkommen beim Studiengang MMT]");

		}
	}

