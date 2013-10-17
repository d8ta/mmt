using System;

namespace booleanAlgebra
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool a = true;
			bool b = false;

			bool c = !(a && b);
			bool d = !a || !b;

			Console.WriteLine ("!(a && b) = " + c.ToString() + "\n!a || !b" + d.ToString());
		}
	}
}
