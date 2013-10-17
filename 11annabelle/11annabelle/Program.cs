using System;

namespace bsp11

{
	class Program
	{
		static void Main(string[] args)
		{
			//Get the amount of numbers
			Console.WriteLine("This Program is going to compute the volume of a cylinder.\n Please type in any number standing for the length.");
			string Length = Console.ReadLine();
			double l = double.Parse(Length);

			if (l <= 0)
			{
				Console.WriteLine ("Your number have to be greater than 0!");
				Length = Console.ReadLine();
				l = double.Parse(Length);
			}

			Console.WriteLine("Now please type in any number standing for the radius.");
			string Radius = Console.ReadLine();
			int r = int.Parse(Radius);

			if (r <= 0)
			{
				Console.WriteLine("Error - please type in a positive Number.");
				Radius = Console.ReadLine();
				r = int.Parse(Length);
			}

			Console.WriteLine("Last but not least please type in any number for the heigth.");
			string Heigth = Console.ReadLine();
			int h = int.Parse(Heigth);

			if (h <= 0)
			{
				Console.WriteLine("Error - please type in a positive Number.");
				Heigth = Console.ReadLine();
				h = int.Parse(Heigth);
			}

			double root = Math.Sqrt(((2 * r * h) - (h * h)) / (r * r));

			// Formula: V = r^2 L \left(\arccos\left(\frac{r - h}{r}\right) - (r - h) \frac{\sqrt{2rh - h^2}}{r^2}\right)
			double V = (r * r * l) * ((Math.Acos((r - h) / r) - (r - h) * root));
			V = V / 1000;

			Console.WriteLine("The result is {0:####.##} mm^3",V);
		}
	}
}


