namespace Nuiiz
{
    partial class Form_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.buttonAddtolist = new System.Windows.Forms.Button();
            this.buttonDelatList = new System.Windows.Forms.Button();
            this.buttonCFresh = new System.Windows.Forms.Button();
            this.textSumPrice = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFresh = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonDim = new System.Windows.Forms.Button();
            this.buttonNoodle = new System.Windows.Forms.Button();
            this.buttonDrink = new System.Windows.Forms.Button();
            this.buttonDess = new System.Windows.Forms.Button();
            this.textTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOrder
            // 
            this.dataOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Location = new System.Drawing.Point(27, 66);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.Size = new System.Drawing.Size(633, 468);
            this.dataOrder.TabIndex = 0;
            this.dataOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrder_CellContentClick);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 20;
            this.listOrder.Location = new System.Drawing.Point(680, 153);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(264, 304);
            this.listOrder.TabIndex = 1;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // buttonAddtolist
            // 
            this.buttonAddtolist.Location = new System.Drawing.Point(50, 577);
            this.buttonAddtolist.Name = "buttonAddtolist";
            this.buttonAddtolist.Size = new System.Drawing.Size(81, 35);
            this.buttonAddtolist.TabIndex = 2;
            this.buttonAddtolist.Text = "สั่ง";
            this.buttonAddtolist.UseVisualStyleBackColor = true;
            this.buttonAddtolist.Click += new System.EventHandler(this.buttonAddtolist_Click);
            // 
            // buttonDelatList
            // 
            this.buttonDelatList.Location = new System.Drawing.Point(164, 577);
            this.buttonDelatList.Name = "buttonDelatList";
            this.buttonDelatList.Size = new System.Drawing.Size(81, 35);
            this.buttonDelatList.TabIndex = 3;
            this.buttonDelatList.Text = "ลบ";
            this.buttonDelatList.UseVisualStyleBackColor = true;
            this.buttonDelatList.Visible = false;
            this.buttonDelatList.Click += new System.EventHandler(this.buttonDelatList_Click);
            // 
            // buttonCFresh
            // 
            this.buttonCFresh.Location = new System.Drawing.Point(27, 25);
            this.buttonCFresh.Name = "buttonCFresh";
            this.buttonCFresh.Size = new System.Drawing.Size(81, 35);
            this.buttonCFresh.TabIndex = 4;
            this.buttonCFresh.Text = "ผัก";
            this.buttonCFresh.UseVisualStyleBackColor = true;
            this.buttonCFresh.Click += new System.EventHandler(this.buttonCFresh_Click);
            // 
            // textSumPrice
            // 
            this.textSumPrice.Location = new System.Drawing.Point(784, 121);
            this.textSumPrice.Name = "textSumPrice";
            this.textSumPrice.Size = new System.Drawing.Size(100, 26);
            this.textSumPrice.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 545);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1013, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 304);
            this.listBox1.TabIndex = 8;
            this.listBox1.Visible = false;
            // 
            // buttonFresh
            // 
            this.buttonFresh.Location = new System.Drawing.Point(114, 25);
            this.buttonFresh.Name = "buttonFresh";
            this.buttonFresh.Size = new System.Drawing.Size(81, 35);
            this.buttonFresh.TabIndex = 9;
            this.buttonFresh.Text = "อาหารสด";
            this.buttonFresh.UseVisualStyleBackColor = true;
            this.buttonFresh.Click += new System.EventHandler(this.buttonFresh_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.Location = new System.Drawing.Point(201, 25);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(111, 35);
            this.buttonCart.TabIndex = 10;
            this.buttonCart.Text = "อาหารจานเดียว";
            this.buttonCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // buttonDim
            // 
            this.buttonDim.Location = new System.Drawing.Point(318, 25);
            this.buttonDim.Name = "buttonDim";
            this.buttonDim.Size = new System.Drawing.Size(81, 35);
            this.buttonDim.TabIndex = 11;
            this.buttonDim.Text = "ติ่มซำ";
            this.buttonDim.UseVisualStyleBackColor = true;
            this.buttonDim.Click += new System.EventHandler(this.buttonDim_Click);
            // 
            // buttonNoodle
            // 
            this.buttonNoodle.Location = new System.Drawing.Point(405, 25);
            this.buttonNoodle.Name = "buttonNoodle";
            this.buttonNoodle.Size = new System.Drawing.Size(81, 35);
            this.buttonNoodle.TabIndex = 12;
            this.buttonNoodle.Text = "บะหมี่";
            this.buttonNoodle.UseVisualStyleBackColor = true;
            this.buttonNoodle.Click += new System.EventHandler(this.buttonNoodle_Click);
            // 
            // buttonDrink
            // 
            this.buttonDrink.Location = new System.Drawing.Point(492, 25);
            this.buttonDrink.Name = "buttonDrink";
            this.buttonDrink.Size = new System.Drawing.Size(81, 35);
            this.buttonDrink.TabIndex = 13;
            this.buttonDrink.Text = "เครื่องดื่ม";
            this.buttonDrink.UseVisualStyleBackColor = true;
            this.buttonDrink.Click += new System.EventHandler(this.buttonDrink_Click);
            // 
            // buttonDess
            // 
            this.buttonDess.Location = new System.Drawing.Point(579, 25);
            this.buttonDess.Name = "buttonDess";
            this.buttonDess.Size = new System.Drawing.Size(81, 35);
            this.buttonDess.TabIndex = 14;
            this.buttonDess.Text = "ของหวาน";
            this.buttonDess.UseVisualStyleBackColor = true;
            this.buttonDess.Click += new System.EventHandler(this.buttonDess_Click);
            // 
            // textTable
            // 
            this.textTable.ForeColor = System.Drawing.Color.Red;
            this.textTable.Location = new System.Drawing.Point(863, 56);
            this.textTable.Multiline = true;
            this.textTable.Name = "textTable";
            this.textTable.ReadOnly = true;
            this.textTable.Size = new System.Drawing.Size(81, 36);
            this.textTable.TabIndex = 15;
            this.textTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 605);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(697, 600);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(814, 600);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 21;
            this.textBox4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(935, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "โต๊ะ";
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 665);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTable);
            this.Controls.Add(this.buttonDess);
            this.Controls.Add(this.buttonDrink);
            this.Controls.Add(this.buttonNoodle);
            this.Controls.Add(this.buttonDim);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.buttonFresh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textSumPrice);
            this.Controls.Add(this.buttonCFresh);
            this.Controls.Add(this.buttonDelatList);
            this.Controls.Add(this.buttonAddtolist);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.dataOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Customer";
            this.Text = "Form_Customer";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Button buttonAddtolist;
        private System.Windows.Forms.Button buttonDelatList;
        private System.Windows.Forms.Button buttonCFresh;
        private System.Windows.Forms.TextBox textSumPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listOrder;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFresh;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonDim;
        private System.Windows.Forms.Button buttonNoodle;
        private System.Windows.Forms.Button buttonDrink;
        private System.Windows.Forms.Button buttonDess;
        private System.Windows.Forms.TextBox textTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}