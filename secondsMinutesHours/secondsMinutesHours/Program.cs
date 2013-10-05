using System;

namespace WikiExercise
{
	class Program
	{
		static void Main(string[] args)
		{

			//typing in hours and declare variable h
			Console.WriteLine("Please type in the hours:");
			string hours = Console.ReadLine();
			int h = int.Parse(hours);

			//typing in minutes and declare variable m
			Console.WriteLine("Please type in the minutes:");
			string minutes = Console.ReadLine();
			int m = int.Parse(minutes);

			//typing in minutes and declare variable s
			Console.WriteLine("Please type in the seconds:");
			string seconds = Console.ReadLine();
			int s = int.Parse(seconds);

			//doing the math and writing the seconds to the console
			int secondstotal = (h * 60 * 60) + (m * 60) + s;
			Console.WriteLine("There are " + secondstotal + " seconds");


			//Starting part 2

			//typing in the total amount of seconds
			Console.WriteLine("type in the seconds:");
			string userseconds = Console.ReadLine();
			//getting an integer from the user input
			int totalseconds = int.Parse(userseconds);

			//Doing the math for hours
			int hr = totalseconds / (60 * 60);
			//Showing the user the hours
			Console.WriteLine("There are " + hr + " hours");



			//getting the rest seconds from hours
			int resthr = totalseconds % (60 * 60);
			//doint the math for mins
			int mins = resthr / 60;
			//showing the user the minutes
			Console.WriteLine(mins + " minutes ");

			//getting the rest seconds from minutes
			int restsec = resthr % 60;
			//showint the user the seconds left
			Console.WriteLine("and " + restsec + " seconds in " + totalseconds + " seconds!");


			//let the console stay
			Console.ReadLine();

		}
	}
}
