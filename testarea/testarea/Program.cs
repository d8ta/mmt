/* 1310601025, fhs36116
 * Ivan Popovic
 * ue06 bsp38
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	class Program
	{
		//Globale Variable der Lottoziehung - dieses Array wird durch die Funktion lottoZiehungFunktion befüllt
		static int[] lottoZiehung = new int[6];


		//Werte die der User eingibt werden hier daraufhin überprüft ob es gültige Integerwerte sind.
		static int userInputInt(int Min, int Max)
		{
			bool userInputParseInt;
			int intUserInput;
			do
			{
				userInputParseInt = int.TryParse(Console.ReadLine(), out intUserInput);

				if ((userInputParseInt == true) && (intUserInput >= Min) && (intUserInput <= Max))
					userInputParseInt = true;
				else
				{
					userInputParseInt = false;
					Console.WriteLine("\a\n**Dieser Wert ist ungültig!");
				}
			}
			while (userInputParseInt == false);
			return intUserInput;

		}

		//Die Funktion welche die Lottozahlen generiert
		static void lottoZiehungFunktion()
		{
			Random random = new Random((int)DateTime.Now.Ticks);
			int rndNum = random.Next(1, 46);
			for (int i = 0; i < lottoZiehung.Length; i++)
			{
				//While -> Contains = checkt ob es keine gleichen Zahlen in der Ziehung gibt
				while (lottoZiehung.Contains(rndNum))
				{
					rndNum = random.Next(1, 46);
				}
				lottoZiehung[i] = rndNum;
			}
		}

		static void tippArrayFuellen(int [,] tipp)
		{
			for (int i = 0; i < tipp.GetLength(0); i++)
			{
				Console.WriteLine("Ihr " + (i + 1) + ". Tipp:");
				for (int j = 0; j < tipp.GetLength(1); j++)
				{
					Console.WriteLine("Geben sie nun bitte die " + (j + 1) + ". Zahl ihres " + (i + 1) + ". Tipps ein");
					int wahlZahl = userInputInt(1, 45);
					tipp[i, j] = wahlZahl;
					bool gleicheNummer = true;
					do{                            
						gleicheNummer = false;
						for (int k = 1; k < j + 1; k++)
						{
							for (int l = k; l < j + 1; l++)
							{
								if (tipp[i, k - 1] == tipp[i, l])
								{
									Console.WriteLine("Sie dürfen pro Tipp keine doppelten Zahlen eingeben.\nBitte geben Sie den Tipp nochmal ein.");
									wahlZahl = userInputInt(1, 45);
									tipp[i, j] = wahlZahl;
									gleicheNummer = true;
								}
							}
						}
					}while (gleicheNummer == true && j != 0);
				}
				Console.Clear();
			}

			for(int i = 0; i < tipp.GetLength(0); i++)
			{
				string tippArrayAusgabe = string.Empty;
				for (int j = 0; j < tipp.GetLength(1); j++)
				{
					tippArrayAusgabe += (tipp[i, j] + ", ");
				}
				Console.WriteLine("Ihr " + (i + 1) + ". Tipp: " + tippArrayAusgabe);
			}

		}

		static void lottoZiehungAusgabe()
		{
			lottoZiehungFunktion();
			string lottoZiehungAusgabe = string.Empty;
			for (int i = 0; i < lottoZiehung.Length; i++)
			{
				lottoZiehungAusgabe += (lottoZiehung[i] + ", ");
			}
			Console.WriteLine("Es wurden folgende Zahlen gezogen: " + lottoZiehungAusgabe);
		}

		static void zahlGetroffenAusgabe(int [,] tipp)
		{
			for (int i = 0; i < tipp.GetLength(0); i++)
			{
				int zahlGetroffenZähler = 0;
				for (int j = 0; j < tipp.GetLength(1); j++)
				{
					for (int k = 0; k < lottoZiehung.Length; k++)
					{
						if (tipp[i, j] == lottoZiehung[k])
						{
							zahlGetroffenZähler += 1;
						}
					}
				}
				Console.WriteLine((i + 1) + ". Tipp: " + zahlGetroffenZähler + " Treffer.");
			}
		}



		static void Main(string[] args)
		{
			Console.WriteLine("Wievie Tipps möchten sie abgeben?");
			int[,] tipp = new int[userInputInt(1, int.MaxValue), 6];
			tippArrayFuellen(tipp);
			lottoZiehungAusgabe();
			zahlGetroffenAusgabe(tipp);
		}
	}
}