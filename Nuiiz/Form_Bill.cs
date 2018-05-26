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
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string cn = "Data Source=DESKTOP-UQ0KT1B\\SQLEXPRESS;Initial Catalog=Nuiiz;Integrated Security=True";
        private void Form_Bill_Load(object sender, EventArgs e)
        {
            string sql = "SELECT  billName,billPrice FROM Bill " ;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Bill");
           dataGridView1.DataSource = ds.Tables["Bill"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable drs2 = ds.Tables["Bill"];
            drs2.Rows.Clear();
            string sql = "SELECT* FROM Bill";
            SqlDataAdapter dw = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(dw);
            dw.Update(ds, "Bill");
            ds.Tables["Bill"].AcceptChanges();
          
        }
    }
}
