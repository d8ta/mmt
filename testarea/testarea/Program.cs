using System;

class Program
{

	// Check if z is a power of ten.
	static bool isPowerOfTen(uint z)
	{
		bool powerOfTen = true;
		if (z == 0)
		{
			powerOfTen = false;
		}

		while (z > 1)
		{
			uint remainder = z % 10;
			if (remainder != 0)
			{
				powerOfTen = false;
				break;
			}
			z = z / 10;
		}
		return powerOfTen;
	}


	static void Main(string[] args)
	{
		Console.WriteLine("Is 1000 a power of ten? " + isPowerOfTen(1000));
	}
}