using System;

public interface IAnimal
{
	void makeSound();
}

class Dog : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine ("Wuff, wuff");
	}
}

class Cat : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine ("Meowwwwww");
	}
}

class Cow : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine ("Muuuuhhh");
	}
}

class Frog : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine ("Quack");
	}
}

class Zoo
{
	public static IAnimal getAnimal(string type)
	{
		switch (type) {
		case "dog":
			return new Dog ();
			break;

		case "cat":
			return new Cat();
			break;

		case "cow":
			return new Cow ();
			break;

		case "frog":
			return new Frog();
			break;

		default:
			return null;
			break;
		}
	}
}


class Programm
{
	static void Main()
	{
		Dog Felix = new Dog();
		Cat Lisa = new Cat ();
		Cow Clara = new Cow ();
		Frog Charles = new Frog ();

//		Felix.makeSound ();
//		Lisa.makeSound ();
//		Clara.makeSound ();
//		Charles.makeSound ();

		Zoo.getAnimal ("dog").makeSound();

	}
}