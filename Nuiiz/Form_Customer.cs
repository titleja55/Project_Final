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
    public partial class Form_Customer : Form
    {

        public Form_Customer()
        {
            InitializeComponent();
            
        }
        
        double _dTotal = 0;
        string food = string.Empty;
        string foodselect = string.Empty;
        string foodtable = string.Empty;
        string foodid = string.Empty;
        string foodname = string.Empty;
        string foodprice = string.Empty;
        string foodco = string.Empty;
        private int status = 0;
        public string addlist(ListBox f)
        {
            string currentRow = string.Empty;
            foreach (string x in listOrder.Items)
            {               
                currentRow += listOrder.Items.ToString();
            }
            return currentRow;
        }
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        string cn = "Data Source=DESKTOP-UQ0KT1B\\SQLEXPRESS;Initial Catalog=Nuiiz;Integrated Security=True";

        public int Status { get => status; set => status = value; }

        private void buttonCFresh_Click(object sender, EventArgs e)
        {
            food = "Vegetable";
            foodid = "vegetID";
            foodname = "vegetName";
            foodprice = "vegetPrice";
            foodco = "vegetID=";

            foodselect = "vegetName,vegetPrice";
            foodtable = "Vegetable";
            Status = 1;
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT "+foodselect+" FROM "+foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void buttonAddtolist_Click(object sender, EventArgs e)
        {
            List<string> selectedRows = new List<string>();

            foreach (DataGridViewRow row in dataOrder.SelectedRows)
            {
                string currentRow = string.Empty;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    currentRow += String.Format("{0} ", cell.FormattedValue);
                }

                selectedRows.Add(currentRow);
            }
            /****************************************************************/
            
            for (int i = 0; i < selectedRows.Count; i++)
            {
                
                
                this.listOrder.Items.Add(selectedRows[i]);
                

            }
            _dTotal = 0;
            foreach (string x in listOrder.Items)
            {
                
                double num;
                if (double.TryParse(x.Substring(x.LastIndexOf("     ")), out num)) //supstring p.204 //p.207 
                {
                    _dTotal += num;
                }
            }

            DataRow[] drs = ds2.Tables["Bill"].Select("billNo='" + label1.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds2.Tables["Bill"].NewRow();
                dr["billNo"] = textBox2.Text;
                dr["billName"] = textBox3.Text;
                dr["billPrice"] = textBox4.Text;
                ds2.Tables["Bill"].Rows.Add(dr);
            }
            else
            {
                drs[0]["billID"] = textBox2.Text;
                drs[0]["billName"] =    textBox3.Text;
                drs[0]["billPrice"] = textBox4.Text;

            }

            dataGridView1.DataSource = ds2.Tables["Bill"];
            textSumPrice.Text = _dTotal.ToString("#,##0.00");

            /*string sql = "SELECT* FROM " + food;
            SqlDataAdapter dw = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(dw);
            dw.Update(ds, food);*/
            string sql = "SELECT * FROM Bill" ;
            SqlDataAdapter dw = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(dw);
            dw.Update(ds2, "Bill");

            var form2 = new Form_Chef(listOrder);
           
            form2.Show();
            
            form2.Refresh();

            /*if(dataOrder)
            DataRow dr = ds.Tables["Vegetable"].Rows[1];*/

            /*DataGridViewRow dgr = dataOrder.Select.t
            string order = dataOrder.SelectedRows.ToString();
            listOrder.Items.Add(dataOrder.);*/
        }

        private void dataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                DataRow dr = ds.Tables[food].Rows[e.RowIndex];
                textBox2.Text = "B0001";
                textBox3.Text = dr[foodname].ToString();
                textBox4.Text = dr[foodprice].ToString();
                /*DataGridViewRow dgr = dataMenu.Rows[e.RowIndex];
                textID.Text = dgr.Cells[0].Value.ToString();
                textName.Text = dgr.Cells[1].Value.ToString();
                textPrice.Text = dgr.Cells[2].Value.ToString();*/
                dataOrder.Rows[e.RowIndex].Selected = true;
            }
            
        }

        private void buttonDelatList_Click(object sender, EventArgs e)
        {

            if (listOrder.SelectedIndex != -1)
            {
                double num;
                string delOrder = listOrder.SelectedIndex.ToString();
                if (double.TryParse(delOrder.Substring(delOrder.LastIndexOf("     ")),out num));              
                {
                    _dTotal -= num;
                }
                listOrder.Items.RemoveAt(listOrder.SelectedIndex);
            }
            /*foreach (string x in listOrder.Items)
            {

                
            }*/
            textSumPrice.Text = _dTotal.ToString("#,##0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var form2 = new Form_Chef(listOrder);
            form2.Show();*/

        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            /*Form_Chef d = new Form_Chef(listOrder);*/
            string sql = "SELECT tableName FROM Table1";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "Table1");
            textTable.Text = ds.Tables["Table1"].Rows[0].ItemArray[0].ToString();

            string sql2 = "SELECT * FROM Bill";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.Fill(ds2, "Bill");
            dataGridView1.DataSource = ds.Tables["Bill"];

        }

        private void buttonFresh_Click(object sender, EventArgs e)
        {
            food = "Fresh_Foods";
            
            foodname = "foodName";
            foodprice = "foodPrice";
            foodco = "foodID=";
            foodid = "foodID";
            foodselect = "foodName,foodPrice";
            foodtable = "Fresh_Foods";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];

        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            food = "A_La_Carte";
            foodid = "carteID";
            foodname = "carteName";
            foodprice = "cartePrice";
            foodco = "carteID=";
            foodselect = "CarteName,CartePrice";
            foodtable = "A_La_Carte";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void buttonDim_Click(object sender, EventArgs e)
        {
            food = "Dimsum";
            foodid = "dimsumID";
            foodname = "dimsumName";
            foodprice = "dimsumPrice";
            foodco = "dimsumID=";
            foodselect = "dimsumName,dimsumPrice";
            foodtable = "Dimsum";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void buttonNoodle_Click(object sender, EventArgs e)
        {
            food = "Noodles";
            foodid = "noodleID";
            foodname = "noodleName";
            foodprice = "noodlePrice";
            foodco = "noodleID=";
            foodselect = "noodleName,noodlePrice";
            foodtable = "Noodles";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void buttonDrink_Click(object sender, EventArgs e)
        {
            food = "Beverages";
            foodid = "beverID";
            foodname = "beverName";
            foodprice = "beverPrice";
            foodco = "beverID=";
            foodselect = "beverName,beverPrice";
            foodtable = "Beverages";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void buttonDess_Click(object sender, EventArgs e)
        {

            food = "Desserts";
            foodid = "dessertID";
            foodname = "dessertName";
            foodprice = "dessertPrice";
            foodco = "dessertID=";
            foodselect = "dessertName,dessertPrice";
            foodtable = "Desserts";
            ds.Clear();
            dataOrder.ClearSelection();
            string sql = "SELECT " + foodselect + " FROM " + foodtable;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, foodtable);
            dataOrder.DataSource = ds.Tables[foodtable];
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
