using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Molina_Assignment11
{
    public partial class Form1 : Form
    {
        ContactS contacts;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts = new ContactS();

            try
            {
                contacts.ReadContacts();
                for (int i = 0; i < ContactS.NO_OF_CONTACTS; i++)
                {
                    cmbBxNames.Items.Add(contacts.GetLastName(i));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool foundIt = false;
            string name = cmbBxNames.Text;

            for (int i = 0; !foundIt && i < ContactS.NO_OF_CONTACTS; i++)
            {
                if (contacts.GetLastName(i) == name)
                {
                    foundIt = true;

                    Visibility(true);
                    txtBxName.Text = contacts.GetFirstName(i) + " " + contacts.GetLastName(i);
                    txtBxAddress.Text = contacts.GetAddress(i);
                    txtBxCity.Text = contacts.GetCity(i);
                    txtBxState.Text = contacts.GetState(i);
                    txtBxZip.Text = contacts.GetZip(i);
                    txtBxPhone.Text = contacts.GetPhone(i);
                    txtBxEmail.Text = contacts.GetEmail(i);
                }
            }
        }

        public void Visibility(bool visible)
        {
            pctrBxPhone.Visible = !visible;

            lblContactName.Visible = visible;
            lblAddress.Visible = visible;
            lblCity.Visible = visible;
            lblState.Visible = visible;
            lblZip.Visible = visible;
            lblPhone.Visible = visible;
            lblEmail.Visible = visible;

            txtBxName.Visible = visible;
            txtBxAddress.Visible = visible;
            txtBxCity.Visible = visible;
            txtBxState.Visible = visible;
            txtBxZip.Visible = visible;
            txtBxPhone.Visible = visible;
            txtBxEmail.Visible = visible;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbBxNames.SelectedItem = null;
            Visibility(false);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tBarry Molina" +
                        "\nCourse:\t\tITDEV-115-200" +
                        "\nInstructor:\tJ. Christie" +
                        "\nAssignment:\tAssignment 11" +
                        "\nDate:\t\t4/18/2020";
            MessageBox.Show(info, "Assignment 11 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
