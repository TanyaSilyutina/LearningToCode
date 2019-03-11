using TicTacToe;
using System;

namespace Progam
{
  class Program
  {
    static void Main(string[] args)
	{
      // Create a new board object
      Board boardObject = new Board();

      // Draws the board
      boardObject.DrawBoard();

      while (!boardObject.CheckWin())
      {
        if (boardObject.toggle == true)
        {
          Console.Write("Player 1, select your position (X):  ");
        }
        else
        {
          Console.Write("Player 2, select your position (O):  ");
        }

        // Console.Read() returns an ASCII value. 
        // '0' has an ASCII value of 48.
        // Subtracting the read value from '0' will give you the number.
        // Example: '1' (ASCII Value 49) - '0' (ASCII Value 48) = 49 - 48 = 1
        int rowInput = Program.ReadKey();
        int columnInput = Program.ReadKey();

        // Pass in the user entered row and column values to the Board class
        boardObject.ExecuteTurn(rowInput, columnInput);
      }
      
      Console.WriteLine("You have won.");
    }

    static int ReadKey()
    {
      return Console.ReadKey().KeyChar - '0';
    }
  }
}
