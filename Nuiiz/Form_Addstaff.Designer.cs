namespace Nuiiz
{
    partial class Form_Addstaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataStaff = new System.Windows.Forms.DataGridView();
            this.textS_ID = new System.Windows.Forms.TextBox();
            this.textS_Password = new System.Windows.Forms.TextBox();
            this.textS_FName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textStat = new System.Windows.Forms.TextBox();
            this.btS_Update = new System.Windows.Forms.Button();
            this.btS_Del = new System.Windows.Forms.Button();
            this.btS_Insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textS_Tel = new System.Windows.Forms.TextBox();
            this.textS_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textS_Birth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textS_IDNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textS_NName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textS_LName = new System.Windows.Forms.TextBox();
            this.buttonBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // dataStaff
            // 
            this.dataStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(12, 67);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.Size = new System.Drawing.Size(808, 269);
            this.dataStaff.TabIndex = 4;
            this.dataStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStaff_CellContentClick);
            // 
            // textS_ID
            // 
            this.textS_ID.Location = new System.Drawing.Point(101, 51);
            this.textS_ID.Name = "textS_ID";
            this.textS_ID.Size = new System.Drawing.Size(100, 26);
            this.textS_ID.TabIndex = 5;
            // 
            // textS_Password
            // 
            this.textS_Password.Location = new System.Drawing.Point(101, 83);
            this.textS_Password.Name = "textS_Password";
            this.textS_Password.Size = new System.Drawing.Size(100, 26);
            this.textS_Password.TabIndex = 6;
            // 
            // textS_FName
            // 
            this.textS_FName.Location = new System.Drawing.Point(101, 115);
            this.textS_FName.Name = "textS_FName";
            this.textS_FName.Size = new System.Drawing.Size(100, 26);
            this.textS_FName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textStat);
            this.groupBox1.Controls.Add(this.btS_Update);
            this.groupBox1.Controls.Add(this.btS_Del);
            this.groupBox1.Controls.Add(this.btS_Insert);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textS_Tel);
            this.groupBox1.Controls.Add(this.textS_Address);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textS_Birth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textS_IDNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textS_NName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textS_LName);
            this.groupBox1.Controls.Add(this.textS_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textS_FName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textS_ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มพนักงาน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "ตำแหน่ง";
            // 
            // textStat
            // 
            this.textStat.Location = new System.Drawing.Point(388, 271);
            this.textStat.Name = "textStat";
            this.textStat.Size = new System.Drawing.Size(100, 26);
            this.textStat.TabIndex = 23;
            // 
            // btS_Update
            // 
            this.btS_Update.Location = new System.Drawing.Point(681, 161);
            this.btS_Update.Name = "btS_Update";
            this.btS_Update.Size = new System.Drawing.Size(75, 41);
            this.btS_Update.TabIndex = 22;
            this.btS_Update.Text = "Update";
            this.btS_Update.UseVisualStyleBackColor = true;
            // 
            // btS_Del
            // 
            this.btS_Del.Location = new System.Drawing.Point(681, 100);
            this.btS_Del.Name = "btS_Del";
            this.btS_Del.Size = new System.Drawing.Size(75, 41);
            this.btS_Del.TabIndex = 21;
            this.btS_Del.Text = "Delete";
            this.btS_Del.UseVisualStyleBackColor = true;
            this.btS_Del.Click += new System.EventHandler(this.btS_Del_Click);
            // 
            // btS_Insert
            // 
            this.btS_Insert.Location = new System.Drawing.Point(681, 44);
            this.btS_Insert.Name = "btS_Insert";
            this.btS_Insert.Size = new System.Drawing.Size(75, 41);
            this.btS_Insert.TabIndex = 20;
            this.btS_Insert.Text = "Insert";
            this.btS_Insert.UseVisualStyleBackColor = true;
            this.btS_Insert.Click += new System.EventHandler(this.btS_Insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "เบอร์โทร";
            // 
            // textS_Tel
            // 
            this.textS_Tel.Location = new System.Drawing.Point(388, 239);
            this.textS_Tel.Name = "textS_Tel";
            this.textS_Tel.Size = new System.Drawing.Size(155, 26);
            this.textS_Tel.TabIndex = 18;
            // 
            // textS_Address
            // 
            this.textS_Address.Location = new System.Drawing.Point(388, 115);
            this.textS_Address.Multiline = true;
            this.textS_Address.Name = "textS_Address";
            this.textS_Address.Size = new System.Drawing.Size(155, 118);
            this.textS_Address.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "ที่อยู่";
            // 
            // textS_Birth
            // 
            this.textS_Birth.Location = new System.Drawing.Point(388, 83);
            this.textS_Birth.Name = "textS_Birth";
            this.textS_Birth.Size = new System.Drawing.Size(100, 26);
            this.textS_Birth.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "วันเกิด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "รหัสบัตรประชาชน";
            // 
            // textS_IDNum
            // 
            this.textS_IDNum.Location = new System.Drawing.Point(388, 51);
            this.textS_IDNum.Name = "textS_IDNum";
            this.textS_IDNum.Size = new System.Drawing.Size(155, 26);
            this.textS_IDNum.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ชื่อเล่น";
            // 
            // textS_NName
            // 
            this.textS_NName.Location = new System.Drawing.Point(101, 179);
            this.textS_NName.Name = "textS_NName";
            this.textS_NName.Size = new System.Drawing.Size(100, 26);
            this.textS_NName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ชื่อ";
            // 
            // textS_LName
            // 
            this.textS_LName.Location = new System.Drawing.Point(101, 147);
            this.textS_LName.Name = "textS_LName";
            this.textS_LName.Size = new System.Drawing.Size(100, 26);
            this.textS_LName.TabIndex = 7;
            // 
            // buttonBox
            // 
            this.buttonBox.Location = new System.Drawing.Point(733, 12);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(87, 38);
            this.buttonBox.TabIndex = 8;
            this.buttonBox.Text = "Back";
            this.buttonBox.UseVisualStyleBackColor = true;
            this.buttonBox.Click += new System.EventHandler(this.buttonBox_Click);
            // 
            // Form_Addstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 672);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Addstaff";
            this.Text = "Form_Addstaff";
            this.Load += new System.EventHandler(this.Form_Addstaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.TextBox textS_ID;
        private System.Windows.Forms.TextBox textS_Password;
        private System.Windows.Forms.TextBox textS_FName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btS_Update;
        private System.Windows.Forms.Button btS_Del;
        private System.Windows.Forms.Button btS_Insert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textS_Tel;
        private System.Windows.Forms.TextBox textS_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textS_Birth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textS_IDNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textS_NName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textS_LName;
        private System.Windows.Forms.Button buttonBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textStat;
    }
}