using System;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();
      
            for(int i = 0; i < charArray.Length / 2; i++)
            {
               char lastLetter = charArray[(charArray.Length - 1) - i];
               charArray[(charArray.Length - 1) - i] = charArray[i];
               charArray[i] = lastLetter;
            }

            foreach (var c in charArray)
            {
                Console.Write(c);
            }

            Console.WriteLine();
        }
    }
}


