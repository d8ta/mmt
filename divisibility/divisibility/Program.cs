using System;

namespace divisibility
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Schreibe ein Programm, das zu einer eingegebenen Zahl ausgibt, ob sie durch 2, 3, 5, 7 teilbar ist.
			// Hinweis: 15 ist durch 3 und 5 teilbar.

			// tell the user to type in a round number
			Console.WriteLine ("type in a round number");
			String userNumber = Console.ReadLine ();
			int num = int.Parse (userNumber);

			// if statement to calculate the outcome of numbers 2, 3, 5, 7
			if (num % 2 == 0) {
				Console.WriteLine("your number is divisible bye " + " 2");
			}
			else if (num % 3 == 0) {
				Console.WriteLine("your number is divisible bye " + " 3");
			}
			else if (num % 5 == 0) {
				Console.WriteLine("your number is divisible bye " + " 5");
			}
			else if (num % 7 == 0) {
				Console.WriteLine ("your number is divisible bye " + " 7");
			} 
			else {
				Console.WriteLine ("your number is a prime number");
			}

			Console.ReadKey ();

		}
	}
}
