/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp08
 * */

using System;

namespace ue02_bsp01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 8. (1P) Schreibe ein Programm, das die ASCII-Codes der Zeichen ’M’, ’m’, ’t’ ausgibt. Danach sollen die ASCII-Codes 83, 117, 112, 101, 114, 33
			 * dekodiert und als Zeichen ausgegeben werden. Arbeite mit dem expliziten Type-Casting zwischen char und int oder der Methode Convert.ToChar().
			 */

			// input as variables
			char char1 = 'M';
			char char2 = 'm';
			char char3 = 't';

			int num1 = 83;
			int num2 = 117;
			int num3 = 112;
			int num4 = 101;
			int num5 = 114;
			int num6 = 33;


			// convert characters to integer variables 
			int castChar1 = (int)char1;
			int castChar2 = (int)char2;
			int castChar3 = (int)char3;

			// convert the numbers to characters
			char castNum1 = (char)num1;
			char castNum2 = (char)num2;
			char castNum3 = (char)num3;
			char castNum4 = (char)num4;
			char castNum5 = (char)num5;
			char castNum6 = (char)num6;


			// print the cast characters to the console
			Console.WriteLine ("You get the following ASCII codes: \n" +
			                   "M = {0}, m = {1}, t = {2}", castChar1, castChar2, castChar3);


			// print the cast numbers to the console
			Console.WriteLine ("The character for the numbers are \n" +
			                   "83 = {0}, 117 = {1}, 112 = {2}, 101 = {3}, 114 = {4}, 33 = {5}", castNum1, castNum2, castNum3, castNum4, castNum5, castNum6);
		}
	}	 
}