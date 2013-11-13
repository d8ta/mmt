using System;

namespace tryParseBsp
{
	class MainClass
	{

		// start of methode
		static void increment (int i)
		{
			i++;
			Console.WriteLine ("In der Methode hat i den Werte " + i + "\n");
		} // end of methode



		// ref methode
		static void incrementWithRef (ref int i)
		{
			i++;
		} // end of methode



		// out methode
		static void setVal (out int i)
		{
			i = 5;
		} // end of methode

		›

		// Main starts here 
		public static void Main (string[] args)
		{
			int i = 5;
			increment (i);
			Console.WriteLine ("Ausserhalb der Methode hat i den Werte " + i + "\n");

			// ref ausgabe
			incrementWithRef (ref i);
			Console.WriteLine ("Ausserhalb der Methode hat ref i den Werte " + i + "\n");

			// out ausgabe
			Console.WriteLine ("Gib eine Zahl ein!");
			double d;
			bool bParsingOK = double.TryParse (Console.ReadLine(), out d);
			Console.WriteLine ("Die Eingabe war " + bParsingOK);
		} // end of Main

	}
}
