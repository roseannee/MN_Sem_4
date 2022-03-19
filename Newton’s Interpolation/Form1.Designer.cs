namespace Newton_s_Interpolation
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
            this.result_txb = new System.Windows.Forms.TextBox();
            this.x_asterisk_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y_3_txb = new System.Windows.Forms.TextBox();
            this.x_3_txb = new System.Windows.Forms.TextBox();
            this.y_2_txb = new System.Windows.Forms.TextBox();
            this.x_2_txb = new System.Windows.Forms.TextBox();
            this.y_1_txb = new System.Windows.Forms.TextBox();
            this.x_1_txb = new System.Windows.Forms.TextBox();
            this.y_0_txb = new System.Windows.Forms.TextBox();
            this.x_0_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(18, 159);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(58, 25);
            this.clear_btn.TabIndex = 31;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(155, 107);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(104, 33);
            this.calc_btn.TabIndex = 30;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(191, 62);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(68, 23);
            this.result_txb.TabIndex = 29;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_asterisk_txb
            // 
            this.x_asterisk_txb.Location = new System.Drawing.Point(191, 30);
            this.x_asterisk_txb.Name = "x_asterisk_txb";
            this.x_asterisk_txb.Size = new System.Drawing.Size(40, 23);
            this.x_asterisk_txb.TabIndex = 28;
            this.x_asterisk_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_asterisk_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "f(x*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "x*";
            // 
            // y_3_txb
            // 
            this.y_3_txb.Location = new System.Drawing.Point(76, 117);
            this.y_3_txb.Name = "y_3_txb";
            this.y_3_txb.Size = new System.Drawing.Size(40, 23);
            this.y_3_txb.TabIndex = 25;
            this.y_3_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_3_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_3_txb
            // 
            this.x_3_txb.Location = new System.Drawing.Point(18, 117);
            this.x_3_txb.Name = "x_3_txb";
            this.x_3_txb.Size = new System.Drawing.Size(40, 23);
            this.x_3_txb.TabIndex = 24;
            this.x_3_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_3_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_2_txb
            // 
            this.y_2_txb.Location = new System.Drawing.Point(76, 88);
            this.y_2_txb.Name = "y_2_txb";
            this.y_2_txb.Size = new System.Drawing.Size(40, 23);
            this.y_2_txb.TabIndex = 23;
            this.y_2_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_2_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_2_txb
            // 
            this.x_2_txb.Location = new System.Drawing.Point(18, 88);
            this.x_2_txb.Name = "x_2_txb";
            this.x_2_txb.Size = new System.Drawing.Size(40, 23);
            this.x_2_txb.TabIndex = 22;
            this.x_2_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_2_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_1_txb
            // 
            this.y_1_txb.Location = new System.Drawing.Point(76, 59);
            this.y_1_txb.Name = "y_1_txb";
            this.y_1_txb.Size = new System.Drawing.Size(40, 23);
            this.y_1_txb.TabIndex = 21;
            this.y_1_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_1_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_1_txb
            // 
            this.x_1_txb.Location = new System.Drawing.Point(18, 59);
            this.x_1_txb.Name = "x_1_txb";
            this.x_1_txb.Size = new System.Drawing.Size(40, 23);
            this.x_1_txb.TabIndex = 20;
            this.x_1_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_1_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_0_txb
            // 
            this.y_0_txb.Location = new System.Drawing.Point(76, 30);
            this.y_0_txb.Name = "y_0_txb";
            this.y_0_txb.Size = new System.Drawing.Size(40, 23);
            this.y_0_txb.TabIndex = 19;
            this.y_0_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_0_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_0_txb
            // 
            this.x_0_txb.Location = new System.Drawing.Point(18, 30);
            this.x_0_txb.Name = "x_0_txb";
            this.x_0_txb.Size = new System.Drawing.Size(40, 23);
            this.x_0_txb.TabIndex = 18;
            this.x_0_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_0_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 195);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.result_txb);
            this.Controls.Add(this.x_asterisk_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y_3_txb);
            this.Controls.Add(this.x_3_txb);
            this.Controls.Add(this.y_2_txb);
            this.Controls.Add(this.x_2_txb);
            this.Controls.Add(this.y_1_txb);
            this.Controls.Add(this.x_1_txb);
            this.Controls.Add(this.y_0_txb);
            this.Controls.Add(this.x_0_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Newton’s Interpolation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.TextBox x_asterisk_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y_3_txb;
        private System.Windows.Forms.TextBox x_3_txb;
        private System.Windows.Forms.TextBox y_2_txb;
        private System.Windows.Forms.TextBox x_2_txb;
        private System.Windows.Forms.TextBox y_1_txb;
        private System.Windows.Forms.TextBox x_1_txb;
        private System.Windows.Forms.TextBox y_0_txb;
        private System.Windows.Forms.TextBox x_0_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

