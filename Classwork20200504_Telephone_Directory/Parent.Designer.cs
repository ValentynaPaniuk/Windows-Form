namespace Classwork20200504_Telephone_Directory
{
    partial class Parent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_AllContacts = new System.Windows.Forms.ListBox();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_AllContacts
            // 
            this.Lb_AllContacts.FormattingEnabled = true;
            this.Lb_AllContacts.Location = new System.Drawing.Point(150, 19);
            this.Lb_AllContacts.Name = "Lb_AllContacts";
            this.Lb_AllContacts.Size = new System.Drawing.Size(314, 277);
            this.Lb_AllContacts.TabIndex = 0;
            this.Lb_AllContacts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Bt_Add
            // 
            this.Bt_Add.Location = new System.Drawing.Point(14, 178);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(115, 23);
            this.Bt_Add.TabIndex = 1;
            this.Bt_Add.Text = "Add Contact";
            this.Bt_Add.UseVisualStyleBackColor = true;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(14, 207);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(115, 23);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "Edit Contact";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(14, 236);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(115, 23);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete Contact";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(14, 265);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(115, 23);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Lb_AllContacts);
            this.groupBox1.Controls.Add(this.Bt_Add);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Edit);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 315);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All contacts";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "Parent";
            this.Text = "All Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_AllContacts;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

