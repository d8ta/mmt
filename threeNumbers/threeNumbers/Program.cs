using System;

namespace threeNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Schreibe ein Programm, das mithilfe von if-Statements drei uber die Tastatur eingegebene Zahlen in aufsteigender Reihenfolge ausgibt.
			//(Berücksichtige auch die Eingabe dreier oder zweiergleicher Zahlen.)

			// tell the user to type in three numbers
			Console.WriteLine("type in your first number:");
			String userNumber1 = Console.ReadLine ();
			Console.WriteLine("type in your second number:");
			String userNumber2 = Console.ReadLine ();
			Console.WriteLine("type in your third number:");
			String userNumber3 = Console.ReadLine ();

			// turn string into numbers
			double num1 = double.Parse (userNumber1);
			double num2 = double.Parse (userNumber2);
			double num3 = double.Parse (userNumber3);

			// if statements n1,n3,n2
			if (num1 > num3 && num3 > num2 && num1 > num2) {
				Console.WriteLine (num1);
				Console.WriteLine (num3);
				Console.WriteLine (num2);
			}
			// if statements n1,n2,n2
			else if (num1 > num2 && num1 > num3 && num2 > num3) {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
			// if statements n2,n1,n3
			else if (num2 > num3 && num3 > num1 && num2 > num1) {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
			// if statements n3,n1,n2
			else if (num3 > num1 && num1 > num2 && num3 > num2) {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
			// if statements n3,n2,n1
			else if (num3 > num2 && num2 > num1 && num3 > num1) {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
			// if statement if two numbers are the same -> n1=n2 > n3
			else if (num1 == num2 && num1 > num3 && num2 > num3) {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
			// if statement if two numbers are the same -> n2=n3 > n1
			else if (num2 == num3 && num2 > num1 && num3 > num1) {
				Console.WriteLine (num2);
				Console.WriteLine (num3);
				Console.WriteLine (num1);
			}
			// if statement if two numbers are the same -> n3=n1 < n2
			else if (num3 == num1 && num3 < num2 && num1 < num2) {
				Console.WriteLine (num2);
				Console.WriteLine (num1);
				Console.WriteLine (num3);
			}
			// if statement if two numbers are the same -> n1=n2 < n3
			else if (num1 == num2 && num1 < num3 && num2 < num3) {
				Console.WriteLine (num3);
				Console.WriteLine (num2);
				Console.WriteLine (num1);
			}
			// if statement if two numbers are the same -> n2=n3 < n1
			else if (num2 == num3 && num2 < num1 && num3 < num1) {
				Console.WriteLine (num1);
				Console.WriteLine (num3);
				Console.WriteLine (num2);
			}
			// if statement if two numbers are the same -> n3=n1 > n2
			else if (num3 == num1 && num3 < num2 && num1 < num2) {
				Console.WriteLine (num2);
				Console.WriteLine (num1);
				Console.WriteLine (num3);
			}

			// if statement if all numbers are the same
			else {
				Console.WriteLine (num1);
				Console.WriteLine (num2);
				Console.WriteLine (num3);
			}
		}
	}
}
