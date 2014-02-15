/* 1310601027, fhs36118
 * Daniel Raudschus
 * ue09 bsp54
 * */

using System;

public interface IAnimal
{
	void makeSound();
}

class Dog : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine("Wuff!");
	}
}

class Cow
{
	public void makeSound()
	{
		Console.WriteLine("Moo!");
	}
}

class Cat : IAnimal
{
	public void makeSound()
	{
		Console.WriteLine("Miau!");
	}
}
class Frog
{
	public void makeSound()
	{
		Console.WriteLine("quack!");
	}
}



class AnimalDemo
{
	public static void Main()
	{
		Cat Katze1 = new Cat ();
		Dog Wuffie = new Dog ();

		Wuffie.makeSound ();
		Katze1.makeSound ();
	}

}