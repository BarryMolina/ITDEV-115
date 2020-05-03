using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molina_TriviaGUI
{
    public partial class Form1 : Form
    {
        QuestionBank qBank;
        private int q = 0;
        private const char NO_ANSWER = 'Z';
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

            qBank = new QuestionBank();
            try
            {
                qBank.ReadQuestionFile();
            }
            catch (FileNotFoundException ex)
            {
                //Environment.Exit(1);
                Console.WriteLine("File not found: " + ex.Message);
            }

            LoadQuestion();

            //Console.WriteLine(qBank);



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

        private void LoadQuestion()
        {
            lblQuestion.Text = qBank.GetQuestion(q);
            rbA.Text = qBank.GetAnswers(q)[0];
            rbB.Text = qBank.GetAnswers(q)[1];
            rbC.Text = qBank.GetAnswers(q)[2];
            rbD.Text = qBank.GetAnswers(q)[3];
        }

        private void picSubmit_Click(object sender, EventArgs e)
        {
            char ans = NO_ANSWER;
            if (rbA.Checked)
            {
                ans = 'A';
            }
            else if (rbB.Checked)
            {
                ans = 'B';
            }
            else if (rbC.Checked)
            {
                ans = 'C';
            }
            else if (rbD.Checked)
            {
                ans = 'D';
            }
            if (ans != NO_ANSWER)
            {
                setVisiblity(false);

                if (ans == qBank.GetCorrectAnswer(q))
                {
                    lblQuestion.Text = "You are correct!";
                }
                else
                {
                    lblQuestion.Text = "The correct answer is: " 
                         + qBank.GetAnswers(q)[Array.IndexOf(QuestionBank.answerChars, qBank.GetCorrectAnswer(q))];
                }
                lblMsg.Text = qBank.GetExplanation(q);
                q++;
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            setVisiblity(true);
            LoadQuestion();
        }

        private void setVisiblity(bool visible)
        {
            rbA.Visible = visible;
            rbB.Visible = visible;
            rbC.Visible = visible;
            rbD.Visible = visible;
            picSubmit.Visible = visible;
            picNext.Visible = !visible;
            lblMsg.Visible = !visible;

        }
    }
}
