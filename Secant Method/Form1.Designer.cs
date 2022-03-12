namespace Secant_Method
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.b_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.a_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sinx_num_tb = new System.Windows.Forms.TextBox();
            this.x3_num_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear_bt
            // 
            this.clear_bt.Location = new System.Drawing.Point(345, 184);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Size = new System.Drawing.Size(57, 24);
            this.clear_bt.TabIndex = 38;
            this.clear_bt.Text = "Clear";
            this.clear_bt.UseVisualStyleBackColor = true;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // calculate_bt
            // 
            this.calculate_bt.Location = new System.Drawing.Point(151, 142);
            this.calculate_bt.Name = "calculate_bt";
            this.calculate_bt.Size = new System.Drawing.Size(166, 35);
            this.calculate_bt.TabIndex = 37;
            this.calculate_bt.Text = "Calculate";
            this.calculate_bt.UseVisualStyleBackColor = true;
            this.calculate_bt.Click += new System.EventHandler(this.calculate_bt_Click);
            // 
            // epsilon_tb
            // 
            this.epsilon_tb.Location = new System.Drawing.Point(42, 153);
            this.epsilon_tb.Margin = new System.Windows.Forms.Padding(4);
            this.epsilon_tb.Name = "epsilon_tb";
            this.epsilon_tb.Size = new System.Drawing.Size(62, 23);
            this.epsilon_tb.TabIndex = 36;
            this.epsilon_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.epsilon_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "ε:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answer_tb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(151, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 57);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "answer";
            // 
            // answer_tb
            // 
            this.answer_tb.Location = new System.Drawing.Point(31, 24);
            this.answer_tb.Margin = new System.Windows.Forms.Padding(4);
            this.answer_tb.Name = "answer_tb";
            this.answer_tb.Size = new System.Drawing.Size(124, 23);
            this.answer_tb.TabIndex = 16;
            this.answer_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "x:";
            // 
            // b_tb
            // 
            this.b_tb.Location = new System.Drawing.Point(42, 120);
            this.b_tb.Margin = new System.Windows.Forms.Padding(4);
            this.b_tb.Name = "b_tb";
            this.b_tb.Size = new System.Drawing.Size(28, 23);
            this.b_tb.TabIndex = 33;
            this.b_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "b:";
            // 
            // a_tb
            // 
            this.a_tb.Location = new System.Drawing.Point(42, 87);
            this.a_tb.Margin = new System.Windows.Forms.Padding(4);
            this.a_tb.Name = "a_tb";
            this.a_tb.Size = new System.Drawing.Size(28, 23);
            this.a_tb.TabIndex = 31;
            this.a_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "a:";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(276, 26);
            this.num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(28, 23);
            this.num_tb.TabIndex = 29;
            this.num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "+";
            // 
            // sinx_num_tb
            // 
            this.sinx_num_tb.Location = new System.Drawing.Point(161, 26);
            this.sinx_num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.sinx_num_tb.Name = "sinx_num_tb";
            this.sinx_num_tb.Size = new System.Drawing.Size(28, 23);
            this.sinx_num_tb.TabIndex = 26;
            this.sinx_num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sinx_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x3_num_tb
            // 
            this.x3_num_tb.Location = new System.Drawing.Point(62, 26);
            this.x3_num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.x3_num_tb.Name = "x3_num_tb";
            this.x3_num_tb.Size = new System.Drawing.Size(28, 23);
            this.x3_num_tb.TabIndex = 25;
            this.x3_num_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "=   0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "sin x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 19;
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
            this.Controls.Add(this.b_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.a_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sinx_num_tb);
            this.Controls.Add(this.x3_num_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Secant Method";
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
        private System.Windows.Forms.TextBox b_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox a_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sinx_num_tb;
        private System.Windows.Forms.TextBox x3_num_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

