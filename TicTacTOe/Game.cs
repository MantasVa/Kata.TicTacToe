using System;
using TicTacTOe.Infrastructure.Enums;

namespace TicTacTOe
{
    public class Game
    {
        private readonly string[] _board;
        public Game(BoardSize boardSize)
        {
            _board = CreateGameBoard(boardSize);
        }

        public static string[] CreateGameBoard(BoardSize boardSize)
        {
            switch (boardSize)
            {
                case BoardSize.ThreeXThree:
                    return new string[9];
                case BoardSize.FourXFour:
                    return new string[16];
                case BoardSize.FiveXFive:
                    return new string[25];
                default:
                    throw new ArgumentException("Bad enum type");
            }
        }


    }
}
