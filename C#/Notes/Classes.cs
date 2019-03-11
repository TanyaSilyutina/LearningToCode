using System;

namespace SimpleClass
{
  class Program
  {
	static void Main()
	{
	  // Creates a cat with a default constructor and initializes its data
	  Cat sam = new Cat();
	  sam.name = "sam";
	  sam.age = 16;
	  sam.IsCatOld();

	  // Construct a car with our own constructor and auto initialize data
	  Car car = new Car("Mustang", "Red");
	  car.StartEngine();
	}

	// Classes can have data and methods.
	public class Cat
	{
	  // Class Data
	  public string name;
	  public int age;

	  // Class Method
	  public void IsCatOld()
	  {
		if (this.age > 10)
		{
		  Console.WriteLine($"{this.name} is old!");
		}
		else
		{
		  Console.WriteLine($"{this.name} isn't old!");
		}
	  }	  
	}

	// Classes can have data and methods.
	public class Car
	{
	  // Class Data
	  private string name;
	  private string color;

	  // We create our own constructor here
	  public Car(string name, string color)
	  {
		this.name = name;
		this.color = color;
	  }

	  // Class method
	  public void StartEngine()
	  {
		Console.WriteLine($"{this.name} of the color {this.color} is running!");
	  }
	}
  }
}
