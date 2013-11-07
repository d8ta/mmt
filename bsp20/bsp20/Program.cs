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
			Console.WriteLine ("Type in number and be amazed!");
			int input = int.Parse (Console.ReadLine());

		 numberA(input);
		} 
		// end of main function




		// start function 
		public static void numberA (int userNum)
		{
			for (int counter = 1; counter <= userNum; counter ++) 
			{ 
				for (int innerCounter = 1; innerCounter <= userNum; innerCounter ++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
		} 
		// end of function square

}
}
