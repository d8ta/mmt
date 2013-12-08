using System;

namespace TestingArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyTestArray ();
		}


		static void MyTestArray()
		{
			int[] myarray = new int[2];
			// array befüllen und printen
			for (int i = 0; i < myarray.Length; i++) 
			{
				myarray [i] = i;
				Console.WriteLine (myarray[i]);
			} 
		}
	}
}
