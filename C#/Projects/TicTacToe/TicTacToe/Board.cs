using System;

namespace TicTacToe
{
  class Board
  {
    // 2D array to hold board values
    private char [,] board;
    
    // Flag to toggle between 'X' and 'O'
    public bool toggle;

    // Constructor of board class
    public Board()
    {
      // Initializing 3 by 3 2D board array
      this.board = new char[3,3]
      {
        { ' ', ' ', ' '},
	    { ' ', ' ', ' '},
	    { ' ', ' ', ' '}
      };

      // Give the toggle a starting value
      toggle = true;
    }

    // Draws the TicTacToe board
    public void DrawBoard()
    {
      Console.WriteLine("\nWelcome to Tic-Tac-Toe!\n");
      Console.WriteLine("Enter your input in this format: RowColumn");
      Console.WriteLine("Example: 01\n");

      Console.WriteLine("     |     |     ");
      Console.WriteLine("  {0}  |  {1}  |  {2}  ", this.board[0, 0], this.board[0, 1], this.board[0, 2]);
      Console.WriteLine("_____|_____|_____");
      Console.WriteLine("     |     |     ");
      Console.WriteLine("  {0}  |  {1}  |  {2}  ", this.board[1, 0], this.board[1, 1], this.board[1, 2]);
      Console.WriteLine("_____|_____|_____");
      Console.WriteLine("     |     |     ");
      Console.WriteLine("  {0}  |  {1}  |  {2}  ", this.board[2, 0], this.board[2, 1], this.board[2, 2]);
      Console.WriteLine("     |     |     \n");
    }

    public void ExecuteTurn(int row, int column)
    {
      // Print X and invert the toggle
      if (this.toggle == true)
      {
        this.board[row, column] = 'X';
        this.toggle = !this.toggle;
      }
      // Print O and invert the toggle
      else
      {
        this.board[row, column] = 'O';
        this.toggle = !this.toggle;
      }

      Console.Clear();
      this.DrawBoard();
    }

    // Checks the winning condition
    public bool CheckWin()
    {
      if (this.CheckWinDiagonals() || this.CheckWinRows() || this.CheckWinColumns())      
      {
        return true;
      }
      
      return false;
    }

    public bool CheckDraw()
    {
      for (int i = 0; i < this.board.GetLength(0); i++)
      {
        for (int j = 0; j < this.board.GetLength(1); j++)
        {
          if (this.board[i, j] == ' ')
          {
            return false;
          }          
        }
      }

      return true;
    }

    // Checks the diagonals for a winning condition
    private bool CheckWinDiagonals()
    {
      if ((this.board[0, 0] == this.board[1, 1] && this.board[0, 0] == this.board[2, 2]) && this.board[0, 0] != ' ' ||
          (this.board[0, 2] == this.board[1, 1] && this.board[0, 0] == this.board[2, 0]) && this.board[0, 2] != ' ')
      {
        return true;
      }

      return false;
    }

    // Checks the rows for a winning condition
    private bool CheckWinRows()
    {
      if ((this.board[0, 0] == this.board[0, 1] && this.board[0, 0] == this.board[0, 2]) && this.board[0, 0] != ' ' ||
          (this.board[1, 0] == this.board[1, 1] && this.board[1, 0] == this.board[1, 2]) && this.board[1, 0] != ' ' ||
          (this.board[2, 0] == this.board[2, 1] && this.board[2, 0] == this.board[2, 2]) && this.board[2, 0] != ' ' )
      {
        return true;
      }

      return false;
    }

    // Checks the columns for a winning condition
    private bool CheckWinColumns()
    {
      if ((this.board[0, 0] == this.board[1, 0] && this.board[0, 0] == this.board[2, 0]) && this.board[0, 0] != ' ' ||
          (this.board[0, 1] == this.board[1, 1] && this.board[0, 1] == this.board[2, 1]) && this.board[0, 1] != ' ' ||
          (this.board[0, 2] == this.board[1, 2] && this.board[0, 2] == this.board[2, 2]) && this.board[0, 2] != ' ')
      {
        return true;
      }

      return false;
    }
  }
}
