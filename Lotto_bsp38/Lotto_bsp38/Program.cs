using System;
using System.Linq;

// TODO: Dublikateingabe beim User muss noch her!!
// n mal tips abgeben können

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


		// Usereingabe Zahl zwischen 1 - 45
		static void UserInput()
		{
			Console.WriteLine ("LOTTO\ntype in your numbers (between 1 and 45)\n" +
				"Push ENTER after every number:");
			for (int i = 0; i < UserNumbers.Length; i++) { 	
				int rollNumbers = checkUserInput (1, 45);
				UserNumbers [i] = rollNumbers;
				bool dublicat = true;
				do {                            
					dublicat = false;
					for (int j = 1; j < i + 1; j++){
						for (int k = j; k < i + 1; k++){
						if (UserNumbers[j - 1] == UserNumbers[i]) {
							Console.WriteLine("Sie dürfen pro Tipp keine doppelten Zahlen eingeben.\nBitte geben Sie den Tipp nochmal ein.");
							UserNumbers [i] = rollNumbers;
							dublicat = true;
						}
						}
					}
				} while (dublicat == true && i != 0);
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
