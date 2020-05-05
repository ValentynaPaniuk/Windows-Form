namespace Classwork20200504_Telephone_Directory
{
    partial class Child
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
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Photo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(67, 41);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(177, 20);
            this.Tb_Name.TabIndex = 0;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Location = new System.Drawing.Point(67, 73);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(177, 20);
            this.Tb_Phone.TabIndex = 0;
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Location = new System.Drawing.Point(26, 44);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(38, 13);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name:";
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.AutoSize = true;
            this.Lb_Phone.Location = new System.Drawing.Point(26, 76);
            this.Lb_Phone.Name = "Lb_Phone";
            this.Lb_Phone.Size = new System.Drawing.Size(38, 13);
            this.Lb_Phone.TabIndex = 2;
            this.Lb_Phone.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Photo);
            this.groupBox1.Controls.Add(this.Btn_Cancel);
            this.groupBox1.Controls.Add(this.Btn_Ok);
            this.groupBox1.Controls.Add(this.Lb_Phone);
            this.groupBox1.Controls.Add(this.Lb_Name);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Controls.Add(this.Tb_Phone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(87, 118);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(6, 118);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 5;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Photo
            // 
            this.Btn_Photo.Location = new System.Drawing.Point(168, 118);
            this.Btn_Photo.Name = "Btn_Photo";
            this.Btn_Photo.Size = new System.Drawing.Size(87, 23);
            this.Btn_Photo.TabIndex = 6;
            this.Btn_Photo.Text = "Add Photo";
            this.Btn_Photo.UseVisualStyleBackColor = true;
            this.Btn_Photo.Click += new System.EventHandler(this.Btn_Photo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "Child";
            this.Text = "Contact";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Photo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}