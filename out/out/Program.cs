using System;

namespace out
{
	class MainClass
	{
		static void readPerson ( out string name, out int age )
		{
			name = readString ( "Enter your name : " ) ;
			age = readInt ( "Enter your age : ", 0, 100 ) ;
		}


		public static void Main(string[] args)
		{

			string name ;
			int age ;
			readPerson ( out name, out age ) ;		
		
		}
	}
}
