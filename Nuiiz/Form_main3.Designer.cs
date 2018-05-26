namespace Nuiiz
{
    partial class Form_main3
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
            this.buttonChef = new System.Windows.Forms.Button();
            this.btOpCus = new System.Windows.Forms.Button();
            this.btOpAddstsaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChef
            // 
            this.buttonChef.Location = new System.Drawing.Point(81, 224);
            this.buttonChef.Name = "buttonChef";
            this.buttonChef.Size = new System.Drawing.Size(115, 68);
            this.buttonChef.TabIndex = 5;
            this.buttonChef.Text = "ห้องครัว";
            this.buttonChef.UseVisualStyleBackColor = true;
            // 
            // btOpCus
            // 
            this.btOpCus.Location = new System.Drawing.Point(243, 100);
            this.btOpCus.Name = "btOpCus";
            this.btOpCus.Size = new System.Drawing.Size(115, 68);
            this.btOpCus.TabIndex = 4;
            this.btOpCus.Text = "เพิ่มรายการอาหาร";
            this.btOpCus.UseVisualStyleBackColor = true;
            // 
            // btOpAddstsaff
            // 
            this.btOpAddstsaff.Location = new System.Drawing.Point(81, 100);
            this.btOpAddstsaff.Name = "btOpAddstsaff";
            this.btOpAddstsaff.Size = new System.Drawing.Size(115, 68);
            this.btOpAddstsaff.TabIndex = 3;
            this.btOpAddstsaff.Text = "เพิ่มพนักงาน";
            this.btOpAddstsaff.UseVisualStyleBackColor = true;
            // 
            // Form_main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.buttonChef);
            this.Controls.Add(this.btOpCus);
            this.Controls.Add(this.btOpAddstsaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main3";
            this.Text = "Form_main3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChef;
        private System.Windows.Forms.Button btOpCus;
        private System.Windows.Forms.Button btOpAddstsaff;
    }
}