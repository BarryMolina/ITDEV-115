using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molina_SportingEventApp
{
    public partial class Form1 : Form
    {
        private int index = 0;
        private Child[] registeredChild = new Child[100];
        private string sportSelected = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void rdBtnRugby_CheckedChanged(object sender, EventArgs e)
        {
            picBxRugby.Visible = true;
            picBxRugby.BringToFront();

            txtBxMsg.Visible = true;
            txtBxMsg.Text = "Football without pads!";
            sportSelected = "Rugby";

        }

        private void rdBtnLacrosse_CheckedChanged(object sender, EventArgs e)
        {
            picBxLacrosse.Visible = true;
            picBxLacrosse.BringToFront();

            txtBxMsg.Visible = true;
            txtBxMsg.Text = "Hockey on land";
            sportSelected = "Lacrosse";
        }

        private void rdBtnPolo_CheckedChanged(object sender, EventArgs e)
        {
            picBxPolo.Visible = true;
            picBxPolo.BringToFront();

            txtBxMsg.Visible = true;
            txtBxMsg.Text = "The Sport of Kings";
            sportSelected = "Polo";
        }

        private void rdButtonFrisbee_CheckedChanged(object sender, EventArgs e)
        {
            picBxFrisbee.Visible = true;
            picBxFrisbee.BringToFront();

            txtBxMsg.Visible = true;
            txtBxMsg.Text = "Anyone can play!";

            sportSelected = "Ultimate Frisbee";
        }

        private void rdBtnCurling_CheckedChanged(object sender, EventArgs e)
        {
            picBxCurling.Visible = true;
            picBxCurling.BringToFront();

            txtBxMsg.Visible = true;
            txtBxMsg.Text = "Sweep your way to victory";

            sportSelected = "Curling";
        }

        private void ResetForm()
        {
            foreach (RadioButton rb in groupBox1.Controls)
            {
                rb.Checked = false;
            }
            txtBxCity.Clear();
            txtBxMsg.Clear();
            txtBxName.Clear();
            txtBxStreet.Clear();

            cmBxState.Text = null;
            sportSelected = "";

            picBxCurling.Visible = false;
            picBxFrisbee.Visible = false;
            picBxLacrosse.Visible = false;
            picBxPolo.Visible = false;
            picBxRugby.Visible = false;

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            registeredChild[index] = new Child(txtBxCity.Text, txtBxName.Text, 
                                                sportSelected, cmBxState.Text, 
                                                txtBxStreet.Text);
            index++;
            ResetForm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (index > 0)
            {
                Form2 form2 = new Form2(registeredChild, index);
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tBarry Molina" +
                        "\nCourse:\t\tITDEV-115-200" +
                        "\nInstructor:\tJ. Christie" +
                        "\nAssignment:\tSporting Application" +
                        "\nDate:\t\t4/11/2020";
            MessageBox.Show(info, "Sporting Event Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
