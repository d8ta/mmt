using System;

// enum
enum AccountState
{
	New,
	Active,
	UnderAudit,
	Frozen,
	Closed
};

// structure
struct Account
{
	public AccountState State ;
	public string Name ; 
	public string Address ; 
	public int AccountNumber ; 
	public int Balance ; 
	public int Overdraft ;
};

// program
class BankProgram
{
	public static void Main ()
	{
		Account RobsAccount ;
		RobsAccount.State = AccountState.Frozen;
		RobsAccount.Name = "Daniel Raudschus";
		RobsAccount.Address = "Berchtesgaden";
		RobsAccount.AccountNumber = 161786;
		RobsAccount.Balance = 20000;
		RobsAccount.Overdraft = 0;

		PrintAccount (RobsAccount);
	}

	public static void PrintAccount ( Account a )
	{
		Console.WriteLine ( "Name: " + a.Name );
		Console.WriteLine ( "Address: " + a.Address );
		Console.WriteLine ( "Balance: " + a.Balance );
	}


}
