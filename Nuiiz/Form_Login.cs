using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuiiz
{
    public partial class Form_Login : Form
    {
        DataSet ds = new DataSet();
        string cn = "Data Source=DESKTOP-UQ0KT1B\\SQLEXPRESS;Initial Catalog=Nuiiz;Integrated Security=True";
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /*textBox1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();*/

            if (textID.Text == ds.Tables[0].Rows[0].ItemArray[0].ToString() || textPassword.Text == ds.Tables[0].Rows[0].ItemArray[1].ToString())
            {
                this.Hide();
                Form_Main main = new Form_Main();
                main.Show();
            }
            else if(textID.Text == ds.Tables[0].Rows[1].ItemArray[0].ToString() || textPassword.Text == ds.Tables[0].Rows[1].ItemArray[1].ToString())
            {

                this.Hide();
                Form_main2 main2 = new Form_main2();
                main2.Show();
            }
            else 
            {
                MessageBox.Show("กรุณาใส่Username และ Passwordให้ถูกต้อง");
            }
            
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            string sql = "SELECT S_ID,S_Password FROM Staff";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Staff");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
