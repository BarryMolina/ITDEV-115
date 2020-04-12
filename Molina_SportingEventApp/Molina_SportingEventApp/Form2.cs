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
    public partial class Form2 : Form
    {
        private Child[] regChildren;
        private int count;
        public Form2(Child[] children, int index)
        {
            InitializeComponent();
            regChildren = children;
            count = index;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                lstBxName.Items.Add(regChildren[i].Name);
                lstBxSport.Items.Add(regChildren[i].Sport);
            }
        }
    }
}
