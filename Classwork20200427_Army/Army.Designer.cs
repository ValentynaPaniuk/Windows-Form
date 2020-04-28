namespace Classwork20200427_Army
{
    partial class Army
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
            this.Lb_One = new System.Windows.Forms.ListBox();
            this.Lb_All = new System.Windows.Forms.ListBox();
            this.Lb_Two = new System.Windows.Forms.ListBox();
            this.Lb_Select_Team = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Bt_Add_Two = new System.Windows.Forms.Button();
            this.Bt_Add_One = new System.Windows.Forms.Button();
            this.Add_File_One = new System.Windows.Forms.Button();
            this.Add_File_Two = new System.Windows.Forms.Button();
            this.Rb_Two = new System.Windows.Forms.RadioButton();
            this.Rb_One = new System.Windows.Forms.RadioButton();
            this.Lb_Team = new System.Windows.Forms.Label();
            this.Lb_Max = new System.Windows.Forms.Label();
            this.Lb_Team_One = new System.Windows.Forms.Label();
            this.Lb_Team_Two = new System.Windows.Forms.Label();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.Bt_Delete_Unit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_One
            // 
            this.Lb_One.FormattingEnabled = true;
            this.Lb_One.Location = new System.Drawing.Point(12, 26);
            this.Lb_One.Name = "Lb_One";
            this.Lb_One.Size = new System.Drawing.Size(215, 108);
            this.Lb_One.TabIndex = 0;
            // 
            // Lb_All
            // 
            this.Lb_All.FormattingEnabled = true;
            this.Lb_All.Location = new System.Drawing.Point(290, 12);
            this.Lb_All.Name = "Lb_All";
            this.Lb_All.Size = new System.Drawing.Size(215, 108);
            this.Lb_All.TabIndex = 0;
            // 
            // Lb_Two
            // 
            this.Lb_Two.FormattingEnabled = true;
            this.Lb_Two.Location = new System.Drawing.Point(564, 27);
            this.Lb_Two.Name = "Lb_Two";
            this.Lb_Two.Size = new System.Drawing.Size(215, 108);
            this.Lb_Two.TabIndex = 0;
            // 
            // Lb_Select_Team
            // 
            this.Lb_Select_Team.FormattingEnabled = true;
            this.Lb_Select_Team.Location = new System.Drawing.Point(12, 268);
            this.Lb_Select_Team.Name = "Lb_Select_Team";
            this.Lb_Select_Team.Size = new System.Drawing.Size(215, 108);
            this.Lb_Select_Team.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(360, 188);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bt_Add_Two
            // 
            this.Bt_Add_Two.Location = new System.Drawing.Point(511, 47);
            this.Bt_Add_Two.Name = "Bt_Add_Two";
            this.Bt_Add_Two.Size = new System.Drawing.Size(47, 32);
            this.Bt_Add_Two.TabIndex = 2;
            this.Bt_Add_Two.Text = "Add ->";
            this.Bt_Add_Two.UseVisualStyleBackColor = true;
            this.Bt_Add_Two.Click += new System.EventHandler(this.Bt_Add_Two_Click);
            // 
            // Bt_Add_One
            // 
            this.Bt_Add_One.Location = new System.Drawing.Point(236, 47);
            this.Bt_Add_One.Name = "Bt_Add_One";
            this.Bt_Add_One.Size = new System.Drawing.Size(48, 32);
            this.Bt_Add_One.TabIndex = 2;
            this.Bt_Add_One.Text = "<- Add";
            this.Bt_Add_One.UseVisualStyleBackColor = true;
            this.Bt_Add_One.Click += new System.EventHandler(this.Bt_Add_One_Click);
            // 
            // Add_File_One
            // 
            this.Add_File_One.Location = new System.Drawing.Point(38, 143);
            this.Add_File_One.Name = "Add_File_One";
            this.Add_File_One.Size = new System.Drawing.Size(148, 32);
            this.Add_File_One.TabIndex = 2;
            this.Add_File_One.Text = "Add File One Team";
            this.Add_File_One.UseVisualStyleBackColor = true;
            this.Add_File_One.Click += new System.EventHandler(this.Add_File_One_Click);
            // 
            // Add_File_Two
            // 
            this.Add_File_Two.Location = new System.Drawing.Point(595, 143);
            this.Add_File_Two.Name = "Add_File_Two";
            this.Add_File_Two.Size = new System.Drawing.Size(148, 32);
            this.Add_File_Two.TabIndex = 2;
            this.Add_File_Two.Text = "Add File Two Team";
            this.Add_File_Two.UseVisualStyleBackColor = true;
            this.Add_File_Two.Click += new System.EventHandler(this.Add_File_Two_Click);
            // 
            // Rb_Two
            // 
            this.Rb_Two.AutoSize = true;
            this.Rb_Two.Location = new System.Drawing.Point(415, 277);
            this.Rb_Two.Name = "Rb_Two";
            this.Rb_Two.Size = new System.Drawing.Size(46, 17);
            this.Rb_Two.TabIndex = 3;
            this.Rb_Two.Text = "Two";
            this.Rb_Two.UseVisualStyleBackColor = true;
            this.Rb_Two.CheckedChanged += new System.EventHandler(this.Rb_One_CheckedChanged);
            // 
            // Rb_One
            // 
            this.Rb_One.AutoSize = true;
            this.Rb_One.Location = new System.Drawing.Point(290, 278);
            this.Rb_One.Name = "Rb_One";
            this.Rb_One.Size = new System.Drawing.Size(45, 17);
            this.Rb_One.TabIndex = 3;
            this.Rb_One.Text = "One";
            this.Rb_One.UseVisualStyleBackColor = true;
            this.Rb_One.CheckedChanged += new System.EventHandler(this.Rb_One_CheckedChanged);
            // 
            // Lb_Team
            // 
            this.Lb_Team.AutoSize = true;
            this.Lb_Team.Location = new System.Drawing.Point(336, 247);
            this.Lb_Team.Name = "Lb_Team";
            this.Lb_Team.Size = new System.Drawing.Size(76, 13);
            this.Lb_Team.TabIndex = 4;
            this.Lb_Team.Text = "Select a Team";
            // 
            // Lb_Max
            // 
            this.Lb_Max.AutoSize = true;
            this.Lb_Max.Location = new System.Drawing.Point(336, 172);
            this.Lb_Max.Name = "Lb_Max";
            this.Lb_Max.Size = new System.Drawing.Size(140, 13);
            this.Lb_Max.TabIndex = 5;
            this.Lb_Max.Text = "Maximum number of players:";
            // 
            // Lb_Team_One
            // 
            this.Lb_Team_One.AutoSize = true;
            this.Lb_Team_One.Location = new System.Drawing.Point(12, 9);
            this.Lb_Team_One.Name = "Lb_Team_One";
            this.Lb_Team_One.Size = new System.Drawing.Size(60, 13);
            this.Lb_Team_One.TabIndex = 6;
            this.Lb_Team_One.Text = "Team One:";
            // 
            // Lb_Team_Two
            // 
            this.Lb_Team_Two.AutoSize = true;
            this.Lb_Team_Two.Location = new System.Drawing.Point(561, 9);
            this.Lb_Team_Two.Name = "Lb_Team_Two";
            this.Lb_Team_Two.Size = new System.Drawing.Size(61, 13);
            this.Lb_Team_Two.TabIndex = 6;
            this.Lb_Team_Two.Text = "Team Two:";
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.Location = new System.Drawing.Point(315, 325);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(133, 40);
            this.Bt_Clear.TabIndex = 7;
            this.Bt_Clear.Text = "Clear";
            this.Bt_Clear.UseVisualStyleBackColor = true;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Bt_Delete_Unit
            // 
            this.Bt_Delete_Unit.Location = new System.Drawing.Point(50, 209);
            this.Bt_Delete_Unit.Name = "Bt_Delete_Unit";
            this.Bt_Delete_Unit.Size = new System.Drawing.Size(96, 24);
            this.Bt_Delete_Unit.TabIndex = 8;
            this.Bt_Delete_Unit.Text = "Delete";
            this.Bt_Delete_Unit.UseVisualStyleBackColor = true;
            this.Bt_Delete_Unit.Click += new System.EventHandler(this.Bt_Delete_Unit_Click);
            // 
            // Army
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Delete_Unit);
            this.Controls.Add(this.Bt_Clear);
            this.Controls.Add(this.Lb_Team_Two);
            this.Controls.Add(this.Lb_Team_One);
            this.Controls.Add(this.Lb_Max);
            this.Controls.Add(this.Lb_Team);
            this.Controls.Add(this.Rb_One);
            this.Controls.Add(this.Rb_Two);
            this.Controls.Add(this.Add_File_Two);
            this.Controls.Add(this.Add_File_One);
            this.Controls.Add(this.Bt_Add_One);
            this.Controls.Add(this.Bt_Add_Two);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Lb_Select_Team);
            this.Controls.Add(this.Lb_Two);
            this.Controls.Add(this.Lb_All);
            this.Controls.Add(this.Lb_One);
            this.Name = "Army";
            this.Text = "Army";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_One;
        private System.Windows.Forms.ListBox Lb_All;
        private System.Windows.Forms.ListBox Lb_Two;
        private System.Windows.Forms.ListBox Lb_Select_Team;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Bt_Add_Two;
        private System.Windows.Forms.Button Bt_Add_One;
        private System.Windows.Forms.Button Add_File_One;
        private System.Windows.Forms.Button Add_File_Two;
        private System.Windows.Forms.RadioButton Rb_Two;
        private System.Windows.Forms.RadioButton Rb_One;
        private System.Windows.Forms.Label Lb_Team;
        private System.Windows.Forms.Label Lb_Max;
        private System.Windows.Forms.Label Lb_Team_One;
        private System.Windows.Forms.Label Lb_Team_Two;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.Button Bt_Delete_Unit;
    }
}

