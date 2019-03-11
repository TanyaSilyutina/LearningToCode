using System;

namespace LogicalOperators
{
  class Program
  {
	static void Main()
	{
	  // Initialize bool with the value true
	  bool SunIsOut = true;
	  bool BirdsAreChirping = true;

	  // NOT Operator
	  if (!SunIsOut)
	  {
		Console.WriteLine("It is still night!");
	  }

	  // NOT EQUALS Operator
	  if (SunIsOut != true)
	  {
		Console.WriteLine("It is still night!");
	  }

	  // EQUALS Operator
	  if (SunIsOut == true)
	  {
		Console.WriteLine("It is day!");
	  }

	  // AND Operator (Both conditions should be true)
	  if (SunIsOut && BirdsAreChirping)
	  {
		Console.WriteLine("It is time to get up");
	  }

	  // OR Operator (Only one condition should be true)
	  if (SunIsOut || BirdsAreChirping)
	  {
		Console.WriteLine("It is time to get up");
	  }
	}
  }
}
