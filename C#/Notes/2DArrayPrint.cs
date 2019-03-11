using System;

namespace MyApp1
{
  class Program
  {
	static void Main(string[] args)
	{
	  int[,] Age =
	  {
		{ 1, 2},
		{ 3, 4},
		{ 5, 8}
	  };

	  for(int i = 0; i < Age.GetLength(0); i++)
	  {
		for(int j = 0; j < Age.GetLength(1); j++)
		{
		  Console.Write(Age[i, j] + " ");		  
		}

		Console.WriteLine();    
	  }
    }
  } 
}
