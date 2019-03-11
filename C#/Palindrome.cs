using System;

namespace Palindrome
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a word: ");

      string userInput = Console.ReadLine();
      bool isPalindrome = true;
      int maxIndex = userInput.Length - 1;

      for (int i = 0; i < userInput.Length / 2; i++)
      {
        char checkingBack = userInput[maxIndex - i];
        if (Char.ToUpper(userInput[i]) != Char.ToUpper(checkingBack))
        {
          isPalindrome = false;
          break;
        }
      }

      if(isPalindrome)
        Console.WriteLine("This word is a Palindrome.");
      else
        Console.WriteLine("This word is not a Palindrome.");
    }
  }
}
