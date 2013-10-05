using System;

namespace zweierPotenze
{
	class Program
	{
		static void Main(string[] args)
		{

			int next = 0;

			while (next == 0)
			{
				next = 1;

				Console.WriteLine("This program will gif you the result to any second power of 2 that you type in");
				string power = Console.ReadLine();
				double powerI = double.Parse(power);
				double finNum = Math.Pow(2, powerI);


				// print out the results
				Console.WriteLine("The Result is " + finNum.ToString() + ".");

				// setting next to 0
				next = 0;
			}
		}


	}
}

