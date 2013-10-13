/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp01
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
			int convertedChar1 = (int)char1;
			int convertedChar2 = (int)char2;
			int convertedChar3 = (int)char3;

			// convert the numbers to characters
			char convertedNum1 = (char)num1;
			char convertedNum2 = (char)num2;
			char convertedNum3 = (char)num3;
			char convertedNum4 = (char)num4;
			char convertedNum5 = (char)num5;
			char convertedNum6 = (char)num6;

			// TODO dont copy and paste (möglich??)
		
			// print the converted characters to the console
			Console.WriteLine ("The ASCII code for" );


			Console.WriteLine ("The ASCII code for " + char1.ToString() + " is " + convertedChar1.ToString());
			Console.WriteLine ("The ASCII code for " + char2.ToString() + " is " + convertedChar2.ToString());
			Console.WriteLine ("The ASCII code for " + char3.ToString() + " is " + convertedChar3.ToString());

			// print the converted numbers to the console
			Console.WriteLine ("The character for the number " + num1.ToString() + " is " + convertedNum1.ToString());
			Console.WriteLine ("The character for the number " + num2.ToString() + " is " + convertedNum2.ToString());
			Console.WriteLine ("The character for the number " + num3.ToString() + " is " + convertedNum3.ToString());
			Console.WriteLine ("The character for the number " + num4.ToString() + " is " + convertedNum4.ToString());
			Console.WriteLine ("The character for the number " + num5.ToString() + " is " + convertedNum5.ToString());
			Console.WriteLine ("The character for the number " + num6.ToString() + " is " + convertedNum6.ToString());

		}
	}
}
