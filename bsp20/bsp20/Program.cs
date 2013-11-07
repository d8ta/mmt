/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp20
 * */
using System;

namespace bsp20
{
	class MainClass
	{
		// start main function
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type in a number and be amazed!");
			int input = int.Parse (Console.ReadLine());

			numberA (input);
			Console.WriteLine ("\n");
			numberB (input);
			Console.WriteLine ("\n");
			numberC (input);
			Console.WriteLine ("\n");
			numberD (input);
		} 
		// end of main function




		// start function 
		public static void numberA (int userNum)
		{
			for (int counter = 1; counter <= userNum; counter ++) 
			{ 
				Console.WriteLine ();
				for (int innerCounter = 1; innerCounter <= userNum; innerCounter ++)
				{
					Console.Write ("*");
				}
			}
		} 
		// end of function




		// start function
		public static void numberB  ( int userNum )
		{
			for (int counter = 0; counter < userNum; counter ++)
			{
				for (int innerCounter = counter; innerCounter > 0; innerCounter --) 
				{
					Console.Write (" ");
				}

				Console.WriteLine ("*");

			}
		}
		// end of function




		// start function
		public static void numberC  ( int userNum )
		{
			for (int counter = 0; counter < userNum; counter++)
			{
				for (int innerCounter = userNum; innerCounter > counter; innerCounter--)
				{
					Console.Write (" ");
				}

				Console.WriteLine("*");
			}
		}
		// end of function




		// start of function
		public static void numberD (int userNum)
		{
			for (int counter = 0; counter <= userNum; counter++)
			{
				for (int innerCounter = userNum; innerCounter > counter; innerCounter--)
				{
					Console.Write(" ");
				}
				for (int coreCounter = 0; coreCounter < counter; coreCounter++)
				{
					if (coreCounter == 0)
					{
						Console.Write("*");
					}

					else
					{
						Console.Write("**");
					}
				}
				Console.WriteLine();

			}
		}
		// end of function

	}
}
