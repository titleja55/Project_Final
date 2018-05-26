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
    public partial class interface_1 : Form
    {
        public interface_1()
        {
            InitializeComponent();
        }
        string food = string.Empty ;
        string foodid = string.Empty;
        string foodname = string.Empty;
        string foodprice = string.Empty;
        string foodco = string.Empty;
        DataSet ds = new DataSet();
        string cn = "Data Source=DESKTOP-UQ0KT1B\\SQLEXPRESS;Initial Catalog=Nuiiz;Integrated Security=True";
        private void interface_1_Load(object sender, EventArgs e)
        {

        }

        private void dataMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) { return; }
            else
            {
                DataRow dr = ds.Tables[food].Rows[e.RowIndex];
                textID.Text = dr[foodid].ToString();
                textName.Text = dr[foodname].ToString();
                textPrice.Text = dr[foodprice].ToString();
                /*DataGridViewRow dgr = dataMenu.Rows[e.RowIndex];
                textID.Text = dgr.Cells[0].Value.ToString();
                textName.Text = dgr.Cells[1].Value.ToString();
                textPrice.Text = dgr.Cells[2].Value.ToString();*/
                dataMenu.Rows[e.RowIndex].Selected = true;
            }
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds.Tables[food].Select(foodco+"'" + textID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds.Tables[food].NewRow();
                dr[foodid] = textID.Text;
                dr[foodname] = textName.Text;
                dr[foodprice] = textPrice.Text;
                ds.Tables[food].Rows.Add(dr);
            }
            else
            {
                drs[0][foodid] = textID.Text;
                drs[0][foodname] = textName.Text;
                drs[0][foodprice] = textPrice.Text;

            }
            dataMenu.DataSource = ds.Tables[food];

            /*DataRow[] drs = ds.Tables["Vegetable"].Select("vegetID='"+textID.Text+"'");
            if(drs.Length == 0)
            {
                DataRow dr = ds.Tables["Vegetable"].NewRow();
                dr["vegetID"] = textID.Text;
                dr["vegetName"] = textName.Text;
                dr["vegetPrice"] = textPrice.Text;
                ds.Tables["Vegetable"].Rows.Add(dr);
            }
            else
            {
                drs[0]["vegetID"] = textID.Text;
                drs[0]["vegetName"] = textName.Text;
                drs[0]["vegetPrice"] = textPrice.Text;
                
            }
            dataMenu.DataSource = ds.Tables["Vegetable"];*/
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds.Tables[food].Select(foodco+"'" + textID.Text + "'");
            if (drs.Length == 0)
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการ");
            else
            {
                drs[0].Delete();
                string sql = "SELECT*FROM "+food;
                SqlDataAdapter dw = new SqlDataAdapter(sql, cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(dw);
                dw.Update(ds, food);
                ds.Tables[food].AcceptChanges();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string sql = "SELECT*FROM "+food;
            SqlDataAdapter dw = new SqlDataAdapter(sql,cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(dw);
            dw.Update(ds, food);
        }

        private void buttonFresh_Click(object sender, EventArgs e)
        {
            food = "Fresh_Foods";
            foodid = "foodID";
            foodname = "foodName";
            foodprice = "foodPrice";
            foodco = "foodID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = food;
            string sql = "SELECT * FROM Fresh_Foods";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Fresh_Foods");
            dataMenu.DataSource = ds.Tables["Fresh_Foods"];
            


        }

        private void buttonVeget_Click(object sender, EventArgs e)
        {
            food = "Vegetable";
            foodid = "vegetID";
            foodname = "vegetName";
            foodprice = "vegetPrice";
            foodco = "vegetID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = food;
            string sql = "SELECT * FROM Vegetable";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Vegetable");
            dataMenu.DataSource = ds.Tables["Vegetable"];
           


        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            food = "A_La_Carte";
            foodid = "carteID";
            foodname = "carteName";
            foodprice = "cartePrice";
            foodco = "carteID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = buttonVeget.Text;
            string sql = "SELECT * FROM A_La_Carte";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "A_La_Carte");
            dataMenu.DataSource = ds.Tables["A_La_Carte"];
            textFoodStat.Text = food;

        }

        private void buttonDimsum_Click(object sender, EventArgs e)
        {
            food = "Dimsum";
            foodid = "dimsumID";
            foodname = "dimsumName";
            foodprice = "dimsumPrice";
            foodco = "dimsumID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = buttonVeget.Text;
            string sql = "SELECT * FROM Dimsum";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Dimsum");
            dataMenu.DataSource = ds.Tables["Dimsum"];
            textFoodStat.Text = food;
        }

        private void buttonDrink_Click(object sender, EventArgs e)
        {
            food = "Beverages";
            foodid = "beverID";
            foodname = "beverName";
            foodprice = "beverPrice";
            foodco = "beverID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = buttonVeget.Text;
            string sql = "SELECT * FROM Beverages";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Beverages");
            dataMenu.DataSource = ds.Tables["Beverages"];
            textFoodStat.Text = food;
        }

        private void buttonNoodles_Click(object sender, EventArgs e)
        {
            food = "Noodles";
            foodid = "noodleID";
            foodname = "noodleName";
            foodprice = "noodlePrice";
            foodco = "noodleID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = buttonVeget.Text;
            string sql = "SELECT * FROM Noodles";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Noodles");
            dataMenu.DataSource = ds.Tables["Noodles"];
            textFoodStat.Text = food;
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            food = "Desserts";
            foodid = "dessertID";
            foodname = "dessertName";
            foodprice = "dessertPrice";
            foodco = "dessertID=";
            ds.Clear();
            dataMenu.ClearSelection();
            textFoodStat.Text = buttonVeget.Text;
            string sql = "SELECT * FROM Desserts";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Desserts");
            dataMenu.DataSource = ds.Tables["Desserts"];
            textFoodStat.Text = food;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main main = new Form_Main();
            main.Show();
        }
    }
}
