using System;

class Program
{
	static void Main(string[] args)
	{
		string userInput = "";
		do
		{
			Console.WriteLine("Willst du aufhören?");
			userInput = Console.ReadLine();
		} while ((userInput != "Ja")
		         || (userInput != "Ja!")
		         || (userInput != "ja")
		         || (userInput != "ja.")
		         || (userInput != "Jawohl")
		         || (userInput != "JA")
		         || (userInput != "FIX"));
	}
}
