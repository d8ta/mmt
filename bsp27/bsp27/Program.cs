
using System;

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
		// sets the board with 3 constant variables (static can be called from everywhere inside the program)
		static int rowOne = 0;
		static int rowTwo = 0;
		static int rowThree = 0;



		// start of function Main
		public static void Main (string[] args)
		{
			Console.WriteLine("We play NIM, lets start the game\n" +
				"This is the startconfiguration");


			// ask about the names 
			Console.WriteLine ("Please give in the name of player one:");
			String nameOne = Console.ReadLine ();
			Console.WriteLine ("Please give in the name of player two:");
			String nameTwo = Console.ReadLine ();

			Console.WriteLine ("\n Now set the amount of matches for each stack\n" +
				"Set the matches for the first stack (advice: set it to 1)");
			// first stack
			rowOne = checkUserInput (0, int.MaxValue);

			Console.WriteLine ("\n Set the matches for the second stack (advice: set it to 2)");
			// first stack
			rowTwo = checkUserInput (0, int.MaxValue);

			Console.WriteLine ("\n Set the matches for the second stack (advice: set it to 3)");
			// first stack
			rowThree = checkUserInput (0, int.MaxValue);

			// call the boards and matches
			showBoard (rowOne);
			showBoard (rowTwo);
			showBoard (rowThree);

			// first turn
			Console.WriteLine ("Player " + nameOne + ", your turn. Choose the row and the amount of matches you want to remove\n" +
			                   "start bye choosing the row:");
			int chooseRow = int.Parse (Console.ReadLine());
			turn (Console.ReadLine(chooseRow))
			int removeMatches = int.Parse (Console.ReadLine());


		}
		// end of Main



		// function turn
		static int turn (int row)
		{
			if (row == 3 )
			{
				rowThree = rowThree - match;
			} return row;
 		}



		// function checkUserInput
		static int checkUserInput (int min, int max)
		{
			bool userInputParse;
			int intUserInput;

			do {
				userInputParse = int.TryParse (Console.ReadLine (), out intUserInput);
			
				if ((userInputParse == true) && (intUserInput >= min) && (intUserInput <= max))
					userInputParse = true;
				else {
					userInputParse = false;
					Console.WriteLine ("This value is invalid!");
				}
			} while (userInputParse == false);
			return intUserInput;
		}
		// end of function



		// function showBoard
		static int showBoard (int stack)
		{
			Console.WriteLine("");
			for (int match = 0; match < stack; match ++)
			{
				Console.Write ("I");
			} return stack;
		}
		// end of function




	}
}




/* switch statement
		switch (		selection)
		{
			case 1 :
			stackOne ();
			break ;
			case 2 :
			stackTwo () ;
			break ;
			case 3 :
			stackThree () ;
			break ;
			default :
			Console.WriteLine ( "please type in a row and a number") ;
			break ;
		} 


		// Pyramide
		static int printBoard ( int match )
		{
			for (int counter = 0; counter <= match; counter ++)
			{
				Console.WriteLine (" ");
				for (int matchcounter = 0; matchcounter < counter; matchcounter++)
				{
					Console.Write ("I");
				}
			} return match;
		} */

