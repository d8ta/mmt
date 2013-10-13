using System;

namespace rightAlign
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string s = "12345";

			int stringLength = s.Length;

			for (int strich = 0; strich < stringLength; strich ++) 
			{
				Console.WriteLine("-");
			}
		}
	}
}
