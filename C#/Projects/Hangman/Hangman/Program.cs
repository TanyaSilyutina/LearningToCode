using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman!\n");
            Console.Write("Enter your secret word: ");
            string wordInput = Console.ReadLine();

            Hangman hangmanObject = new Hangman(wordInput);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Guess the word!\n");
                Console.WriteLine(hangmanObject.GetWordToBeDisplayed() + "\n");
                Console.WriteLine("Words Used: " + hangmanObject.GetUsedLettersToBeDisplayed());
                Console.WriteLine("Attempts Remaining: " + hangmanObject.Attempts + "\n");

                if(hangmanObject.IsGameOver())
                    break;

                Console.Write("Enter your guess: ");
                char enteredLetter = Console.ReadKey().KeyChar;

                hangmanObject.LetterExistsCheck(enteredLetter);
            }

            if (hangmanObject.HasWon == true)
                Console.WriteLine("\nYou have won the game! :)");
            else
                Console.WriteLine("\nYou have lost the game! :(");
        }
    }
}
