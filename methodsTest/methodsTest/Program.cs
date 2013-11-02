using System ;
class MethodDemo
{


	// the main method
	static void yourAge (int age)

	{
		Console.WriteLine ( "you are " + age + " years old." ) ;
	}


	// another method for setting the name
	static void yourName (string name)
	{
		Console.WriteLine ("your name is " + name);
	}


	// another method for setting the age 
	static void personInfo (out string name, out int age) 
	{
		name = yourName ( "Enter your name : " ) ;
		age = yourAge ( "Enter your age : ", 0, 100 ) ;
	}


	// call the method here by create the int and the string and set them!
	public static void Main () 
	{

		string name;
		int age;
		// calling the method
		personInfo (out name, out age);

	}

}
