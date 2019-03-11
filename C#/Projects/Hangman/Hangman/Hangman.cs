using System.Collections.Generic;

namespace Hangman
{
    public class Hangman
    {
        public bool HasWon = false;
        public int Attempts = 8;
        private string word;
        private char[] toBeFilledWord;
        private List<char> usedLetters;

        public Hangman(string word)
        {
            this.word = word;
            this.toBeFilledWord = new char[word.Length];
            usedLetters = new List<char>();

            for (int i = 0; i < this.toBeFilledWord.Length; ++i)
            {
                this.toBeFilledWord[i] = '_';
            }
        }

        public string GetWordToBeDisplayed()
        {
            return this.ConvertToDisplayString(this.toBeFilledWord);
        }

        public string GetUsedLettersToBeDisplayed()
        {
            return this.ConvertToDisplayString(this.usedLetters.ToArray());
        }

        public void LetterExistsCheck(char letter)
        {
            bool letterExists = false;

            for (int i = 0; i < this.word.Length; i++)
            {
                if (this.word[i] == letter)
                {
                    this.toBeFilledWord[i] = letter;
                    letterExists = true;
                }
            }

            if (!letterExists)
            {
                --this.Attempts;
                this.usedLetters.Add(letter);
            }
        }

        public bool IsGameOver()
        {
            if (Attempts == 0 || this.word == new string(this.toBeFilledWord))
            {
                if(Attempts == 0)
                    this.HasWon = false;

                return true;
            }

            return false;
        }

        private string ConvertToDisplayString(char[] word)
        {
            string displayWord = string.Empty;

            for (int i = 0; i < word.Length; ++i)
            {
                displayWord += (word[i] + " ");
            }

            return displayWord;
        }
    }
}
