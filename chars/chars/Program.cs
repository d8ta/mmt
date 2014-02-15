using System;

namespace chars
{
	class MainClass
	{
		static void addOneToRefParam ( ref int i)
		{
			i = i + 1;
			Console.WriteLine ( "i is : " + i ) ;
		}


			int test = 20 ;
			addOneToRefParam(ref test);
			Console.WriteLine ( "test is : " + test ) ; // Wegen pass by ref wird aus Test = 20 -> 21
		
		}




//		public static void Main (string[] args)
//		{
//			readValue ("Type in your numbers", 0 , 100);
//		}
//
//		static double readValue(string prompt, double low, double high)
//		{
//			double result = 0;
//			do {
//				Console.WriteLine (prompt + " between " + low + " and " + high);
//				string resultString = Console.ReadLine ();
//				result = double.Parse (resultString);
//			} while ((result > low) || (result < high));
//			return result;
//
//		}

	}
}
