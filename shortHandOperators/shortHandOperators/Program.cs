using System;

namespace shortHandOperators
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 155;

			Console.WriteLine (i += 5);
			Console.WriteLine (i -= 5);
			Console.WriteLine (i *= 5);
			Console.WriteLine (i /= 5);
			Console.WriteLine (i %= 5);

		}
	}
}
