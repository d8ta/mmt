using System ;
class MethodDemo
{
	/*  i.e.
	static void silly ( int i, int j)
	{
		Console.WriteLine ( "i is : " + i.ToString() + " and j is: " + j.ToString());
	}
	public static void Main ()
	{
		silly ( 155, 3 ) ;
		silly ( 33, 78 ) ;
	}
	 */


	static void powerOfTwo (double x, double y){

		double powerXtoY = x * y;

		Console.WriteLine(x.ToString() + " to the power of " + y.ToString() + " is " + powerXtoY.ToString());
	}

	public static void Main () {
	
		powerOfTwo (5, 5);
		powerOfTwo (125, 12345);

	}




}

