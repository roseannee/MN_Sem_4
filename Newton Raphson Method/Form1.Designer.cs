namespace Newton_Raphson_Method
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
            this.clear_bt = new System.Windows.Forms.Button();
            this.calculate_bt = new System.Windows.Forms.Button();
            this.epsilon_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answer_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.x_0_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x_num_tb = new System.Windows.Forms.TextBox();
            this.x2_num_tb = new System.Windows.Forms.TextBox();
            this.x3_num_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear_bt
            // 
            this.clear_bt.Location = new System.Drawing.Point(345, 185);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Size = new System.Drawing.Size(57, 23);
            this.clear_bt.TabIndex = 39;
            this.clear_bt.Text = "Clear";
            this.clear_bt.UseVisualStyleBackColor = true;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // calculate_bt
            // 
            this.calculate_bt.Location = new System.Drawing.Point(151, 136);
            this.calculate_bt.Name = "calculate_bt";
            this.calculate_bt.Size = new System.Drawing.Size(166, 33);
            this.calculate_bt.TabIndex = 38;
            this.calculate_bt.Text = "Calculate";
            this.calculate_bt.UseVisualStyleBackColor = true;
            this.calculate_bt.Click += new System.EventHandler(this.calculate_bt_Click);
            // 
            // epsilon_tb
            // 
            this.epsilon_tb.Location = new System.Drawing.Point(53, 127);
            this.epsilon_tb.Margin = new System.Windows.Forms.Padding(4);
            this.epsilon_tb.Name = "epsilon_tb";
            this.epsilon_tb.Size = new System.Drawing.Size(62, 23);
            this.epsilon_tb.TabIndex = 37;
            this.epsilon_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.epsilon_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "ε:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answer_tb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(151, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 54);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "answer";
            // 
            // answer_tb
            // 
            this.answer_tb.Location = new System.Drawing.Point(31, 23);
            this.answer_tb.Margin = new System.Windows.Forms.Padding(4);
            this.answer_tb.Name = "answer_tb";
            this.answer_tb.Size = new System.Drawing.Size(124, 23);
            this.answer_tb.TabIndex = 16;
            this.answer_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "x:";
            // 
            // x_0_tb
            // 
            this.x_0_tb.Location = new System.Drawing.Point(53, 96);
            this.x_0_tb.Margin = new System.Windows.Forms.Padding(4);
            this.x_0_tb.Name = "x_0_tb";
            this.x_0_tb.Size = new System.Drawing.Size(28, 23);
            this.x_0_tb.TabIndex = 34;
            this.x_0_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_0_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "x_0:";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(309, 18);
            this.num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(28, 23);
            this.num_tb.TabIndex = 30;
            this.num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "+";
            // 
            // x_num_tb
            // 
            this.x_num_tb.Location = new System.Drawing.Point(226, 18);
            this.x_num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.x_num_tb.Name = "x_num_tb";
            this.x_num_tb.Size = new System.Drawing.Size(28, 23);
            this.x_num_tb.TabIndex = 28;
            this.x_num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x2_num_tb
            // 
            this.x2_num_tb.Location = new System.Drawing.Point(127, 18);
            this.x2_num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.x2_num_tb.Name = "x2_num_tb";
            this.x2_num_tb.Size = new System.Drawing.Size(28, 23);
            this.x2_num_tb.TabIndex = 27;
            this.x2_num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x3_num_tb
            // 
            this.x3_num_tb.Location = new System.Drawing.Point(28, 18);
            this.x3_num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.x3_num_tb.Name = "x3_num_tb";
            this.x3_num_tb.Size = new System.Drawing.Size(28, 23);
            this.x3_num_tb.TabIndex = 26;
            this.x3_num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "=   0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "x^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "x^3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 220);
            this.Controls.Add(this.clear_bt);
            this.Controls.Add(this.calculate_bt);
            this.Controls.Add(this.epsilon_tb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.x_0_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.x_num_tb);
            this.Controls.Add(this.x2_num_tb);
            this.Controls.Add(this.x3_num_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Newton Raphson Method";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clear_bt;
        private System.Windows.Forms.Button calculate_bt;
        private System.Windows.Forms.TextBox epsilon_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox answer_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox x_0_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x_num_tb;
        private System.Windows.Forms.TextBox x2_num_tb;
        private System.Windows.Forms.TextBox x3_num_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

