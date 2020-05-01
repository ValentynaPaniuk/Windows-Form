namespace Classwork20200429_Registration
{
    partial class Registrasion
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
            this.components = new System.ComponentModel.Container();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Surname = new System.Windows.Forms.TextBox();
            this.Tb_Year = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_Surname = new System.Windows.Forms.Label();
            this.Lb_Year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Image = new System.Windows.Forms.Label();
            this.Tb_Image = new System.Windows.Forms.TextBox();
            this.Cb_guestion = new System.Windows.Forms.ComboBox();
            this.Lb_Question = new System.Windows.Forms.Label();
            this.Tb_Answer = new System.Windows.Forms.TextBox();
            this.Lb_Answer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Lb_Phone = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(234, 26);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(216, 20);
            this.Tb_Name.TabIndex = 0;
            this.Tb_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Tb_Surname
            // 
            this.Tb_Surname.Location = new System.Drawing.Point(234, 54);
            this.Tb_Surname.Name = "Tb_Surname";
            this.Tb_Surname.Size = new System.Drawing.Size(216, 20);
            this.Tb_Surname.TabIndex = 0;
            this.Tb_Surname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Tb_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Tb_Year
            // 
            this.Tb_Year.Location = new System.Drawing.Point(234, 83);
            this.Tb_Year.Name = "Tb_Year";
            this.Tb_Year.Size = new System.Drawing.Size(216, 20);
            this.Tb_Year.TabIndex = 0;
            this.Tb_Year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Tb_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Year_KeyPress);
            this.Tb_Year.Validating += new System.ComponentModel.CancelEventHandler(this.Tb_Year_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Location = new System.Drawing.Point(146, 33);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(57, 13);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "First Name";
            // 
            // Lb_Surname
            // 
            this.Lb_Surname.AutoSize = true;
            this.Lb_Surname.Location = new System.Drawing.Point(142, 61);
            this.Lb_Surname.Name = "Lb_Surname";
            this.Lb_Surname.Size = new System.Drawing.Size(58, 13);
            this.Lb_Surname.TabIndex = 2;
            this.Lb_Surname.Text = "Last Name";
            // 
            // Lb_Year
            // 
            this.Lb_Year.AutoSize = true;
            this.Lb_Year.Location = new System.Drawing.Point(121, 88);
            this.Lb_Year.Name = "Lb_Year";
            this.Lb_Year.Size = new System.Drawing.Size(82, 13);
            this.Lb_Year.TabIndex = 2;
            this.Lb_Year.Text = "Year of Birthday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(451, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(451, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(451, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Lb_Image
            // 
            this.Lb_Image.AutoSize = true;
            this.Lb_Image.Location = new System.Drawing.Point(105, 146);
            this.Lb_Image.Name = "Lb_Image";
            this.Lb_Image.Size = new System.Drawing.Size(95, 13);
            this.Lb_Image.TabIndex = 2;
            this.Lb_Image.Text = "Upload your image";
            // 
            // Tb_Image
            // 
            this.Tb_Image.Location = new System.Drawing.Point(234, 143);
            this.Tb_Image.Name = "Tb_Image";
            this.Tb_Image.Size = new System.Drawing.Size(216, 20);
            this.Tb_Image.TabIndex = 0;
            this.Tb_Image.Click += new System.EventHandler(this.Tb_Image_Click);
            // 
            // Cb_guestion
            // 
            this.Cb_guestion.FormattingEnabled = true;
            this.Cb_guestion.Items.AddRange(new object[] {
            "Mother\'s maider name?",
            "What is your brother\'s name?"});
            this.Cb_guestion.Location = new System.Drawing.Point(234, 171);
            this.Cb_guestion.Name = "Cb_guestion";
            this.Cb_guestion.Size = new System.Drawing.Size(216, 21);
            this.Cb_guestion.TabIndex = 4;
            // 
            // Lb_Question
            // 
            this.Lb_Question.AutoSize = true;
            this.Lb_Question.Location = new System.Drawing.Point(131, 174);
            this.Lb_Question.Name = "Lb_Question";
            this.Lb_Question.Size = new System.Drawing.Size(69, 13);
            this.Lb_Question.TabIndex = 2;
            this.Lb_Question.Text = "Hint question";
            // 
            // Tb_Answer
            // 
            this.Tb_Answer.Location = new System.Drawing.Point(234, 198);
            this.Tb_Answer.Name = "Tb_Answer";
            this.Tb_Answer.Size = new System.Drawing.Size(216, 20);
            this.Tb_Answer.TabIndex = 0;
            // 
            // Lb_Answer
            // 
            this.Lb_Answer.AutoSize = true;
            this.Lb_Answer.Location = new System.Drawing.Point(158, 198);
            this.Lb_Answer.Name = "Lb_Answer";
            this.Lb_Answer.Size = new System.Drawing.Size(42, 13);
            this.Lb_Answer.TabIndex = 2;
            this.Lb_Answer.Text = "Answer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_Surname);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Cb_guestion);
            this.groupBox1.Controls.Add(this.Tb_Surname);
            this.groupBox1.Controls.Add(this.Tb_Phone);
            this.groupBox1.Controls.Add(this.Tb_Year);
            this.groupBox1.Controls.Add(this.Lb_Answer);
            this.groupBox1.Controls.Add(this.Tb_Image);
            this.groupBox1.Controls.Add(this.Lb_Question);
            this.groupBox1.Controls.Add(this.Tb_Answer);
            this.groupBox1.Controls.Add(this.Lb_Image);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Lb_Phone);
            this.groupBox1.Controls.Add(this.Lb_Year);
            this.groupBox1.Controls.Add(this.Lb_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Page";
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Location = new System.Drawing.Point(234, 111);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(216, 20);
            this.Tb_Phone.TabIndex = 0;
            this.Tb_Phone.Click += new System.EventHandler(this.Tb_Phone_Click);
            this.Tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Year_KeyPress);
            this.Tb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.Tb_Year_Validating);
            // 
            // Lb_Phone
            // 
            this.Lb_Phone.AutoSize = true;
            this.Lb_Phone.Location = new System.Drawing.Point(158, 118);
            this.Lb_Phone.Name = "Lb_Phone";
            this.Lb_Phone.Size = new System.Drawing.Size(38, 13);
            this.Lb_Phone.TabIndex = 2;
            this.Lb_Phone.Text = "Phone";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(489, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 264);
            this.listBox1.TabIndex = 7;
            // 
            // Registrasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 329);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Registrasion";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.TextBox Tb_Surname;
        private System.Windows.Forms.TextBox Tb_Year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Surname;
        private System.Windows.Forms.Label Lb_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox Cb_guestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_Image;
        private System.Windows.Forms.TextBox Tb_Image;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label Lb_Answer;
        private System.Windows.Forms.Label Lb_Question;
        private System.Windows.Forms.TextBox Tb_Answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.Label Lb_Phone;
    }
}

