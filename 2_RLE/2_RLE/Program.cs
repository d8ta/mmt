using System;

class MainClass
{
	const int CODE_OF_A = 65;	// ASCII code for A 
	const int CODE_OF_a = 97;	// ASCII code for a

	static int[] uppercase = new int[26];
	static int[] lowercase = new int[26];	// Arrays for upper and lowercase alphabet


	static void Userinput ()
	{
		string stringinput = Console.ReadLine ();
		for (int i = 0; i < stringinput.Length; i++)
		{         
			for (int j = 0; j < uppercase.Length; j++)
			{
				if (stringinput[i] == (char) j + CODE_OF_A) // cast from int to character!
				{
					uppercase [j]++;
				}
				else if (stringinput[i] == (char) j + CODE_OF_a) 
				{
					lowercase [j]++;
				}
			}
		}
	}




	public static void Main (string[] args)
	{
		Userinput ();
	}
}
