using System;

class Account  // unterschied zu struct? "struct" statt "class" und AccountStruct als name
{
	public string Name ; };
class StructsAndObjectsDemo
{
	public static void Main () {
		Account RobsAccount ;
		RobsAccount = new Account (); // da class nur eine referenz liefert muss hier noch diese Zeile eingefügt werden
		RobsAccount.Name = "Rob";
		Console.WriteLine ( RobsAccount.Name );
	} 
}