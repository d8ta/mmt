using System;

namespace DanielKontoUebung
{
	// Status die das Konto haben kann
	enum KontoStatus
	{
		Aktiv,
		Geschlossen,
		Gesperrt,					
		Minus
	} ; 

	// Klasse für Konto anlegen
	class Konto				
	{								
		// Membervariablen anlegen
		public string name;
		public string nachname;					
		public int kontonummer;
		public decimal kontostand;
		public KontoStatus status;

		// Konstruktor erstellen
		public Konto (string name, string nachname, int kontonummer, decimal kontostand, KontoStatus status)
		{
			this.name = name;
			this.nachname = nachname;
			this.kontonummer = kontonummer;
			this.kontostand = kontostand;
			this.status = status;
		}
	}

	// Main Methode
	class MainClass
	{
		public static void Main ()
		{
			// Neuen Zustand "Überzogen" einfügen und nutzen (Methoda dafür schreiben)
			KontoStatus Ueberzogen;
			Ueberzogen = KontoStatus.Minus;

			Konto DanielKonto = new Konto ("Daniel", "Raudschus", 161786, 328, Ueberzogen);

			// Gib Kontonumme, Status und Kontostand aus
			Console.WriteLine ("Kontonummer " + DanielKonto.kontonummer);
			Console.WriteLine (DanielKonto.status);
			Console.WriteLine (DanielKonto.kontostand + " €");
		
		}
	}
}
