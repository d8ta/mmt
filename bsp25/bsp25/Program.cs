using System;

namespace bsp25
{
				/* 25.(4P) Schreibe ein Programm mit einer Methode, die eine Sanduhr 5n-mal nebeneinander ausgibt;
				 * also für n = 3 (Anzahl der Sanduhren) und b = 5 (Breite einer Sanduhr)
				 */ 


	class MainClass
	{

		static int b = 0;
		static int n = 0;

		// function main
		public static void Main (string[] args)
		{
			hourglass (4);
		}
		// end of main




		// function userInput
		static void userInput () 
		{
			Console.WriteLine ("Type in n and m.\n" +
			                   "n is the amoung of hourglasses and b is the width of each hourglass:\n\n" +
			                   "Start with n (amount of hourglasses):");
			n = checkUserInput(1, int.MaxValue);

			Console.WriteLine ("Now type in b (width of hourglass):");
			b = checkUserInput(1, int.MaxValue);
		}
		// end of function



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





		// start of function
		static void hourglass (int n)
		{
			// part 1
			for (int lineCounter = n; lineCounter > 0; lineCounter--) 
			{
				Console.WriteLine(" ");
			for (int counter = 0; counter <= lineCounter; counter++) 
				{
					Console.Write (" ");
				}
				for (int starCounter = n; starCounter > lineCounter; starCounter--) 
				{
					if (starCounter == 0)
					{
						Console.Write("#");
					}

					else
					{
						Console.Write("@@");
					}
				}
			}

			// part 2
			for (int lineCounter = 0; lineCounter < n; lineCounter++)
			{
				Console.WriteLine(" ");
				for (int counter = n; counter > lineCounter; counter--)
				{
					Console.Write(" ");
				}
				for (int starCounter = 0; starCounter <= lineCounter; starCounter++)
				{
					if (starCounter == 0)
					{
						Console.Write("*");
					}

					else
					{
						Console.Write("**");
					}
				}

			}
		}
		//end of function



		// function amountOfHourGlasses
		static void amountOfHourGlasses()
		{
	
		}

	}
}


