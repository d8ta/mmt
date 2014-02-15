using System;

namespace SparbuchClassWdh
{
	enum Monate
	{
		januar,
		februar,
		maerz,
		april,
		mai,
		juni,
		juli,
		august,
		september,
		oktober,
		november,
		dezember
	};

	class Sparbuch
	{
		private decimal kontostand;
		private string vorname;
		private string nachname;
		private uint geburtsjahr;
		private Monate geburtsmonat;
		private uint geburtstag;
	
		// Konstruktor
		public Sparbuch()
	 	{
			kontostand = 0;
			vorname = "Max";
			nachname = "Mustermann";
			geburtsjahr = 1900;
			geburtsmonat = Monate.januar;
			geburtstag = 1;
		}
		public Sparbuch(decimal start, string vorname, string nachname, uint geburtsjahr, Monate geburtsmonat, uint geburtstag) 
		{
			kontostand = start;
			this.vorname = vorname;
			this.nachname = nachname;
			this.geburtsjahr = geburtsjahr;
			this.geburtsmonat = geburtsmonat;
			this.geburtstag = geburtstag;
		}


		// Geld abheben
		public bool abheben(decimal betrag)
		{
			if (kontostand > 0) 
			{
				kontostand -= betrag;	
				return true;
			} 
			else 
			{
				return false;
			}
		}

		// Geld einzahlen
		public void einzahlen (decimal betrag)
		{
			kontostand += betrag;
		}


		// Daten ändern
		public void daten()
		{
			Console.WriteLine ("Möchten Sie Daten (Vorname, Nachname, Geburtsdatum) verändern? (J)a oder (N)ein?");
			string useranswer = Console.ReadLine ();
			if (useranswer == "J" || useranswer == "j") {
				Console.WriteLine ("Was möchten Sie verändern? Drücken Sie:\n" +
					"(1): Vorname verändern\n" +
					"(2): Nachname verändern\n" +
					"(3): Geburtsdatum verändern");
				string usernum = Console.ReadLine ();
				int num = int.Parse (usernum);

				switch (num) {
				case 1:
					Console.WriteLine ("Geben Sie den neuen Vornamen ein:");
					string inputVorname = Console.ReadLine ();
					this.vorname = inputVorname;
					Console.WriteLine ("Möchten Sie weitere Daten verändern? (J)a oder (N)ein?");
					string answer1 = Console.ReadLine ();
					if (answer1 == "J" || answer1 == "j") {
						this.daten ();
					} else {
//						this.printKontostand ();
					}
					break;

				case 2:
					Console.WriteLine ("Geben Sie den neuen Nachnamen ein:");
					string inputNachname = Console.ReadLine ();
					this.nachname = inputNachname;
					Console.WriteLine ("Möchten Sie weitere Daten verändern? (J)a oder (N)ein?");
					string answer2 = Console.ReadLine ();
					if (answer2 == "J" || answer2 == "j") {
						this.daten ();
					} else {
//						this.printKontostand ();
					}
					break;

				case 3:
					Console.WriteLine ("Geben Sie das neue Geburtsjahr als nummer an (1 = Januar, 2 = Februar usw.");
					string inputjahr = Console.ReadLine ();
					int jahr = int.Parse (inputjahr);

					switch (jahr) {
					case 1:
						this.geburtsmonat = Monate.januar;

					case 2:
						this.geburtsmonat = Monate.februar;

					case 3:
						this.geburtsmonat = Monate.maerz;

					case 4:
						this.geburtsmonat = Monate.april;

					case 5:
						this.geburtsmonat = Monate.juni;

					case 6:
						this.geburtsmonat = Monate.juli;

					case 7:
						this.geburtsmonat = Monate.august;

					case 9:
						this.geburtsmonat = Monate.september;

					case 10:
						this.geburtsmonat = Monate.oktober;

					case 11:
						this.geburtsmonat = Monate.november;

					case 12:
						this.geburtsmonat = Monate.dezember;
						                    ;
					default:
						Console.WriteLine ("Falsche eingabe");
						break;
					}

					break;

				default:
					Console.WriteLine ("Wrong number!");
					break;
				}
			} else {
//				this.printKontostand ();
			}

		}

		// Drucken
		public void printKontostand()
		{
			Console.WriteLine ("Aktueller Kontostand: " + kontostand);
			Console.WriteLine ("Vorname: " + vorname);
			Console.WriteLine ("Nachname: " + nachname);
			Console.WriteLine ("Geburtsdatum: " + geburtsjahr + "\\" + geburtsmonat + "\\" + geburtstag);
			Console.WriteLine ("\n ------------------------------------------------------------------------\n");
		}


	}

	class Programm
	{
		public static void Main()
		{


			Sparbuch SB1 = new Sparbuch(3500, "Anne", "Raudschus", 1982, Monate.juni, 17);
			Sparbuch SB2 = new Sparbuch();
			Sparbuch SB3 = new Sparbuch (350, "Daniel", "Raudschus", 1979, Monate.dezember, 25);

			SB1.printKontostand();
//			SB2.printKontostand();
//			SB3.printKontostand ();

			SB1.daten ();

			SB1.printKontostand ();
		}
	}
}



