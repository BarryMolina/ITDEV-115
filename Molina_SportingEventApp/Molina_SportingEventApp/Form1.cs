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
        public Form1()
        {
            InitializeComponent();
        }

        private void rdBtnRugby_CheckedChanged(object sender, EventArgs e)
        {
            picBxRugby.Visible = true;
            picBxRugby.BringToFront();

            sportSelected.Visible = true;
            sportSelected.Text = "Football without pads!";

        }

        private void rdBtnLacrosse_CheckedChanged(object sender, EventArgs e)
        {
            picBxLacrosse.Visible = true;
            picBxLacrosse.BringToFront();

            sportSelected.Visible = true;
            sportSelected.Text = "Hockey on land";
        }

        private void rdBtnPolo_CheckedChanged(object sender, EventArgs e)
        {
            picBxPolo.Visible = true;
            picBxPolo.BringToFront();

            sportSelected.Visible = true;
            sportSelected.Text = "The Sport of Kings";
        }

        private void rdButtonFrisbee_CheckedChanged(object sender, EventArgs e)
        {
            picBxFrisbee.Visible = true;
            picBxFrisbee.BringToFront();

            sportSelected.Visible = true;
            sportSelected.Text = "Anyone can play!";

        }

        private void rdBtnCurling_CheckedChanged(object sender, EventArgs e)
        {
            picBxCurling.Visible = true;
            picBxCurling.BringToFront();

            sportSelected.Visible = true;
            sportSelected.Text = "Sweep your way to victory";
        }
    }
}
