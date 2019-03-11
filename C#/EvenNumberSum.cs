using System;

namespace EvenNumberSum
{
  class Program
  {
	static void Main(string[] args)
	{
	  int input;
	  int result = 0;

	  Console.WriteLine("Enter a number: ");
	  input = int.Parse(Console.ReadLine());

	  for (int i = 0; i <= input; i+=2)
	  {
		result += i;
		Console.Write(i + " ");
	  }

	  Console.WriteLine("Answer is " + result);
	  
	}
  }
}