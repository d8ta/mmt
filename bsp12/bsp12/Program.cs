/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp12
 * */

using System;

namespace bsp12
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* 12.(2P) Eine gegebene Zahl wird zuerst mit 2 multipliziert, das Produkt mit 3, und so weiter bis 10. 
			 * Das Ergebnis wird dann durch 2 geteilt, der Quotient durch 3, etc. bis zur Division durch 10. 
			 * Am Ende sollte wieder die ursprüngliche Zahl stehen.
			 * Schreibe ein Programm, das eine Zahl einliest, und dann den Zapfen ausgibt.
			 * */

			// ask user to type in the numbers
			Console.WriteLine ("Please type in a number, the programm will multiply it from 2 - 10. \n" +
			"In the second step the programm will divide it from 2 - 10 to give the original number back. \n" +
			"Lets try it! \n\n" +
			"type in any number you like:");

			String userNumber = Console.ReadLine ();
			double num = double.Parse (userNumber);

			// create a counter
			for (int counter = 2; counter <= 10; counter ++) {
			
				// multiplication loop
				while (counter <= 10) {

					double multiNum = num * counter;
					Console.WriteLine(num.ToString() + " * " + counter.ToString() + " = " + multiNum);

					num = multiNum;
					counter ++;
				}
			}

			for (int counter = 10; counter >= 2; counter --) {

				// division loop
				while (counter >= 2) {

					double divNum = num / counter;
					Console.WriteLine(num.ToString() + " / " + counter.ToString() + " = " + divNum);

					num = divNum;
					counter --;
				}

			}





		}
	}
}
