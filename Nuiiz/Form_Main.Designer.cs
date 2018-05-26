namespace Nuiiz
{
    partial class Form_Main
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
            this.btOpAddstsaff = new System.Windows.Forms.Button();
            this.btOpCus = new System.Windows.Forms.Button();
            this.buttonChef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpAddstsaff
            // 
            this.btOpAddstsaff.Location = new System.Drawing.Point(76, 94);
            this.btOpAddstsaff.Name = "btOpAddstsaff";
            this.btOpAddstsaff.Size = new System.Drawing.Size(115, 68);
            this.btOpAddstsaff.TabIndex = 0;
            this.btOpAddstsaff.Text = "เพิ่มพนักงาน";
            this.btOpAddstsaff.UseVisualStyleBackColor = true;
            this.btOpAddstsaff.Click += new System.EventHandler(this.btOpAddstsaff_Click);
            // 
            // btOpCus
            // 
            this.btOpCus.Location = new System.Drawing.Point(238, 94);
            this.btOpCus.Name = "btOpCus";
            this.btOpCus.Size = new System.Drawing.Size(115, 68);
            this.btOpCus.TabIndex = 1;
            this.btOpCus.Text = "เพิ่มรายการอาหาร";
            this.btOpCus.UseVisualStyleBackColor = true;
            this.btOpCus.Click += new System.EventHandler(this.btOpCus_Click);
            // 
            // buttonChef
            // 
            this.buttonChef.Location = new System.Drawing.Point(76, 218);
            this.buttonChef.Name = "buttonChef";
            this.buttonChef.Size = new System.Drawing.Size(115, 68);
            this.buttonChef.TabIndex = 2;
            this.buttonChef.Text = "ห้องครัว";
            this.buttonChef.UseVisualStyleBackColor = true;
            this.buttonChef.Click += new System.EventHandler(this.buttonChef_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "ฟอร์มลูกค้า";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonChef);
            this.Controls.Add(this.btOpCus);
            this.Controls.Add(this.btOpAddstsaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpAddstsaff;
        private System.Windows.Forms.Button btOpCus;
        private System.Windows.Forms.Button buttonChef;
        private System.Windows.Forms.Button button1;
    }
}