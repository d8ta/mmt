using System;

// TODO: Falscheingaben korrigieren;
namespace bsp27
{
	/*	27. (5P) Implementiere folgende Variante des Spieles Nim:
			• Nim ist ein Spiel für zwei Spieler.
			• Zu Beginn gibt es drei Haufen mit Streichhölzern:
					am ersten Haufen befinden sich z.B. drei Streichhölzer, am zweiten fünf, am dritten sieben
			  		(andere Startkonfigurationen sollen möglich sein).

			• Die Spieler sind abwechselnd am Zug.
			• Ist ein Spieler am Zug, wählt er einen nicht leeren Haufen und nimmt eine beliebige Anzahl Streichhölzern – mindestesten jedoch eines – von diesem weg.
			• Es gewinnt derjenige Spieler, der das letzte Streichholz nimmt.
		*/
	class MainClass
	{
		// sets of static variables that can be called from everywhere inside the program)
		static int rowOne = 0;
		static int rowTwo = 0;
		static int rowThree = 0;
		static String name1 = "";
		static String name2 = "";
		// start of function Main
		public static void Main (string[] args)
		{
			Console.WriteLine ("We play NIM, lets start the game!\n");

			// collect the playernames
			names ();
			Console.Clear ();
			// call function setup to ask about the names and stacks
			setup ();		
			Console.Clear ();
			// call the boards and matches
			showBoard (rowOne);
			showBoard (rowTwo);
			showBoard (rowThree);

			// call the playrounds
			rounds ();
		}
		// end of Main
		// function rounds
		static void rounds ()
		{
			bool isOk = true;
			do {
				turnPlayer1 ();
				if (rowOne <= 0 && rowTwo <= 0 && rowThree <= 0) {
					isOk = false;
					Console.WriteLine ("\n" + name1 + " WINS!!");
					break;
				}
				turnPlayer2 ();
				if (rowOne <= 0 && rowTwo <= 0 && rowThree <= 0) {
					isOk = false;
					Console.WriteLine ("\n" + name2 + " WINS!!");
					break;
				}
			
			} while (isOk == true); 
		}
		// end of function
		// function name
		static void names ()
		{
			Console.WriteLine ("Please give in the name of player one:");
			name1 = Console.ReadLine ();
			Console.WriteLine ("Please give in the name of player two:");
			name2 = Console.ReadLine ();

		}
		// end of function
		// function setup
		static void setup ()
		{
			Console.WriteLine ("Now set the amount of matches for each stack\n" +
			"Set the matches for the first stack (i.e. 3)");
			// first stack
			rowOne = checkUserInput (0, int.MaxValue);

			Console.WriteLine ("Set the matches for the second stack (i.e. 4)\n");
			// second stack
			rowTwo = checkUserInput (0, int.MaxValue);

			Console.WriteLine ("\n Set the matches for the second stack (i.e. 5)\n");
			// third stack
			rowThree = checkUserInput (0, int.MaxValue);
		}
		// end of function
		// function turnPlayer1
		static void turnPlayer1 ()
		{
			Console.WriteLine ("\n\n" + name1 + " it is your turn. Choose the row and the amount of matches\n" +
			"you want to remove\n" +
			"what is your row?");
			int chooseRow = checkUserInput (1, 3);

			Console.WriteLine ("how many matches do you want to remove?");
			int removeMatches = checkUserInput (1, int.MaxValue);


		

			switch (chooseRow) {
			case 1:
				rowOne -= removeMatches;
				break;

			case 2:
				rowTwo -= removeMatches;
				break;

			case 3:
				rowThree -= removeMatches;
				break;
			}

			// show new stacks
			showBoard (rowOne);
			showBoard (rowTwo);
			showBoard (rowThree);
		}
		// end of function
		// function turnPlayer2
		static void turnPlayer2 ()
		{
			Console.WriteLine ("\n\n" + name2 + " it is your turn. Choose the row and the amount of matches\n" +
			"you want to remove\n" +
			"what is your row?");
			int chooseRow = checkUserInput (1, 3);

			Console.WriteLine ("how many matches do you want to remove?");
			int removeMatches = checkUserInput (1, int.MaxValue);

			switch (chooseRow) {
			case 1:
				rowOne -= removeMatches;
				break;

			case 2:
				rowTwo -= removeMatches;
				break;

			case 3:
				rowThree -= removeMatches;
				break;

			}

			// show new stacks
			showBoard (rowOne);
			showBoard (rowTwo);
			showBoard (rowThree);
		}
		// end of function
		// function checkUserInput
		static int checkUserInput (int min, int max)
		{
			bool inputIsOk;
			int userInput;

			do {
				inputIsOk = int.TryParse (Console.ReadLine (), out userInput);

				if ((inputIsOk == true) && (userInput >= min) && (userInput <= max))
					inputIsOk = true;
				else {
					inputIsOk = false;
					Console.WriteLine ("This value is invalid!");
				}
			} while (inputIsOk == false);
			return userInput;
		}
		// end of function
		// function showBoard
		static int showBoard (int stack)
		{
			Console.WriteLine ("");
			for (int match = 0; match < stack; match++) {
				Console.Write ("I");
			}
			return stack;
		}
		// end of function
	}
}