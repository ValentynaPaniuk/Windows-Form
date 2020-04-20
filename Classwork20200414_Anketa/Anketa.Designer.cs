namespace Classwork20200414_Anketa
{
    partial class Anketa
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rb_man = new System.Windows.Forms.RadioButton();
            this.Rb_woman = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(109, 9);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(241, 20);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "Enter name";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name:";
            // 
            // Rb_man
            // 
            this.Rb_man.AutoSize = true;
            this.Rb_man.Location = new System.Drawing.Point(128, 37);
            this.Rb_man.Name = "Rb_man";
            this.Rb_man.Size = new System.Drawing.Size(46, 17);
            this.Rb_man.TabIndex = 2;
            this.Rb_man.Text = "Man";
            this.Rb_man.UseVisualStyleBackColor = true;
            this.Rb_man.Click += new System.EventHandler(this.Rb_man_CheckedChanged);
            // 
            // Rb_woman
            // 
            this.Rb_woman.AutoSize = true;
            this.Rb_woman.Location = new System.Drawing.Point(237, 37);
            this.Rb_woman.Name = "Rb_woman";
            this.Rb_woman.Size = new System.Drawing.Size(62, 17);
            this.Rb_woman.TabIndex = 3;
            this.Rb_woman.Text = "Woman";
            this.Rb_woman.UseVisualStyleBackColor = true;
            this.Rb_woman.Click += new System.EventHandler(this.Rb_man_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose gender:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(109, 61);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.DateTimePicker1.TabIndex = 4;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Knowledge";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(9, 23);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(57, 17);
            this.CheckBox1.TabIndex = 5;
            this.CheckBox1.Text = "C/C++";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(72, 23);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(59, 17);
            this.CheckBox2.TabIndex = 5;
            this.CheckBox2.Text = "Python";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(142, 23);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(40, 17);
            this.CheckBox3.TabIndex = 5;
            this.CheckBox3.Text = "C#";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(234, 26);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(49, 17);
            this.CheckBox4.TabIndex = 5;
            this.CheckBox4.Text = "Java";
            this.CheckBox4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Language";
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(9, 25);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(60, 17);
            this.CheckBox5.TabIndex = 6;
            this.CheckBox5.Text = "English";
            this.CheckBox5.ThreeState = true;
            this.CheckBox5.UseVisualStyleBackColor = true;
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(142, 25);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(59, 17);
            this.CheckBox6.TabIndex = 6;
            this.CheckBox6.Text = "Franch";
            this.CheckBox6.ThreeState = true;
            this.CheckBox6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.CheckBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CheckBox1);
            this.panel1.Controls.Add(this.CheckBox4);
            this.panel1.Controls.Add(this.CheckBox3);
            this.panel1.Location = new System.Drawing.Point(18, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 46);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CheckBox5);
            this.panel2.Controls.Add(this.CheckBox8);
            this.panel2.Controls.Add(this.CheckBox7);
            this.panel2.Controls.Add(this.CheckBox6);
            this.panel2.Location = new System.Drawing.Point(18, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 52);
            this.panel2.TabIndex = 8;
            // 
            // CheckBox8
            // 
            this.CheckBox8.AutoSize = true;
            this.CheckBox8.Location = new System.Drawing.Point(234, 25);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(63, 17);
            this.CheckBox8.TabIndex = 6;
            this.CheckBox8.Text = "German";
            this.CheckBox8.ThreeState = true;
            this.CheckBox8.UseVisualStyleBackColor = true;
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(71, 25);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(58, 17);
            this.CheckBox7.TabIndex = 6;
            this.CheckBox7.Text = "Russin";
            this.CheckBox7.ThreeState = true;
            this.CheckBox7.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button1.Location = new System.Drawing.Point(49, 250);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(98, 32);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Add";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(373, 175);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(230, 147);
            this.ListBox1.TabIndex = 11;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(448, 7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(155, 162);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button2.Location = new System.Drawing.Point(235, 252);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(83, 32);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "Save";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button3.Location = new System.Drawing.Point(237, 290);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(83, 32);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "Load";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button4.Location = new System.Drawing.Point(49, 288);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(98, 32);
            this.Button4.TabIndex = 13;
            this.Button4.Text = "Clear";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Controls.Add(this.checkBox10);
            this.panel3.Controls.Add(this.checkBox11);
            this.panel3.Controls.Add(this.checkBox12);
            this.panel3.Location = new System.Drawing.Point(18, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 52);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hobby";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(9, 25);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(51, 17);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "Sport";
            this.checkBox9.ThreeState = true;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(234, 25);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(63, 17);
            this.checkBox10.TabIndex = 6;
            this.checkBox10.Text = "Another";
            this.checkBox10.ThreeState = true;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(71, 25);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(66, 17);
            this.checkBox11.TabIndex = 6;
            this.checkBox11.Text = "Reading";
            this.checkBox11.ThreeState = true;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(142, 25);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(86, 17);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Photography";
            this.checkBox12.ThreeState = true;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Rb_woman);
            this.Controls.Add(this.Rb_man);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox1);
            this.Name = "Anketa";
            this.Text = "Anketa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rb_man;
        private System.Windows.Forms.RadioButton Rb_woman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBox5;
        private System.Windows.Forms.CheckBox CheckBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CheckBox8;
        private System.Windows.Forms.CheckBox CheckBox7;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}

