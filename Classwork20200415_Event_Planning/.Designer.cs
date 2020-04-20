namespace Classwork20200415_Event_Planning
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Lb_Priority = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Lbl_event = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Bt_Cleare = new System.Windows.Forms.Button();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Search = new System.Windows.Forms.Button();
            this.ClbExample = new System.Windows.Forms.CheckedListBox();
            this.Bt_Save = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Lb_Priority
            // 
            this.Lb_Priority.AutoSize = true;
            this.Lb_Priority.Location = new System.Drawing.Point(3, 12);
            this.Lb_Priority.Name = "Lb_Priority";
            this.Lb_Priority.Size = new System.Drawing.Size(41, 13);
            this.Lb_Priority.TabIndex = 2;
            this.Lb_Priority.Text = "Priority:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Low";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.Lb_Priority);
            this.panel1.Location = new System.Drawing.Point(38, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 53);
            this.panel1.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(114, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "High";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Middle";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Lbl_event
            // 
            this.Lbl_event.AutoSize = true;
            this.Lbl_event.Location = new System.Drawing.Point(35, 22);
            this.Lbl_event.Name = "Lbl_event";
            this.Lbl_event.Size = new System.Drawing.Size(63, 13);
            this.Lbl_event.TabIndex = 6;
            this.Lbl_event.Text = "Enter Event";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 262);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 28);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Bt_Cleare
            // 
            this.Bt_Cleare.Location = new System.Drawing.Point(6, 296);
            this.Bt_Cleare.Name = "Bt_Cleare";
            this.Bt_Cleare.Size = new System.Drawing.Size(128, 31);
            this.Bt_Cleare.TabIndex = 7;
            this.Bt_Cleare.Text = "Delete selected events ";
            this.Bt_Cleare.UseVisualStyleBackColor = true;
            this.Bt_Cleare.Click += new System.EventHandler(this.Bt_Cleare_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Location = new System.Drawing.Point(140, 296);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(136, 30);
            this.Bt_Delete.TabIndex = 7;
            this.Bt_Delete.Text = "Delete all events";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Search
            // 
            this.Bt_Search.Location = new System.Drawing.Point(192, 262);
            this.Bt_Search.Name = "Bt_Search";
            this.Bt_Search.Size = new System.Drawing.Size(84, 28);
            this.Bt_Search.TabIndex = 7;
            this.Bt_Search.Text = "Search event";
            this.Bt_Search.UseVisualStyleBackColor = true;
            this.Bt_Search.Click += new System.EventHandler(this.Bt_Search_Click);
            // 
            // ClbExample
            // 
            this.ClbExample.FormattingEnabled = true;
            this.ClbExample.Location = new System.Drawing.Point(286, 27);
            this.ClbExample.Name = "ClbExample";
            this.ClbExample.Size = new System.Drawing.Size(286, 229);
            this.ClbExample.TabIndex = 8;
            // 
            // Bt_Save
            // 
            this.Bt_Save.Location = new System.Drawing.Point(104, 262);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(82, 28);
            this.Bt_Save.TabIndex = 7;
            this.Bt_Save.Text = "Save";
            this.Bt_Save.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 266);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // Lb_Info
            // 
            this.Lb_Info.AutoSize = true;
            this.Lb_Info.Location = new System.Drawing.Point(283, 296);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.Size = new System.Drawing.Size(41, 13);
            this.Lb_Info.TabIndex = 10;
            this.Lb_Info.Text = "Event: ";
            this.Lb_Info.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Lb_Info);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ClbExample);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.Bt_Search);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Cleare);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Lbl_event);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Planning Event";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Lb_Priority;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Lbl_event;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button Bt_Cleare;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Search;
        private System.Windows.Forms.CheckedListBox ClbExample;
        private System.Windows.Forms.Button Bt_Save;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lb_Info;
    }
}

