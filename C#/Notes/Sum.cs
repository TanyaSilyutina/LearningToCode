using System;

namespace ConsoleApp3
{
  class Program
  {
	static void Main()
	{
	  float inputA, inputB;

	  Console.WriteLine("Enter first number: ");
	  inputA = float.Parse(Console.ReadLine());

	  Console.WriteLine("Enter second number: ");
	  inputB = float.Parse(Console.ReadLine());

	  Console.WriteLine($"The sum of {inputA} and {inputB} is {Sum.CalculateSum(inputA, inputB)}");
	}
  }

  class Sum
  {
	public static float CalculateSum(float a, float b)
	{
	  return a + b;
	}
  }
}
