using System;

namespace ConsoleApp4
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isSwitchOn = true;

      while (true)
      {
        if (isSwitchOn == true)
        {
          isSwitchOn = !isSwitchOn;
          Console.WriteLine("Light is on!");
        }
        else
        {
          isSwitchOn = !isSwitchOn;
          Console.WriteLine("Light is off");
        }
      }   
    }
  }
}
