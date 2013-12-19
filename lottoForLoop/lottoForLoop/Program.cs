using System;

namespace lottoForLoop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] Usernumber = new int[6] {1, 2, 3, 4, 5, 6, 7};

				for (int i = 0; i < 6; i++) {

					for (int j = 0; j < 6; j++) {
						if (Usernumber [i] == Usernumber [i -1]) {
							Console.WriteLine ("Keine Doppeleingabe erlaubt, bitte erneut eingeben");
							Usernumber = Console.ReadLine ();	
						}
					}	
				}
		}
	}
}
