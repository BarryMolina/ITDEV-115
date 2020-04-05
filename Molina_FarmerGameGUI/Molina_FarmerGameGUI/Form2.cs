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

        private void UpdateLstBx(ArrayList items)
        {
            comboBoxItems.Items.Clear();
            comboBoxItems.Items.AddRange(items.ToArray());
            comboBoxItems.Items.Add(farmer.Nothing);
            comboBoxItems.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            UpdateLstBx(farmer.NorthBank);
            //form1.ShowDialog();
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            farmer.Move(comboBoxItems.SelectedItem.ToString());

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
    }
}
