namespace Classwork20200409_Student
{
    partial class Form
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
            this.Panel_enter_date = new System.Windows.Forms.Panel();
            this.Btn_add_student = new System.Windows.Forms.Button();
            this.Tb_hobby = new System.Windows.Forms.TextBox();
            this.Lbl_gender = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Lbl_birthday = new System.Windows.Forms.Label();
            this.DateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.Tb_surname = new System.Windows.Forms.TextBox();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.Panel_showinfo = new System.Windows.Forms.Panel();
            this.Btn_load_One = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_save_jason = new System.Windows.Forms.Button();
            this.Btn_save_by_surname = new System.Windows.Forms.Button();
            this.Btn_SaveAll = new System.Windows.Forms.Button();
            this.Btn_load = new System.Windows.Forms.Button();
            this.ListBox_add_student = new System.Windows.Forms.ListBox();
            this.Panel_enter_date.SuspendLayout();
            this.Panel_showinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_enter_date
            // 
            this.Panel_enter_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel_enter_date.Controls.Add(this.Btn_add_student);
            this.Panel_enter_date.Controls.Add(this.Tb_hobby);
            this.Panel_enter_date.Controls.Add(this.Lbl_gender);
            this.Panel_enter_date.Controls.Add(this.ComboBox);
            this.Panel_enter_date.Controls.Add(this.Lbl_birthday);
            this.Panel_enter_date.Controls.Add(this.DateTimePicker_birthday);
            this.Panel_enter_date.Controls.Add(this.Tb_surname);
            this.Panel_enter_date.Controls.Add(this.Tb_name);
            this.Panel_enter_date.Location = new System.Drawing.Point(12, 12);
            this.Panel_enter_date.Name = "Panel_enter_date";
            this.Panel_enter_date.Size = new System.Drawing.Size(241, 326);
            this.Panel_enter_date.TabIndex = 0;
            // 
            // Btn_add_student
            // 
            this.Btn_add_student.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_add_student.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_add_student.Location = new System.Drawing.Point(35, 235);
            this.Btn_add_student.Name = "Btn_add_student";
            this.Btn_add_student.Size = new System.Drawing.Size(100, 40);
            this.Btn_add_student.TabIndex = 7;
            this.Btn_add_student.Text = "Add Student";
            this.Btn_add_student.UseMnemonic = false;
            this.Btn_add_student.UseVisualStyleBackColor = false;
            this.Btn_add_student.Click += new System.EventHandler(this.Btn_add_student_Click);
            // 
            // Tb_hobby
            // 
            this.Tb_hobby.Location = new System.Drawing.Point(15, 168);
            this.Tb_hobby.Name = "Tb_hobby";
            this.Tb_hobby.Size = new System.Drawing.Size(151, 20);
            this.Tb_hobby.TabIndex = 6;
            this.Tb_hobby.Text = "Enter hobby";
            this.Tb_hobby.Click += new System.EventHandler(this.Tb_hobby_Click);
            // 
            // Lbl_gender
            // 
            this.Lbl_gender.AutoSize = true;
            this.Lbl_gender.Location = new System.Drawing.Point(12, 116);
            this.Lbl_gender.Name = "Lbl_gender";
            this.Lbl_gender.Size = new System.Drawing.Size(114, 13);
            this.Lbl_gender.TabIndex = 5;
            this.Lbl_gender.Text = "Choose of your gander";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.ComboBox.Location = new System.Drawing.Point(15, 132);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 4;
            // 
            // Lbl_birthday
            // 
            this.Lbl_birthday.AutoSize = true;
            this.Lbl_birthday.Location = new System.Drawing.Point(12, 77);
            this.Lbl_birthday.Name = "Lbl_birthday";
            this.Lbl_birthday.Size = new System.Drawing.Size(125, 13);
            this.Lbl_birthday.TabIndex = 3;
            this.Lbl_birthday.Text = "Choose your date of birth";
            // 
            // DateTimePicker_birthday
            // 
            this.DateTimePicker_birthday.Location = new System.Drawing.Point(15, 93);
            this.DateTimePicker_birthday.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_birthday.Name = "DateTimePicker_birthday";
            this.DateTimePicker_birthday.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker_birthday.TabIndex = 2;
            this.DateTimePicker_birthday.Value = new System.DateTime(2020, 4, 9, 0, 0, 0, 0);
            this.DateTimePicker_birthday.ValueChanged += new System.EventHandler(this.DateTimePicker_birthday_ValueChanged);
            // 
            // Tb_surname
            // 
            this.Tb_surname.Location = new System.Drawing.Point(15, 44);
            this.Tb_surname.Name = "Tb_surname";
            this.Tb_surname.Size = new System.Drawing.Size(177, 20);
            this.Tb_surname.TabIndex = 1;
            this.Tb_surname.Text = "Enter surname";
            this.Tb_surname.Click += new System.EventHandler(this.Tb_surname_Click);
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(15, 18);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(177, 20);
            this.Tb_name.TabIndex = 0;
            this.Tb_name.Text = "Enter name";
            this.Tb_name.Click += new System.EventHandler(this.Tb_name_Click);
            // 
            // Panel_showinfo
            // 
            this.Panel_showinfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Panel_showinfo.Controls.Add(this.Btn_load_One);
            this.Panel_showinfo.Controls.Add(this.Btn_clear);
            this.Panel_showinfo.Controls.Add(this.Btn_save_jason);
            this.Panel_showinfo.Controls.Add(this.Btn_save_by_surname);
            this.Panel_showinfo.Controls.Add(this.Btn_SaveAll);
            this.Panel_showinfo.Controls.Add(this.Btn_load);
            this.Panel_showinfo.Controls.Add(this.ListBox_add_student);
            this.Panel_showinfo.Location = new System.Drawing.Point(298, 15);
            this.Panel_showinfo.Name = "Panel_showinfo";
            this.Panel_showinfo.Size = new System.Drawing.Size(427, 322);
            this.Panel_showinfo.TabIndex = 1;
            // 
            // Btn_load_One
            // 
            this.Btn_load_One.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_load_One.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_load_One.Location = new System.Drawing.Point(217, 263);
            this.Btn_load_One.Name = "Btn_load_One";
            this.Btn_load_One.Size = new System.Drawing.Size(187, 33);
            this.Btn_load_One.TabIndex = 4;
            this.Btn_load_One.Text = "Load Students date by surname";
            this.Btn_load_One.UseVisualStyleBackColor = false;
            this.Btn_load_One.Click += new System.EventHandler(this.Btn_load__Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_clear.Location = new System.Drawing.Point(310, 165);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(94, 35);
            this.Btn_clear.TabIndex = 3;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_save_jason
            // 
            this.Btn_save_jason.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Btn_save_jason.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_save_jason.Location = new System.Drawing.Point(3, 263);
            this.Btn_save_jason.Name = "Btn_save_jason";
            this.Btn_save_jason.Size = new System.Drawing.Size(196, 37);
            this.Btn_save_jason.TabIndex = 2;
            this.Btn_save_jason.Text = "Save Student by surname Json";
            this.Btn_save_jason.UseVisualStyleBackColor = false;
            this.Btn_save_jason.Click += new System.EventHandler(this.Btn_save_jason_Click);
            // 
            // Btn_save_by_surname
            // 
            this.Btn_save_by_surname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Btn_save_by_surname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_save_by_surname.Location = new System.Drawing.Point(3, 220);
            this.Btn_save_by_surname.Name = "Btn_save_by_surname";
            this.Btn_save_by_surname.Size = new System.Drawing.Size(196, 37);
            this.Btn_save_by_surname.TabIndex = 2;
            this.Btn_save_by_surname.Text = "Save Student by surname XML";
            this.Btn_save_by_surname.UseVisualStyleBackColor = false;
            this.Btn_save_by_surname.Click += new System.EventHandler(this.Btn_save_by_surname_Click);
            // 
            // Btn_SaveAll
            // 
            this.Btn_SaveAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_SaveAll.Location = new System.Drawing.Point(3, 178);
            this.Btn_SaveAll.Name = "Btn_SaveAll";
            this.Btn_SaveAll.Size = new System.Drawing.Size(196, 36);
            this.Btn_SaveAll.TabIndex = 1;
            this.Btn_SaveAll.Text = "Save all students";
            this.Btn_SaveAll.UseVisualStyleBackColor = false;
            this.Btn_SaveAll.Click += new System.EventHandler(this.Btn_SaveAll_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_load.Location = new System.Drawing.Point(217, 220);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(187, 37);
            this.Btn_load.TabIndex = 1;
            this.Btn_load.Text = "Load All Student from file";
            this.Btn_load.UseVisualStyleBackColor = false;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // ListBox_add_student
            // 
            this.ListBox_add_student.FormattingEnabled = true;
            this.ListBox_add_student.Location = new System.Drawing.Point(17, 15);
            this.ListBox_add_student.Name = "ListBox_add_student";
            this.ListBox_add_student.Size = new System.Drawing.Size(387, 134);
            this.ListBox_add_student.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(755, 361);
            this.Controls.Add(this.Panel_showinfo);
            this.Controls.Add(this.Panel_enter_date);
            this.Name = "Form";
            this.Text = "Questionnaire";
            this.Panel_enter_date.ResumeLayout(false);
            this.Panel_enter_date.PerformLayout();
            this.Panel_showinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_enter_date;
        private System.Windows.Forms.Label Lbl_gender;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label Lbl_birthday;
        private System.Windows.Forms.DateTimePicker DateTimePicker_birthday;
        private System.Windows.Forms.TextBox Tb_surname;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Panel Panel_showinfo;
        private System.Windows.Forms.TextBox Tb_hobby;
        private System.Windows.Forms.ListBox ListBox_add_student;
        private System.Windows.Forms.Button Btn_add_student;
        private System.Windows.Forms.Button Btn_SaveAll;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_save_by_surname;
        private System.Windows.Forms.Button Btn_save_jason;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_load_One;
    }
}

