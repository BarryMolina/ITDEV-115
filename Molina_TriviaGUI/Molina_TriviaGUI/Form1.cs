using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molina_TriviaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = "Let's play a game of trivia. You will be shown a series of questions," +
                        "\none at a time. Each question will have four possible answers, only one" +
                        "\nis the correct answer. Your job is to pick the correct answer.";
            MessageBox.Show(msg, "Trivia Game");

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tBarry Molina" +
                        "\nCourse:\t\tITDEV-115-200" +
                        "\nInstructor:\tJ. Christie" +
                        "\nAssignment:\tTrivia Game GUI" +
                        "\nDate:\t\t4/23/2020";
            MessageBox.Show(info, "Extra Credit - Trivia GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
