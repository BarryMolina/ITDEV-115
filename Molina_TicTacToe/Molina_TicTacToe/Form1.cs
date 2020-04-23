using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molina_TicTacToe
{
    public partial class Form1 : Form
    {
        private HumanPlayer player;
        private ComputerPlayer computer;
        private Board gameBoard;

        private string x = "Xpic.png";
        private string o = "Opic.png";

        PictureBox[] pics;

        public Form1()
        {
            InitializeComponent();

            pics = new PictureBox[] { picBx0, picBx1, picBx2, picBx3, picBx4, picBx5, picBx6, picBx7, picBx8 };
            ResetForm();

        }

        private void picBx_Click(object sender, EventArgs e)
        {
            PictureBox picBx = (PictureBox)sender;
            bool foundIt = false;
            int computerMove = Board.NOT_A_MOVE;

            if (picBx.ImageLocation == null)
            {
                picBx.ImageLocation = x;

                for (int i = 0; !foundIt && i < pics.Length; i++)
                {
                    if (sender.Equals(pics[i]))
                    {
                        foundIt = true;
                        player.MakeMove(ref i);
                        gameBoard.OpenPositions[i] = false;
                    }
                }
                if (!GameOver())
                {
                    computer.MakeMove(ref computerMove);

                    if (computerMove != Board.NOT_A_MOVE)
                    {
                        pics[computerMove].ImageLocation = o;
                    }
                    GameOver();
                }
            }
        }

        private bool GameOver()
        {
            string msg = "";
            bool gameOver = false;
            if (gameBoard.IsWinner(player.Pieces)) {
                gameOver = true;
                msg = "You Won!!";
            }
            else if (gameBoard.IsWinner(computer.Pieces))
            {
                gameOver = true;
                msg = "You Lost!";
            }
            else if (gameBoard.IsFull())
            {
                gameOver = true;
                msg = "It's a Tie!!!";
            }
            if (gameOver)
            {
                msg += "\n\nWould you like to play again?";
                DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); 
                if (result == DialogResult.Yes)
                {
                    ResetForm();
                }
                else
                {
                    Application.Exit();
                }
            }
            return gameOver;
        }
        private void ResetForm()
        {
            foreach (PictureBox pic in pics)
            {
                pic.ImageLocation = null;
            }
            gameBoard = new Board();
            player = new HumanPlayer();
            computer = new ComputerPlayer(gameBoard, player.Pieces);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tBarry Molina" +
                        "\nCourse:\t\tITDEV-115-200" +
                        "\nInstructor:\tJ. Christie" +
                        "\nAssignment:\t#9 Tic Tac Toe GUI" +
                        "\nDate:\t\t4/23/2020";
            MessageBox.Show(info, "Assignment 9 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string intro = "Ready to have a rousing game of Tic Tac toe?  The object" +
            "\nof the game is to get three of your pieces either across, up and down," +
            "\nor diagonally. If you do, before your opponent, you win the game!";

            MessageBox.Show(intro, "Tic Tac Toe");
        }
    }
}
