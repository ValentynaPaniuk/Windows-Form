namespace Classwork20200408_Event_Planning
{
    partial class form_planning
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
            this.tb_event = new System.Windows.Forms.TextBox();
            this.tb_plaсe = new System.Windows.Forms.TextBox();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_cleare = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_event
            // 
            this.tb_event.Location = new System.Drawing.Point(20, 42);
            this.tb_event.Margin = new System.Windows.Forms.Padding(4);
            this.tb_event.Name = "tb_event";
            this.tb_event.Size = new System.Drawing.Size(293, 22);
            this.tb_event.TabIndex = 0;
            this.tb_event.Text = "Enter event";
            this.tb_event.Click += new System.EventHandler(this.tb_event_Click);
            // 
            // tb_plaсe
            // 
            this.tb_plaсe.Location = new System.Drawing.Point(20, 74);
            this.tb_plaсe.Margin = new System.Windows.Forms.Padding(4);
            this.tb_plaсe.Name = "tb_plaсe";
            this.tb_plaсe.Size = new System.Drawing.Size(293, 22);
            this.tb_plaсe.TabIndex = 1;
            this.tb_plaсe.Text = "Enter place of Event";
            this.tb_plaсe.Click += new System.EventHandler(this.tb_plaсe_Click);
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addEvent.Location = new System.Drawing.Point(20, 235);
            this.btn_addEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(139, 36);
            this.btn_addEvent.TabIndex = 4;
            this.btn_addEvent.Text = "Add Event";
            this.btn_addEvent.UseVisualStyleBackColor = false;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(20, 138);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 9, 11, 52, 35, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btn_cleare
            // 
            this.btn_cleare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cleare.Location = new System.Drawing.Point(211, 235);
            this.btn_cleare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cleare.Name = "btn_cleare";
            this.btn_cleare.Size = new System.Drawing.Size(139, 36);
            this.btn_cleare.TabIndex = 5;
            this.btn_cleare.Text = "Cleare";
            this.btn_cleare.UseVisualStyleBackColor = false;
            this.btn_cleare.Click += new System.EventHandler(this.btn_cleare_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel.Controls.Add(this.comboBox1);
            this.panel.Controls.Add(this.btnLoad);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.bt_save);
            this.panel.Controls.Add(this.listBox);
            this.panel.Controls.Add(this.tb_event);
            this.panel.Controls.Add(this.btn_cleare);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.btn_addEvent);
            this.panel.Controls.Add(this.tb_plaсe);
            this.panel.Location = new System.Drawing.Point(16, 15);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(825, 292);
            this.panel.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Middle",
            "High",
            "Low"});
            this.comboBox1.Location = new System.Drawing.Point(20, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.Location = new System.Drawing.Point(423, 243);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(169, 28);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_save.Location = new System.Drawing.Point(631, 242);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(169, 28);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_ClickByDate);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(347, 26);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(473, 164);
            this.listBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(631, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save to json";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(880, 359);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_planning";
            this.Text = "Planning Event";
            this.Load += new System.EventHandler(this.form_planning_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
     

        private System.Windows.Forms.TextBox tb_event;
        private System.Windows.Forms.TextBox tb_plaсe;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_cleare;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

