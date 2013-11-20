/*
1310601030, fhs36121
Michael Bunk
ue03 bsp25
*/

using System;

class Hourglass
{

	// HAUPTPROGRAMM
	static void Main()
	{

		Console.WriteLine("*** SANDUHR ***");

		Console.Write("\n" + "Breite: ");
		uint size = isValidValue();

		Console.Write("\n" + "Anzahl: ");
		uint input = isValidValue();

		Console.Write("\n");
		hourGlass(size, input);
		Console.Write("\n");

	}

	// ABFRAGE GÜLTIGER WERT
	static uint isValidValue()
	{
		string stringInput;
		uint result;
		bool success = true;

		do
		{
			if (!success)
			{
				Console.Write("Gib einen gültigen Wert ein: ");
			}
			stringInput = Console.ReadLine();
			success = uint.TryParse(stringInput, out result);
		}
		while (!success);

		return result;
	}

	// SANDUHR
	static void hourGlass(uint size, uint i)
	{
		// OBEN
		for (uint line = size; line > 0; line--)
			{
			for (int count = 1; count <= i; count++)
			 {
				for (int blank = 1; blank <= (size - line); blank++)
				{
					Console.Write(" ");
				}
				for (int star = 0; star <= (line * 2 - 1); star++)
				{
					if (star % 2 == 0)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				for (int blank = 1; blank <= (size - line); blank++)
				{
					Console.Write(" ");
				}
			}
			Console.Write("\n");

		}

		// UNTEN
		for (uint line = 2; line <= size; line++)
		{
			for (int count = 1; count <= i; count++)
			{
				for (int blank = 1; blank <= (size - line); blank++)
				{
					Console.Write(" ");
				}
				for (int star = 0; star <= (line * 2 - 1); star++)
				{
					if (star % 2 == 0)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				for (int blank = 1; blank <= (size - line); blank++)
				{
					Console.Write(" ");
				}
			}
			Console.Write("\n");
		}

	}


}

