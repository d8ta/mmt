using System;

interface IBumpable 
{
	void Bump();
	int health { get; set;}
}

class Character 
{
	public string name { get; private set;}

	void Fire()
	{
		Console.WriteLine (name + "bang");
	}

	public Character (string name)
	{
		this.name = name;
	}
}

class Player : Character, IBumpable
{
	public int health { get; set;}
	public Player (string name)
		:base(name)
	{
		health = 100;
	}
}

class NPC : Character 
{

}

class Wall : IBumpable
{

}