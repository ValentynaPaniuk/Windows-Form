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
            this.Tb_event = new System.Windows.Forms.TextBox();
            this.Tb_plaсe = new System.Windows.Forms.TextBox();
            this.Tb_priority = new System.Windows.Forms.TextBox();
            this.Btn_addEvent = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Btn_cleare = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Bt_save = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_event
            // 
            this.Tb_event.Location = new System.Drawing.Point(15, 34);
            this.Tb_event.Name = "Tb_event";
            this.Tb_event.Size = new System.Drawing.Size(221, 20);
            this.Tb_event.TabIndex = 0;
            this.Tb_event.Text = "Enter event";
            this.Tb_event.Click += new System.EventHandler(this.tb_event_Click);
            // 
            // Tb_plaсe
            // 
            this.Tb_plaсe.Location = new System.Drawing.Point(15, 60);
            this.Tb_plaсe.Name = "Tb_plaсe";
            this.Tb_plaсe.Size = new System.Drawing.Size(221, 20);
            this.Tb_plaсe.TabIndex = 1;
            this.Tb_plaсe.Text = "Enter place of Event";
            this.Tb_plaсe.Click += new System.EventHandler(this.tb_plaсe_Click);
            // 
            // Tb_priority
            // 
            this.Tb_priority.Location = new System.Drawing.Point(15, 86);
            this.Tb_priority.Name = "Tb_priority";
            this.Tb_priority.Size = new System.Drawing.Size(221, 20);
            this.Tb_priority.TabIndex = 2;
            this.Tb_priority.Text = "Chose priority of Event";
            this.Tb_priority.Click += new System.EventHandler(this.tb_priority_Click);
            this.Tb_priority.MultilineChanged += new System.EventHandler(this.tb_priority_Click);
            // 
            // Btn_addEvent
            // 
            this.Btn_addEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_addEvent.Location = new System.Drawing.Point(15, 191);
            this.Btn_addEvent.Name = "Btn_addEvent";
            this.Btn_addEvent.Size = new System.Drawing.Size(104, 29);
            this.Btn_addEvent.TabIndex = 4;
            this.Btn_addEvent.Text = "Add Event";
            this.Btn_addEvent.UseVisualStyleBackColor = false;
            this.Btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(15, 112);
            this.DateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.Value = new System.DateTime(2020, 4, 9, 11, 52, 35, 0);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Btn_cleare
            // 
            this.Btn_cleare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_cleare.Location = new System.Drawing.Point(158, 191);
            this.Btn_cleare.Name = "Btn_cleare";
            this.Btn_cleare.Size = new System.Drawing.Size(104, 29);
            this.Btn_cleare.TabIndex = 5;
            this.Btn_cleare.Text = "Cleare";
            this.Btn_cleare.UseVisualStyleBackColor = false;
            this.Btn_cleare.Click += new System.EventHandler(this.btn_cleare_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel.Controls.Add(this.Bt_save);
            this.panel.Controls.Add(this.ListBox);
            this.panel.Controls.Add(this.Tb_event);
            this.panel.Controls.Add(this.Btn_cleare);
            this.panel.Controls.Add(this.DateTimePicker);
            this.panel.Controls.Add(this.Btn_addEvent);
            this.panel.Controls.Add(this.Tb_plaсe);
            this.panel.Controls.Add(this.Tb_priority);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(619, 237);
            this.panel.TabIndex = 4;
            // 
            // Bt_save
            // 
            this.Bt_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Bt_save.Location = new System.Drawing.Point(473, 197);
            this.Bt_save.Name = "Bt_save";
            this.Bt_save.Size = new System.Drawing.Size(127, 23);
            this.Bt_save.TabIndex = 6;
            this.Bt_save.Text = "Save";
            this.Bt_save.UseVisualStyleBackColor = false;
            this.Bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(260, 21);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(356, 134);
            this.ListBox.TabIndex = 0;
            // 
            // form_planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(660, 292);
            this.Controls.Add(this.panel);
            this.Name = "form_planning";
            this.Text = "Planning Event";
            this.Load += new System.EventHandler(this.form_planning_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
     

        private System.Windows.Forms.TextBox Tb_event;
        private System.Windows.Forms.TextBox Tb_plaсe;
        private System.Windows.Forms.TextBox Tb_priority;
        private System.Windows.Forms.Button Btn_addEvent;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button Btn_cleare;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button Bt_save;
    }
}

