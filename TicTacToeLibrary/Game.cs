using System;
using System.Numerics;
using TicTacToe.Infrastructure.Enums;
using TicTacToe.Models;
using TicTacToeLibrary.Infrastructure.Enums;

namespace TicTacToeLibrary
{
    public class Game
    {
        private readonly char[,] _board;
        private Player _player1 = new Player("Player1",isHisMove: true);
        private Player _player2 = new Player("Player2");
        public Game(BoardSize boardSize, PlayerIcon player1Icon)
        {
            _board = CreateGameBoard(boardSize);
            SetPlayersIcons(player1Icon);
        }

        public char[,] Board { get { return _board; } }
        public Player Player1 { get { return _player1; } }
        public Player Player2 { get { return _player2; } }

        public Player WinnerPlayer { get; private set; }

        public static char[,] CreateGameBoard(BoardSize boardSize)
        {
            switch (boardSize)
            {
                case BoardSize.ThreeXThree:
                    return new char[3,3];
                case BoardSize.FourXFour:
                    return new char[4,4];
                case BoardSize.FiveXFive:
                    return new char[5,5];
                default:
                    throw new ArgumentException("Bad enum type");
            }
        }

        public void SetPlayersIcons(PlayerIcon player1Icon)
        {
            switch (player1Icon)
            {
                case PlayerIcon.PlayerX:
                    _player1.Icon = 'X';
                    _player2.Icon = 'O';
                    break;
                case PlayerIcon.PlayerO:
                    _player1.Icon = 'O';
                    _player2.Icon = 'X';
                    break;
                default:
                    break;
            }
        }

        public void MakeTurn(short x, short y)
        {
            if (x >= _board.GetLength(0) || y >= _board.GetLength(1))
                throw new ArgumentOutOfRangeException();

            if (_player1.IsHisMove)
            {
                _board[x, y] = Player1.Icon;
                _player1.IsHisMove = false;
                _player2.IsHisMove = true;
            }
            else if (_player2.IsHisMove)
            {
                _board[x, y] = Player2.Icon;
                _player1.IsHisMove = true;
                _player2.IsHisMove = false;
            }
            else
            {
                throw new InvalidOperationException("Error: Nobody has a turn");
            }
        }

        public bool IsGameOver()
        {
            bool foundEmptyFields = false;
            for (int x = 0; x < _board.GetLength(0); x++)
            {
                for (int y = 0; y < _board.GetLength(1); y++)
                {
                    if (_board[x, y] != '\0' && FoundWinner(x,y))
                    {
                        if(_player1.Icon == _board[x,y])
                        {
                            WinnerPlayer = _player1;
                        }
                        else
                        {
                            WinnerPlayer = _player2;
                        }
                            
                        return true;
                    }

                    if (_board[x, y] == '\0')
                        foundEmptyFields = true;
                }

            }
            if (foundEmptyFields == false)
                return true;

            return false;
        }

        private bool FoundWinner(int iterationX, int iterationY)
        {
            char searchedIcon = _board[iterationX, iterationY];

            if (iterationY + 2 < _board.GetLength(1))
                if (_board[iterationX, iterationY + 1] == searchedIcon && _board[iterationX, iterationY + 2] == searchedIcon)
                    return true;
            if (iterationY - 2 >= 0)
                if (_board[iterationX, iterationY - 1] == searchedIcon && _board[iterationX, iterationY - 2] == searchedIcon)
                    return true;

            if (iterationX + 2 < _board.GetLength(0))
                if (_board[iterationX + 1, iterationY] == searchedIcon && _board[iterationX + 2, iterationY] == searchedIcon)
                    return true;

            if (iterationX - 2 >= 0)
                if (_board[iterationX - 1, iterationY] == searchedIcon && _board[iterationX - 2, iterationY] == searchedIcon)
                    return true;

            if (iterationY + 2 < _board.GetLength(1) && iterationX + 2 < _board.GetLength(0))
                if (_board[iterationX + 1, iterationY + 1] == searchedIcon && _board[iterationX + 2, iterationY + 2] == searchedIcon)
                    return true;

            if (iterationY + 2 < _board.GetLength(1) && iterationX - 2 >= 0)
                if (_board[iterationX - 1, iterationY + 1] == searchedIcon && _board[iterationX - 2, iterationY + 2] == searchedIcon)
                    return true;

            if (iterationY - 2 >= 0 && iterationX + 2 < _board.GetLength(0))
                if (_board[iterationX + 1, iterationY - 1] == searchedIcon && _board[iterationX + 2, iterationY - 2] == searchedIcon)
                    return true;

            if (iterationY - 2 >= 0 && iterationX - 2 >= 0)
                if (_board[iterationX - 1, iterationY - 1] == searchedIcon && _board[iterationX - 2, iterationY - 2] == searchedIcon)
                    return true;

            return false;
        }

    }
}
