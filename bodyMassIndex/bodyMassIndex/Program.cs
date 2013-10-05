using System;

namespace bodyMassIndex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// write a program that calculates your bodymassindex and give some advice i.e. "eat more" or something
			// fomula for the bmi is BMI = m(mass in kilogram) / l(height in meter)^2


			// type in mass in kilogram & heigth in cm
			Console.WriteLine ("type in your mass in kilogram");
			String userMass = Console.ReadLine ();
			double m = double.Parse (userMass);

			Console.WriteLine ("type in your heigth in cm");
			String userHeigth = Console.ReadLine ();
			double l = double.Parse (userHeigth);

			// turn l from centimeter to meter
			l = l / 100;

			// calculate the bmi
			double bmi = m/(Math.Pow(l, 2));

			// print the bmi into the console
			Console.WriteLine("your bmi is " + bmi);

			// write an if statement to write comments for the calculated bmi status
			// if statment for bmi < 18.5
			if (bmi <= 18.5) {
				Console.WriteLine ("your Index is to low, consult your doctor for further instrunctions or tests");
			}
			// if statment for bmi between 18.5 - 25
			else if (bmi > 18.5 && bmi <= 25) {
				Console.WriteLine ("your index is inside the normal distribution");
			} 
			// if statment for bmi > 25
			else {
				Console.WriteLine ("your index is to high, consult a doctor for further tests and treatment");
			}
		}
	}
}
