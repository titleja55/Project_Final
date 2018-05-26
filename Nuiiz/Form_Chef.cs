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
    public partial class Form_Chef : Form
    {

        
        public Form_Chef(List<string> listmenu)
        {
            InitializeComponent();
            
        }

        public Form_Chef()
        {
            InitializeComponent();

        }
        public Form_Chef(ListBox listbox)
        {
            InitializeComponent();
            listChFood.Items.AddRange(listbox.Items);
        }

        private void Form_Chef_Activated(object sender, EventArgs e)
        {
            
        }
 
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            
            /*listChFood.Items.Add(NewForm.listOrder.Items[0]);*/

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main main = new Form_Main();
            main.Show();
        }

        private void listChFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listChFood_DoubleClick(object sender, EventArgs e)
        {
            listChFood.Items.RemoveAt(listChFood.SelectedIndex);
        }
    }
}
