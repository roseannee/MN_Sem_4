namespace Simpson_s_rule
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
            this.clear_btn = new System.Windows.Forms.Button();
            this.calc_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.num_txb = new System.Windows.Forms.TextBox();
            this.n_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.result_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x_num_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x2_num_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x3_num_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_txb = new System.Windows.Forms.TextBox();
            this.a_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(383, 112);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(62, 24);
            this.clear_btn.TabIndex = 31;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(177, 97);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(94, 38);
            this.calc_btn.TabIndex = 30;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "=";
            // 
            // num_txb
            // 
            this.num_txb.Location = new System.Drawing.Point(305, 45);
            this.num_txb.Name = "num_txb";
            this.num_txb.Size = new System.Drawing.Size(37, 23);
            this.num_txb.TabIndex = 28;
            this.num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // n_txb
            // 
            this.n_txb.Location = new System.Drawing.Point(43, 116);
            this.n_txb.Name = "n_txb";
            this.n_txb.Size = new System.Drawing.Size(37, 23);
            this.n_txb.TabIndex = 27;
            this.n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "n  =";
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(370, 45);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(77, 23);
            this.result_txb.TabIndex = 25;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "x  -";
            // 
            // x_num_txb
            // 
            this.x_num_txb.Location = new System.Drawing.Point(234, 45);
            this.x_num_txb.Name = "x_num_txb";
            this.x_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x_num_txb.TabIndex = 23;
            this.x_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "x^2  +";
            // 
            // x2_num_txb
            // 
            this.x2_num_txb.Location = new System.Drawing.Point(142, 45);
            this.x2_num_txb.Name = "x2_num_txb";
            this.x2_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x2_num_txb.TabIndex = 21;
            this.x2_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "x^3  -";
            // 
            // x3_num_txb
            // 
            this.x3_num_txb.Location = new System.Drawing.Point(55, 45);
            this.x3_num_txb.Name = "x3_num_txb";
            this.x3_num_txb.Size = new System.Drawing.Size(37, 23);
            this.x3_num_txb.TabIndex = 19;
            this.x3_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "∫";
            // 
            // b_txb
            // 
            this.b_txb.Location = new System.Drawing.Point(12, 10);
            this.b_txb.Name = "b_txb";
            this.b_txb.Size = new System.Drawing.Size(37, 23);
            this.b_txb.TabIndex = 17;
            this.b_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // a_txb
            // 
            this.a_txb.Location = new System.Drawing.Point(12, 72);
            this.a_txb.Name = "a_txb";
            this.a_txb.Size = new System.Drawing.Size(37, 23);
            this.a_txb.TabIndex = 16;
            this.a_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
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
            this.Text = "Simpson’s rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num_txb;
        private System.Windows.Forms.TextBox n_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x_num_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x2_num_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x3_num_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox b_txb;
        private System.Windows.Forms.TextBox a_txb;
    }
}

