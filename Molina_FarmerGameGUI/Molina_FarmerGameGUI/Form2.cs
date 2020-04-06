using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Molina_FarmerGameGUI
{
    public partial class Form2 : Form
    {
        Farmer farmer;
        public Form2()
        {
            farmer = new Farmer();
            InitializeComponent();
        }

        private void UpdateFarmerLbl(string bank)
        {
            lblFarmerBank.Text = "The Farmer is on the " + bank + " Bank of the River";
        }
        private void UpdateBank(ArrayList items, Label lbl)
        {
            string itemStr = "";
            foreach(string item in items)
            {
                itemStr += item + " ";
            }
            lbl.Text = itemStr;
        }
        public bool GameOver()
        {
            bool gameOver = false;
            bool quit = false;
            string endMsg = "";

            if (farmer.AnimalAteFood("FOX"))
            {
                endMsg = "Oh no! the Fox ate the Chicken!!" + 
                    "\n\nYOU LOSE";
                gameOver = true;
            }
            else if (farmer.AnimalAteFood("CHICKEN"))
            {
                endMsg = "Oh no! the Chicken ate the Grain!!" +
                    "\n\nYOU LOSE";
                gameOver = true;
            }
            else if (farmer.DetermineWin())
            {
                endMsg = "You have successfully completed the game!!" +
                    "\n\nCONGRATULATIONS";
                gameOver = true;
            }
            if (gameOver)
            { 
                endMsg += "\n\n\nWould you like to play again?";
                DialogResult res = MessageBox.Show(endMsg, "Game Over", MessageBoxButtons.YesNo);
                
                if (res == DialogResult.Yes)
                {
                    farmer = new Farmer();
                    UpdateForm();
                }
                else
                {
                    quit = true;
                }
            }
            return quit;
        }

        private void UpdateLstBx(ArrayList items)
        {
            comboBoxItems.Items.Clear();
            comboBoxItems.Items.AddRange(items.ToArray());
            comboBoxItems.Items.Add(farmer.Nothing);
            comboBoxItems.SelectedIndex = 0;
        }

        private void UpdateForm()
        {
            UpdateBank(farmer.NorthBank, lblNorthBank);
            UpdateBank(farmer.SouthBank, lblSouthBank);
            
            if (farmer.TheFarmer == Direction.North)
            {
                UpdateLstBx(farmer.NorthBank);
                UpdateFarmerLbl("North");
            }
            else
            {
                UpdateLstBx(farmer.SouthBank);
                UpdateFarmerLbl("South");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            UpdateLstBx(farmer.NorthBank);
            form1.ShowDialog();
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            farmer.Move(comboBoxItems.SelectedItem.ToString());

            UpdateForm();

            if (GameOver())
            {
                Application.Exit();
            }
        }
    }
}
