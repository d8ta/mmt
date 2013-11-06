/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueo3 bsp14
 */ 

using System;

namespace bsp14
{

	/* 14. (1P)Schreibe eine Funktion isPrime(), die testet, ob eine als Parameter übergebene Zahl eine Primzahl ist.
			 * Die Funktion soll dabei nichts ausgeben, nur einen passenden Rückgabewert liefern.
			 * Hinweis: Eine Primzahl ist eine natürliche Zahl, die neben 1 durch genau eine weitere Zahl teilbar ist.
			 * Schreiben die Main-Methode, welche eine natürliche Zahl einliest, und dann mithilf jeder Funktion ausgibt, 
			 * ob diese Zahl prim oder zusammengesetzt ist.
			 */ 
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (isPrime (16)) {
				Console.WriteLine ("Prime!");
			} else {
				Console.WriteLine ("Not Prime!");
			}

		}



				public static bool isPrime( int num )
				{

				
					for ( int counter = 2; counter < num; counter ++ ) 
					{
						if ( num % counter == 0 ) {
							return false;
					}	
					
			
				}
		
				return true; 
				}

	}
}

