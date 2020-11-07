using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Infrastructure.Enums;
using TicTacToeLibrary;
using TicTacToeLibrary.Infrastructure.Enums;

namespace TicTacToe.GUI
{
    public partial class oPlayerButton : Form
    {
        private static Game _game;
        public oPlayerButton()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            BoardSize boardSize;
            PlayerIcon player1Icon;

            if (threexthreeRadio.Checked == true)
            {
                boardSize = BoardSize.ThreeXThree;
            }
            else if (fourxfourRadio.Checked == true)
            {
                boardSize = BoardSize.FourXFour;
            }
            else if (fivexfiveRadio.Checked == true)
            {
                boardSize = BoardSize.FiveXFive;
            }
            else
            {
                throw new ArgumentNullException("Board Size is not selected");
            }

            if (player1ORadio.Checked == true)
            {
                player1Icon = PlayerIcon.PlayerO;
            }
            else if (player1XRadio.Checked == true)
            {
                player1Icon = PlayerIcon.PlayerX;
            }
            else
            {
                throw new ArgumentNullException("Player 1 Icon is not selected");
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            startButton.Enabled = false;
            _game = new Game(boardSize, player1Icon);

            gamePanel.Enabled = true;
            RedrawBoard();
        }

        private void RedrawBoard()
        {
            gamePanel.Controls.Clear();
            short locationX = 0;
            short locationY = 0;
            for (int i = 0; i < _game.Board.GetLength(0); i++)
            {
                for (int y = 0; y < _game.Board.GetLength(1); y++)
                {
                    Button button = new Button();
                    button.Size = new Size(65, 65);
                    button.Text = Char.ToString(_game.Board[i, y]);
                    button.Location = new Point(locationX, locationY);
                    button.Name = $"{i}{y}";
                    locationX += 65;
                    button.Click += MakePlayerTurn;
                    gamePanel.Controls.Add(button);
                }
                locationX = 0;
                locationY += 65;
            }
        }

        private void MakePlayerTurn(object sender, EventArgs e)
        {
            var buttonSender = (Button)sender;
            if (buttonSender.Text == "\0")
            {
                short xAxis = Int16.Parse(buttonSender.Name[0].ToString());
                short yAxis = Int16.Parse(buttonSender.Name[1].ToString());
                _game.MakeTurn(xAxis, yAxis);
                buttonSender.Text = Char.ToString(_game.Board[xAxis, yAxis]);

                CheckIfGameIsOver();
            }

        }

        private void CheckIfGameIsOver()
        {
            if (_game.IsGameOver())
            {
                gamePanel.Enabled = false;

                if (_game.WinnerPlayer == null)
                {
                    gameEndLabel.Text = "It is a tie!";
                }
                else
                {
                    gameEndLabel.Text = $"{_game.WinnerPlayer.Name} has won the game!";
                }
                    
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                startButton.Enabled = true;
            }
        }
    }
}
