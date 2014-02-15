using System;

// enums halten zustände z.b. hier den zustand des kontos
enum AccountState
{
	New,
	Active,
	UnderAudit,
	Frozen,
	Closed
};

// object
class Account
{
	public AccountState State ;
	public string Name ; 
	public string Address ; 
	public int AccountNumber ; 
	public int Balance ; 
	public int Overdraft ;

	// Konstruktor des Objekts
	public Account (string Name, string Addresse, int AccountNumber, int Balance, int Overdraft)
	{
		this.Name = Name;
		this.Address = Addresse;
		this.AccountNumber = AccountNumber;
		this.Balance = Balance;
		this.Overdraft = Overdraft;
	}
};

// program
class BankProgram
{
	public static void Main ()
	{
		Account DanielsAccount;
		DanielsAccount = new Account ("Daniel", "Berchtesgaden", 161786, 3300, 0); // referenzierung zum object Account
		DanielsAccount.State = AccountState.Active;

		// Call der Methode PrintAccount
		PrintAccount (DanielsAccount);
	
	}
	// Methode die alle Kontodaten ausdruckt
	public static void PrintAccount ( Account a )
	{
		Console.WriteLine ( "Name: " + a.Name );
		Console.WriteLine ( "Address: " + a.Address );
		Console.WriteLine ( "Balance: " + a.Balance );
		Console.WriteLine ( "Status: " + a.State );
	}


}
