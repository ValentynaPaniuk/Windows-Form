namespace Classwork20200413_Calculator
{
    partial class Calc
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
            this.Panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.Tb_actions = new System.Windows.Forms.TextBox();
            this.Btn_addition = new System.Windows.Forms.Button();
            this.Btn_substraction = new System.Windows.Forms.Button();
            this.Btn_multiplication = new System.Windows.Forms.Button();
            this.Btn_c = new System.Windows.Forms.Button();
            this.Btn_Backspace = new System.Windows.Forms.Button();
            this.Btn_division = new System.Windows.Forms.Button();
            this.Btn_equel = new System.Windows.Forms.Button();
            this.Btn_change_sign = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_coma = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel.Controls.Add(this.label);
            this.Panel.Controls.Add(this.Tb_actions);
            this.Panel.Controls.Add(this.Btn_addition);
            this.Panel.Controls.Add(this.Btn_substraction);
            this.Panel.Controls.Add(this.Btn_multiplication);
            this.Panel.Controls.Add(this.Btn_c);
            this.Panel.Controls.Add(this.Btn_Backspace);
            this.Panel.Controls.Add(this.Btn_division);
            this.Panel.Controls.Add(this.Btn_equel);
            this.Panel.Controls.Add(this.Btn_change_sign);
            this.Panel.Controls.Add(this.Btn_0);
            this.Panel.Controls.Add(this.Btn_coma);
            this.Panel.Controls.Add(this.Btn_9);
            this.Panel.Controls.Add(this.Btn_8);
            this.Panel.Controls.Add(this.Btn_7);
            this.Panel.Controls.Add(this.Btn_6);
            this.Panel.Controls.Add(this.Btn_5);
            this.Panel.Controls.Add(this.Btn_4);
            this.Panel.Controls.Add(this.Btn_3);
            this.Panel.Controls.Add(this.Btn_2);
            this.Panel.Controls.Add(this.Btn_1);
            this.Panel.Location = new System.Drawing.Point(-1, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(294, 384);
            this.Panel.TabIndex = 0;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(19, 8);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(248, 23);
            this.label.TabIndex = 1;
            // 
            // Tb_actions
            // 
            this.Tb_actions.Location = new System.Drawing.Point(16, 34);
            this.Tb_actions.Multiline = true;
            this.Tb_actions.Name = "Tb_actions";
            this.Tb_actions.Size = new System.Drawing.Size(256, 32);
            this.Tb_actions.TabIndex = 0;
            this.Tb_actions.Text = "0";
          this.Tb_actions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_actions_KeyDown);
          this.Tb_actions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_actions_KeyPress);
            // 
            // Btn_addition
            // 
            this.Btn_addition.BackColor = System.Drawing.Color.Silver;
            this.Btn_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_addition.Location = new System.Drawing.Point(16, 72);
            this.Btn_addition.Name = "Btn_addition";
            this.Btn_addition.Size = new System.Drawing.Size(38, 34);
            this.Btn_addition.TabIndex = 0;
            this.Btn_addition.Text = "+";
            this.Btn_addition.UseVisualStyleBackColor = false;
            this.Btn_addition.Click += new System.EventHandler(this.Btn_addition_Click);
            // 
            // Btn_substraction
            // 
            this.Btn_substraction.BackColor = System.Drawing.Color.Silver;
            this.Btn_substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_substraction.Location = new System.Drawing.Point(60, 73);
            this.Btn_substraction.Name = "Btn_substraction";
            this.Btn_substraction.Size = new System.Drawing.Size(38, 34);
            this.Btn_substraction.TabIndex = 0;
            this.Btn_substraction.Text = "-";
            this.Btn_substraction.UseVisualStyleBackColor = false;
            this.Btn_substraction.Click += new System.EventHandler(this.Btn_addition_Click);
            // 
            // Btn_multiplication
            // 
            this.Btn_multiplication.BackColor = System.Drawing.Color.Silver;
            this.Btn_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_multiplication.Location = new System.Drawing.Point(104, 73);
            this.Btn_multiplication.Name = "Btn_multiplication";
            this.Btn_multiplication.Size = new System.Drawing.Size(38, 34);
            this.Btn_multiplication.TabIndex = 0;
            this.Btn_multiplication.Text = "*";
            this.Btn_multiplication.UseVisualStyleBackColor = false;
            this.Btn_multiplication.Click += new System.EventHandler(this.Btn_addition_Click);
            // 
            // Btn_c
            // 
            this.Btn_c.BackColor = System.Drawing.Color.Silver;
            this.Btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_c.Location = new System.Drawing.Point(190, 274);
            this.Btn_c.Name = "Btn_c";
            this.Btn_c.Size = new System.Drawing.Size(81, 48);
            this.Btn_c.TabIndex = 0;
            this.Btn_c.Text = "C";
            this.Btn_c.UseVisualStyleBackColor = false;
            this.Btn_c.Click += new System.EventHandler(this.Btn_c_Click);
            // 
            // Btn_Backspace
            // 
            this.Btn_Backspace.BackColor = System.Drawing.Color.Silver;
            this.Btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Backspace.Location = new System.Drawing.Point(234, 73);
            this.Btn_Backspace.Name = "Btn_Backspace";
            this.Btn_Backspace.Size = new System.Drawing.Size(38, 34);
            this.Btn_Backspace.TabIndex = 0;
            this.Btn_Backspace.Text = "CE";
            this.Btn_Backspace.UseVisualStyleBackColor = false;
            this.Btn_Backspace.Click += new System.EventHandler(this.Btn_Backspace_Click);
            // 
            // Btn_division
            // 
            this.Btn_division.BackColor = System.Drawing.Color.Silver;
            this.Btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_division.Location = new System.Drawing.Point(147, 73);
            this.Btn_division.Name = "Btn_division";
            this.Btn_division.Size = new System.Drawing.Size(38, 34);
            this.Btn_division.TabIndex = 0;
            this.Btn_division.Text = "/";
            this.Btn_division.UseVisualStyleBackColor = false;
            this.Btn_division.Click += new System.EventHandler(this.Btn_addition_Click);
            // 
            // Btn_equel
            // 
            this.Btn_equel.BackColor = System.Drawing.Color.Silver;
            this.Btn_equel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_equel.Location = new System.Drawing.Point(16, 328);
            this.Btn_equel.Name = "Btn_equel";
            this.Btn_equel.Size = new System.Drawing.Size(256, 48);
            this.Btn_equel.TabIndex = 0;
            this.Btn_equel.Text = "=";
            this.Btn_equel.UseVisualStyleBackColor = false;
            this.Btn_equel.Click += new System.EventHandler(this.Btn_equel_Click);
            this.Btn_equel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Btn_equel_KeyUp);
            // 
            // Btn_change_sign
            // 
            this.Btn_change_sign.BackColor = System.Drawing.Color.Silver;
            this.Btn_change_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_change_sign.Location = new System.Drawing.Point(190, 73);
            this.Btn_change_sign.Name = "Btn_change_sign";
            this.Btn_change_sign.Size = new System.Drawing.Size(38, 34);
            this.Btn_change_sign.TabIndex = 0;
            this.Btn_change_sign.Text = "+/-";
            this.Btn_change_sign.UseVisualStyleBackColor = false;
            this.Btn_change_sign.Click += new System.EventHandler(this.Btn_change_sign_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.BackColor = System.Drawing.Color.Silver;
            this.Btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_0.Location = new System.Drawing.Point(103, 274);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(81, 48);
            this.Btn_0.TabIndex = 0;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = false;
            this.Btn_0.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_coma
            // 
            this.Btn_coma.BackColor = System.Drawing.Color.Silver;
            this.Btn_coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_coma.Location = new System.Drawing.Point(16, 274);
            this.Btn_coma.Name = "Btn_coma";
            this.Btn_coma.Size = new System.Drawing.Size(81, 48);
            this.Btn_coma.TabIndex = 0;
            this.Btn_coma.Text = ",";
            this.Btn_coma.UseVisualStyleBackColor = false;
            this.Btn_coma.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.BackColor = System.Drawing.Color.Silver;
            this.Btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_9.Location = new System.Drawing.Point(190, 220);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(81, 48);
            this.Btn_9.TabIndex = 0;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = false;
            this.Btn_9.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.BackColor = System.Drawing.Color.Silver;
            this.Btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_8.Location = new System.Drawing.Point(103, 220);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(81, 48);
            this.Btn_8.TabIndex = 0;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = false;
            this.Btn_8.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.BackColor = System.Drawing.Color.Silver;
            this.Btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_7.Location = new System.Drawing.Point(16, 220);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(81, 48);
            this.Btn_7.TabIndex = 0;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = false;
            this.Btn_7.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.BackColor = System.Drawing.Color.Silver;
            this.Btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_6.Location = new System.Drawing.Point(190, 166);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(81, 48);
            this.Btn_6.TabIndex = 0;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = false;
            this.Btn_6.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.BackColor = System.Drawing.Color.Silver;
            this.Btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_5.Location = new System.Drawing.Point(103, 166);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(81, 48);
            this.Btn_5.TabIndex = 0;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = false;
            this.Btn_5.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.BackColor = System.Drawing.Color.Silver;
            this.Btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_4.Location = new System.Drawing.Point(16, 166);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(81, 48);
            this.Btn_4.TabIndex = 0;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = false;
            this.Btn_4.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.BackColor = System.Drawing.Color.Silver;
            this.Btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_3.Location = new System.Drawing.Point(190, 112);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(81, 48);
            this.Btn_3.TabIndex = 0;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = false;
            this.Btn_3.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.Silver;
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_2.Location = new System.Drawing.Point(103, 112);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(81, 48);
            this.Btn_2.TabIndex = 0;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.Color.Silver;
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_1.Location = new System.Drawing.Point(16, 112);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(81, 48);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = false;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 382);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Calc";
            this.Text = "Calculator";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.TextBox Tb_actions;
        private System.Windows.Forms.Button Btn_addition;
        private System.Windows.Forms.Button Btn_substraction;
        private System.Windows.Forms.Button Btn_multiplication;
        private System.Windows.Forms.Button Btn_Backspace;
        private System.Windows.Forms.Button Btn_division;
        private System.Windows.Forms.Button Btn_equel;
        private System.Windows.Forms.Button Btn_change_sign;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_coma;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_c;
        private System.Windows.Forms.Label label;
      
    }
}

