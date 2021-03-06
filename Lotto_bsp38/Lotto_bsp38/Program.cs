using System;
using System.Linq;

namespace Lotto_bsp38
{
	class MainClass
	{

		static int[] LottoNumbers = new int[6];
		static int[] UserNumbers = new int[6];

		// Main
		public static void Main (string[] args)
		{
			AmountOfUserTips ();
		} // Ende Main



		// Ziehe eine Zahl zwischen min. und max.
		static int RandomNumbers (int min, int max)
		{
			Random random = new Random ((int)DateTime.Now.Ticks);
			return random.Next (min, max);
		} // Ende


		// Random Nummern in Array mit Größe 6 schreiben
		static void LottoArray()
		{
			int checkForDublicats = 0;
			Random randomNumber = new Random();
			for (int i = 0; i < LottoNumbers.Length; )
			{
				checkForDublicats = randomNumber.Next(1, 45);
				while (!(LottoNumbers.Contains(checkForDublicats)))
				{
					LottoNumbers[i] = checkForDublicats;
					i++;
				}
			}
			Console.WriteLine ("\nThe Lottery numbers are  : ");
			for (int j = 0; j < LottoNumbers.Length; j++) {
				Console.Write (LottoNumbers[j] + ", ");
			}
		}


		// Eingabeprüfung und Hinweis bei Fehler
		static int checkUserInput (int min, int max)
		{
			bool inputIsOk;
			int userInput;
			do {
				inputIsOk = int.TryParse (Console.ReadLine (), out userInput);
				if ((inputIsOk == true) && (userInput >= min) && (userInput <= max)){
					inputIsOk = true;
				} else {
					inputIsOk = false;
					Console.WriteLine ("your input is wrong, please try again");
				}
			} while (inputIsOk == false);
			return userInput;
		} // Ende



		// Funktion für n-Tips
		static void AmountOfUserTips ()
		{
			Console.WriteLine ("Type in how many tip you want to do:");
			int numOfTips = checkUserInput (1, 1000);
			for (int i = 0; i < numOfTips; i++) {
				UserInput ();
				LottoArray ();
				Console.WriteLine("\tyour stats are: " + CompareUserAndRandomnum ());
			}
		}

		// TODO: infinit loop bei doppelter usereingabe verhindern!!


		// Usereingabe Zahl zwischen 1 - 45
		static void UserInput ()
		{
			Console.WriteLine ("LOTTO" +
				"\ttype in your numbers (between 1 and 45)\n" +
				"\tPush ENTER after every number.\n" +
				"\tOnly unique numbers are allowed.\n" +
				"\tIf you give in a dublicat number the program will not store it an run\n" +
				"\tuntil it has 6 unique numbers from you!.");
			for (int i = 0; i < 6; i++) { 	
				int rollNumbers;
				do
				{
					rollNumbers = checkUserInput (1, 45);
				} while ((UserNumbers.Contains (rollNumbers)));
				UserNumbers [i] = rollNumbers;
			}
			Console.WriteLine ("\nYour numbers are  : ");
			for (int j = 0; j < UserNumbers.Length; j++) {
				Console.Write (UserNumbers [j] + ", ");
			}
		} // Ende


		// Auswertung
		static int CompareUserAndRandomnum ()
		{
			int status = 0;
			for (int i = 0; i < LottoNumbers.Length; i++) 
			{
				for (int j = 0; j < UserNumbers.Length; j++)
				{
					if (LottoNumbers[i] == UserNumbers[j]) 
					{
						status = status + 1;
					} 
				}
			}  return status;
		} // Ende
	}
}
