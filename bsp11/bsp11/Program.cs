/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo2 bsp11
 * */

using System;

namespace bsp11

{
	class Program
	{
		static void Main(string[] args)
		{

			/* 11. (2P) Schreibe ein Programm, das die Füllmenge eines liegenden Kreiszylinders berechnet (Formel siehe Wikipedia, Tank-Problem).
			 * Eingabe: L (Lange) in mm, r (Radius) in mm, h (Füllhöhe) in mm, jeweils als Fließkommazahl.
			 */


			//Get the amount of numbers
			Console.WriteLine("Please type in the length, radius and filling heigth of your can.\n The program will tell you the volume" +
				"\n\nStart with the length:\n");
			string userLength = Console.ReadLine();
			double length = double.Parse(userLength);

			if (length <= 0)
			{
				Console.WriteLine ("Your number have to be greater than 0!");
				userLength = Console.ReadLine();
				length = double.Parse(userLength);
			}

			Console.WriteLine("type in the radius:\n");
			string userRadius = Console.ReadLine();
			double radius = double.Parse(userRadius);

			if (radius <= 0)
			{
				Console.WriteLine ("Your number have to be greater than 0!");
				userRadius = Console.ReadLine();
				radius = double.Parse(userRadius);
			}

			Console.WriteLine("type in the filling heigth:\n");
			string userHeigth = Console.ReadLine();
			double fillingHeight = double.Parse(userHeigth);

			if (fillingHeight <= 0)
			{
				Console.WriteLine ("Your number have to be greater than 0!");
				userHeigth = Console.ReadLine();
				fillingHeight = double.Parse(userHeigth);
			}


			// V = r^2 * L (arccos (r-h / r) - (r-h) wurzel 2rh-h^2 / r^2)
			double root = Math.Sqrt(((2 * radius * fillingHeight) - (fillingHeight * fillingHeight))) / (radius * radius);

			double volume = (radius * radius * length) * ((Math.Acos((radius - fillingHeight) / radius) - (radius - fillingHeight) * root));

			volume = volume / 1000;

			Console.WriteLine("The volume of your can is: {0:####.##}",volume);

			/* length: 100
			 * radius: 25
			 * filling heigt: 10
			 * The volume of your can is: 27,96 
			 */

		}
	}
}


