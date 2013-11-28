using System;

namespace ArrayUserInput
{
	class Program
	{
		static void Main(string[] args)
		{
			MyArray ();
		}

		static void MyArray()
		{
			Console.WriteLine("enter the length of your array: ");
			int arraylength = checkInput(1, int.MaxValue);
			int[] array = new int[arraylength];

			////filling the array with user input
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("enter a number you wish to hold in your array: ");
				array[i] = checkInput(1, int.MaxValue);

			}
			//printing out the array
			Console.WriteLine("here is your array: ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}
		}


		// check user input for negative numbers or strings
		static int checkInput (int min, int max)
		{
			bool inputIsOK;
			int userInput;

			do {
				inputIsOK = int.TryParse (Console.ReadLine (), out userInput);

				if ((inputIsOK == true) && (userInput >= min) && (userInput <= max)) {
					inputIsOK = true;
				} else {
					inputIsOK = false;
					Console.WriteLine ("try again, your input is wrong!");
				}
			} while (inputIsOK == false);
			return userInput;
		} // end of function

	}

}