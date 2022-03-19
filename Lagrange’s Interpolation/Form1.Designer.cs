namespace Lagrange_s_Interpolation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_0_txb = new System.Windows.Forms.TextBox();
            this.y_0_txb = new System.Windows.Forms.TextBox();
            this.x_1_txb = new System.Windows.Forms.TextBox();
            this.y_1_txb = new System.Windows.Forms.TextBox();
            this.x_2_txb = new System.Windows.Forms.TextBox();
            this.y_2_txb = new System.Windows.Forms.TextBox();
            this.x_3_txb = new System.Windows.Forms.TextBox();
            this.y_3_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x_asterisk_txb = new System.Windows.Forms.TextBox();
            this.result_txb = new System.Windows.Forms.TextBox();
            this.calc_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_0_txb
            // 
            this.x_0_txb.Location = new System.Drawing.Point(12, 29);
            this.x_0_txb.Name = "x_0_txb";
            this.x_0_txb.Size = new System.Drawing.Size(40, 23);
            this.x_0_txb.TabIndex = 2;
            this.x_0_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_0_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_0_txb
            // 
            this.y_0_txb.Location = new System.Drawing.Point(70, 29);
            this.y_0_txb.Name = "y_0_txb";
            this.y_0_txb.Size = new System.Drawing.Size(40, 23);
            this.y_0_txb.TabIndex = 3;
            this.y_0_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_0_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_1_txb
            // 
            this.x_1_txb.Location = new System.Drawing.Point(12, 58);
            this.x_1_txb.Name = "x_1_txb";
            this.x_1_txb.Size = new System.Drawing.Size(40, 23);
            this.x_1_txb.TabIndex = 4;
            this.x_1_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_1_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_1_txb
            // 
            this.y_1_txb.Location = new System.Drawing.Point(70, 58);
            this.y_1_txb.Name = "y_1_txb";
            this.y_1_txb.Size = new System.Drawing.Size(40, 23);
            this.y_1_txb.TabIndex = 5;
            this.y_1_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_1_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_2_txb
            // 
            this.x_2_txb.Location = new System.Drawing.Point(12, 87);
            this.x_2_txb.Name = "x_2_txb";
            this.x_2_txb.Size = new System.Drawing.Size(40, 23);
            this.x_2_txb.TabIndex = 6;
            this.x_2_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_2_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_2_txb
            // 
            this.y_2_txb.Location = new System.Drawing.Point(70, 87);
            this.y_2_txb.Name = "y_2_txb";
            this.y_2_txb.Size = new System.Drawing.Size(40, 23);
            this.y_2_txb.TabIndex = 7;
            this.y_2_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_2_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // x_3_txb
            // 
            this.x_3_txb.Location = new System.Drawing.Point(12, 116);
            this.x_3_txb.Name = "x_3_txb";
            this.x_3_txb.Size = new System.Drawing.Size(40, 23);
            this.x_3_txb.TabIndex = 8;
            this.x_3_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_3_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // y_3_txb
            // 
            this.y_3_txb.Location = new System.Drawing.Point(70, 116);
            this.y_3_txb.Name = "y_3_txb";
            this.y_3_txb.Size = new System.Drawing.Size(40, 23);
            this.y_3_txb.TabIndex = 9;
            this.y_3_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_3_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "x*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "f(x*)";
            // 
            // x_asterisk_txb
            // 
            this.x_asterisk_txb.Location = new System.Drawing.Point(185, 29);
            this.x_asterisk_txb.Name = "x_asterisk_txb";
            this.x_asterisk_txb.Size = new System.Drawing.Size(40, 23);
            this.x_asterisk_txb.TabIndex = 12;
            this.x_asterisk_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_asterisk_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(185, 61);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(68, 23);
            this.result_txb.TabIndex = 13;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(149, 106);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(104, 33);
            this.calc_btn.TabIndex = 14;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 158);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(58, 25);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lagrange’s Interpolation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_0_txb;
        private System.Windows.Forms.TextBox y_0_txb;
        private System.Windows.Forms.TextBox x_1_txb;
        private System.Windows.Forms.TextBox y_1_txb;
        private System.Windows.Forms.TextBox x_2_txb;
        private System.Windows.Forms.TextBox y_2_txb;
        private System.Windows.Forms.TextBox x_3_txb;
        private System.Windows.Forms.TextBox y_3_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x_asterisk_txb;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

