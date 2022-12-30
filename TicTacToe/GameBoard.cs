using System;
using System.Text;

namespace TicTacToe
{
	public class GameBoard
	{
        public class TicTacToen
        {
            private char[,] _board = new char[3, 3];
            public char _currentPlayer = 'X';

            public TicTacToen()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        _board[i, j] = ' ';
                    }
                }
            }

            public bool MakeMove(int row, int col)
            {
                if (_board[row, col] != ' ')
                {
                    return false;
                }

                _board[row, col] = _currentPlayer;
                _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
                return true;
            }

            public char CheckWinner()
            {
                // Check rows
                for (int i = 0; i < 3; i++)
                {
                    if (_board[i, 0] != ' ' && _board[i, 0] == _board[i, 1] && _board[i, 1] == _board[i, 2])
                    {
                        return _board[i, 0];
                    }
                }

                // Check columns
                for (int i = 0; i < 3; i++)
                {
                    if (_board[0, i] != ' ' && _board[0, i] == _board[1, i] && _board[1, i] == _board[2, i])
                    {
                        return _board[0, i];
                    }
                }

                // Check diagonals
                if (_board[0, 0] != ' ' && _board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2])
                {
                    return _board[0, 0];
                }
                if (_board[0, 2] != ' ' && _board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])
                {
                    return _board[0, 2];
                }

                return ' ';
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sb.Append(_board[i, j]);
                        if (j < 2)
                        {
                            sb.Append(" | ");
                        }
                    }
                    sb.AppendLine();
                    if (i < 2)
                    {
                        sb.AppendLine("---------");
                    }
                }
                return sb.ToString();
            }
        }

    }
}

