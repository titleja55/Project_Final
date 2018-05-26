using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuiiz
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btOpAddstsaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Addstaff addstaff = new Form_Addstaff();
            addstaff.Show();

        }

        private void btOpCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            interface_1 addfood = new interface_1();
            addfood.Show();
        }

        private void buttonChef_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chef ShowChef = new Form_Chef();
            ShowChef.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Customer ShowCus = new Form_Customer();
            ShowCus.Show();
        }
    }
}
