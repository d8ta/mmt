using System;

namespace TryCatch
{
	class MainClass
	{

		static int age;

		public static void Main (string[] args)
		{
				AgeInput ();
		}


		static void AgeInput()
		{
			try
			{
			Console.WriteLine ("how old are you?");
			String inputAge = Console.ReadLine ();
			age = int.Parse(inputAge);
				Console.WriteLine("Thank you, you are " + age);
			}
			catch (Exception a)
			{
				Console.WriteLine (a.Message);
				AgeInput ();
			}
		} 

	}
}
