using System;
using TicTacToe.Infrastructure.Enums;
using TicTacToeLibrary;
using TicTacToeLibrary.Infrastructure.Enums;
using Xunit;

namespace TicTacTOe.Tests
{
    public class GameTests
    {
        [Theory]
        [InlineData(BoardSize.ThreeXThree,9)]
        [InlineData(BoardSize.FourXFour, 16)]
        [InlineData(BoardSize.FiveXFive, 25)]
        public void CreateGameBoard_ValidParameter_BoardCreatedSuccesfully(BoardSize boardSize, int expectedArrSize)
        {
            var actualGameBoard = Game.CreateGameBoard(boardSize);

            Assert.NotNull(actualGameBoard);
            Assert.Equal(expectedArrSize, actualGameBoard.Length);
        }

        [Theory]
        [InlineData(PlayerIcon.PlayerX,'X','O')]
        [InlineData(PlayerIcon.PlayerO, 'O', 'X')]
        public void SetPlayersIcons_ValidParameter_PlayersIconsSetCorrectly(PlayerIcon player1Icon, char player1IconStr, char player2IconStr)
        {
            var game = new Game(BoardSize.FiveXFive, player1Icon);

            Assert.False(char.IsWhiteSpace(game.Player1.Icon));
            Assert.False(char.IsWhiteSpace(game.Player2.Icon));
            Assert.Equal(game.Player1.Icon, player1IconStr);
            Assert.Equal(game.Player2.Icon, player2IconStr);
        }

        [Fact]
        public void MakeTurn_ValidParameter_BoardIsUpdatedCorrectly()
        {
            Game game = new Game(BoardSize.ThreeXThree, PlayerIcon.PlayerX);

            game.MakeTurn(0, 0);

            Assert.False(Char.IsWhiteSpace(game.Board[0, 0]));
            Assert.Equal('X', game.Board[0, 0]);
            Assert.False(game.Player1.IsHisMove);
            Assert.True(game.Player2.IsHisMove);
        }

        [Fact]
        public void MakeTurn_InvalidParameter_ThrowsOutOfRangeException()
        {
            Game game = new Game(BoardSize.ThreeXThree, PlayerIcon.PlayerX);

            Assert.Throws<ArgumentOutOfRangeException>(() => game.MakeTurn(3, 3));
        }

        [Fact]
        public void IsGameOver_ReturnsTrueThatGameIsOver()
        {
            Game game = new Game(BoardSize.ThreeXThree, PlayerIcon.PlayerX);
            game.Board[0, 0] = 'X';
            game.Board[0, 1] = 'X';
            game.Board[0, 2] = 'X';

            bool actual = game.IsGameOver();

            Assert.True(actual);
        }

        [Fact]
        public void IsGameOver_ReturnsFalse()
        {
            Game game = new Game(BoardSize.ThreeXThree, PlayerIcon.PlayerX);

            bool actual = game.IsGameOver();

            Assert.False(actual);
        }


    }
}
