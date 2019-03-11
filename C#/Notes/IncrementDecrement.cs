using System;

namespace IncrementDecrement
{
  class Program
  {
	static void Main()
	{
	  int a = 0;
	  int b = 0;

	  /* 
	    There are two types of operators:
		1) Pre-Increment / Post-Increment (++)
		2) Pre-Decrement / Post-Decrement (--)
	  */

	  a++; // a now has the value of 0
	  ++b; // b now has the value of 1

	  Console.WriteLine(a); // a now has the value of 1
	  Console.WriteLine(b); // b still has the value of 1	  
	}
  }
}