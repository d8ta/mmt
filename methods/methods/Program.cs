using System ;
class MethodDemo
{

	static void addOneToRefParam (ref int i)

	{
		i = i + 5;
		Console.WriteLine ( "i is : " + i ) ;
	}

	public static void Main () {
	
		int test = 75 ;
		addOneToRefParam(ref test);
		Console.WriteLine ( "test is : " + test ) ;

		/* Die Ausgabe lautet:
		 *  "i is : 21" -> addOneToParam(test) ruft die Methode auf und berechnet sie mit test (20) d.h. test = test + 1 = 20;
		 * 
		 * 	"test is : 20" -> ruft einfach die Variable Test auf, int test = 20;
		 * 
		 * Wenn wir -> static void addOneToParam (ref int i) benutzen und ei Methode mit -> adOneToParam(ref test); aufrufen ist das Ergebnis:
		 * 				"i is : 21"
		 * 				"test is : 21" 		-> nun wir eine referenzierung hergestellt
		 */ 

	}




}
