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
    public partial class Form_Addstaff : Form
    {
        public Form_Addstaff()
        {
            InitializeComponent();
        }
        DataSet ds2 = new DataSet();
        string cn = "Data Source=DESKTOP-UQ0KT1B\\SQLEXPRESS;Initial Catalog=Nuiiz;Integrated Security=True";
        private void Form_Addstaff_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Staff";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds2, "Staff");
            dataStaff.DataSource = ds2.Tables["Staff"];
        }

        private void btS_Insert_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds2.Tables["Staff"].Select("S_ID='" + textS_ID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds2.Tables["Staff"].NewRow();
                dr["S_ID"] = textS_ID.Text;
                dr["S_Password"] = textS_Password.Text;
                dr["S_FName"] = textS_FName.Text;
                dr["S_LName"] = textS_LName.Text;
                dr["S_NName"] = textS_NName.Text;
                dr["S_IDnum"] = textS_IDNum.Text;
                dr["S_BirthDay"] = textS_Birth.Text;
                dr["S_Address"] = textS_Address.Text;
                dr["S_Tel"] = textS_Tel.Text;
                dr["S_Stat"] = textStat.Text;
                ds2.Tables["Staff"].Rows.Add(dr);
            }
            else
            {
                drs[0]["S_ID"] = textS_ID.Text;
                drs[0]["S_Password"] = textS_Password.Text;
                drs[0]["S_FName"] = textS_FName.Text;
                drs[0]["S_LName"] = textS_LName.Text;
                drs[0]["S_NName"] = textS_NName.Text;
                drs[0]["S_IDnum"] = textS_IDNum.Text;
                drs[0]["S_BirthDay"] = textS_Birth.Text;
                drs[0]["S_Address"] = textS_Address.Text;
                drs[0]["S_Tel"] = textS_Tel.Text;
                drs[0]["S_Stat"] = textStat.Text;

            }
            dataStaff.DataSource = ds2.Tables["Staff"];
        }

        private void dataStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                DataRow dr = ds2.Tables["Staff"].Rows[e.RowIndex];
                textS_ID.Text = dr["S_ID"].ToString();
                textS_FName.Text = dr["S_FName"].ToString();
                textS_LName.Text = dr["S_LName"].ToString();
                textS_NName.Text = dr["S_NName"].ToString();
                textS_IDNum.Text = dr["S_IDnum"].ToString();
                textS_Birth.Text = dr["S_Birthday"].ToString();
                textS_Address.Text = dr["S_Address"].ToString();
                textStat.Text = dr["S_Stat"].ToString();
                textS_Tel.Text = dr["S_Tel"].ToString();
                
                /*DataGridViewRow dgr = dataMenu.Rows[e.RowIndex];
                textID.Text = dgr.Cells[0].Value.ToString();
                textName.Text = dgr.Cells[1].Value.ToString();
                textPrice.Text = dgr.Cells[2].Value.ToString();*/
                dataStaff.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btS_Del_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds2.Tables["Staff"].Select("S_ID='" + textS_ID.Text + "'");
            if (drs.Length == 0)
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการ");
            else
            {
                drs[0].Delete();
                string sql = "SELECT*FROM Staff";
                SqlDataAdapter dw = new SqlDataAdapter(sql, cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(dw);
                dw.Update(ds2, "Staff");
                ds2.Tables["Staff"].AcceptChanges();
            }
        }

        private void buttonBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main main = new Form_Main();
            main.Show();
        }
    }
}
