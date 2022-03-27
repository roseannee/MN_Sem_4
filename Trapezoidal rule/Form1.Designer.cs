namespace Trapezoidal_rule
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
            this.a_txb = new System.Windows.Forms.TextBox();
            this.b_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x3_num_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x2_num_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x_num_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.n_txb = new System.Windows.Forms.TextBox();
            this.num_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calc_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a_txb
            // 
            this.a_txb.Location = new System.Drawing.Point(12, 74);
            this.a_txb.Name = "a_txb";
            this.a_txb.Size = new System.Drawing.Size(37, 23);
            this.a_txb.TabIndex = 0;
            this.a_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // b_txb
            // 
            this.b_txb.Location = new System.Drawing.Point(12, 12);
            this.b_txb.Name = "b_txb";
            this.b_txb.Size = new System.Drawing.Size(37, 23);
            this.b_txb.TabIndex = 1;
            this.b_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "∫";
            // 
            // x3_num_txb
            // 
            this.x3_num_txb.Location = new System.Drawing.Point(55, 47);
            this.x3_num_txb.Name = "x3_num_txb";
            this.x3_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x3_num_txb.TabIndex = 3;
            this.x3_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "x^3  -";
            // 
            // x2_num_txb
            // 
            this.x2_num_txb.Location = new System.Drawing.Point(142, 47);
            this.x2_num_txb.Name = "x2_num_txb";
            this.x2_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x2_num_txb.TabIndex = 5;
            this.x2_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "x^2  +";
            // 
            // x_num_txb
            // 
            this.x_num_txb.Location = new System.Drawing.Point(234, 47);
            this.x_num_txb.Name = "x_num_txb";
            this.x_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x_num_txb.TabIndex = 7;
            this.x_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "x  -";
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(370, 47);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(77, 23);
            this.result_txb.TabIndex = 9;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "n  =";
            // 
            // n_txb
            // 
            this.n_txb.Location = new System.Drawing.Point(43, 118);
            this.n_txb.Name = "n_txb";
            this.n_txb.Size = new System.Drawing.Size(37, 23);
            this.n_txb.TabIndex = 11;
            this.n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // num_txb
            // 
            this.num_txb.Location = new System.Drawing.Point(305, 47);
            this.num_txb.Name = "num_txb";
            this.num_txb.Size = new System.Drawing.Size(37, 23);
            this.num_txb.TabIndex = 12;
            this.num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "=";
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(177, 99);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(94, 38);
            this.calc_btn.TabIndex = 14;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(383, 114);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(62, 24);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 149);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_txb);
            this.Controls.Add(this.n_txb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_num_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2_num_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x3_num_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_txb);
            this.Controls.Add(this.a_txb);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trapezoidal rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_txb;
        private System.Windows.Forms.TextBox b_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x3_num_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x2_num_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_num_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox n_txb;
        private System.Windows.Forms.TextBox num_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

