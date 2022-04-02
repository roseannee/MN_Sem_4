namespace Numerical_differentiation
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
            this.x4_num_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x3_num_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x2_num_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x_num_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.x_txb = new System.Windows.Forms.TextBox();
            this.h_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.res_st_err_txb = new System.Windows.Forms.TextBox();
            this.res_nd_deriv_txb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.res_st_deriv_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backward_btn = new System.Windows.Forms.Button();
            this.central_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.res_nd_err_txb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.st_deriv_txb = new System.Windows.Forms.TextBox();
            this.nd_deriv_txb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // x4_num_txb
            // 
            this.x4_num_txb.Location = new System.Drawing.Point(35, 21);
            this.x4_num_txb.Name = "x4_num_txb";
            this.x4_num_txb.Size = new System.Drawing.Size(43, 23);
            this.x4_num_txb.TabIndex = 0;
            this.x4_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x4_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x^4 +";
            // 
            // x3_num_txb
            // 
            this.x3_num_txb.Location = new System.Drawing.Point(133, 21);
            this.x3_num_txb.Name = "x3_num_txb";
            this.x3_num_txb.Size = new System.Drawing.Size(43, 23);
            this.x3_num_txb.TabIndex = 2;
            this.x3_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "x^3 +";
            // 
            // x2_num_txb
            // 
            this.x2_num_txb.Location = new System.Drawing.Point(231, 21);
            this.x2_num_txb.Name = "x2_num_txb";
            this.x2_num_txb.Size = new System.Drawing.Size(43, 23);
            this.x2_num_txb.TabIndex = 4;
            this.x2_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "x^2 +";
            // 
            // x_num_txb
            // 
            this.x_num_txb.Location = new System.Drawing.Point(329, 21);
            this.x_num_txb.Name = "x_num_txb";
            this.x_num_txb.Size = new System.Drawing.Size(43, 23);
            this.x_num_txb.TabIndex = 6;
            this.x_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "x +";
            // 
            // num_txb
            // 
            this.num_txb.Location = new System.Drawing.Point(411, 21);
            this.num_txb.Name = "num_txb";
            this.num_txb.Size = new System.Drawing.Size(43, 23);
            this.num_txb.TabIndex = 8;
            this.num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "x:";
            // 
            // x_txb
            // 
            this.x_txb.Location = new System.Drawing.Point(38, 76);
            this.x_txb.Name = "x_txb";
            this.x_txb.Size = new System.Drawing.Size(43, 23);
            this.x_txb.TabIndex = 10;
            this.x_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // h_txb
            // 
            this.h_txb.Location = new System.Drawing.Point(38, 106);
            this.h_txb.Name = "h_txb";
            this.h_txb.Size = new System.Drawing.Size(43, 23);
            this.h_txb.TabIndex = 12;
            this.h_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.h_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersValidation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "h:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res_nd_err_txb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.res_st_err_txb);
            this.groupBox1.Controls.Add(this.res_nd_deriv_txb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.res_st_deriv_txb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(133, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 121);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "result";
            // 
            // res_st_err_txb
            // 
            this.res_st_err_txb.Location = new System.Drawing.Point(62, 88);
            this.res_st_err_txb.Name = "res_st_err_txb";
            this.res_st_err_txb.Size = new System.Drawing.Size(50, 23);
            this.res_st_err_txb.TabIndex = 16;
            this.res_st_err_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // res_nd_deriv_txb
            // 
            this.res_nd_deriv_txb.Location = new System.Drawing.Point(99, 51);
            this.res_nd_deriv_txb.Name = "res_nd_deriv_txb";
            this.res_nd_deriv_txb.Size = new System.Drawing.Size(143, 23);
            this.res_nd_deriv_txb.TabIndex = 15;
            this.res_nd_deriv_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "II derivative:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "I error:";
            // 
            // res_st_deriv_txb
            // 
            this.res_st_deriv_txb.Location = new System.Drawing.Point(99, 22);
            this.res_st_deriv_txb.Name = "res_st_deriv_txb";
            this.res_st_deriv_txb.Size = new System.Drawing.Size(143, 23);
            this.res_st_deriv_txb.TabIndex = 14;
            this.res_st_deriv_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "I derivative:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backward_btn);
            this.groupBox2.Controls.Add(this.central_btn);
            this.groupBox2.Controls.Add(this.forward_btn);
            this.groupBox2.Location = new System.Drawing.Point(393, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 121);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "options";
            // 
            // backward_btn
            // 
            this.backward_btn.Location = new System.Drawing.Point(6, 22);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.Size = new System.Drawing.Size(90, 26);
            this.backward_btn.TabIndex = 16;
            this.backward_btn.Text = "backward";
            this.backward_btn.UseVisualStyleBackColor = true;
            this.backward_btn.Click += new System.EventHandler(this.backward_btn_Click);
            // 
            // central_btn
            // 
            this.central_btn.Location = new System.Drawing.Point(6, 54);
            this.central_btn.Name = "central_btn";
            this.central_btn.Size = new System.Drawing.Size(90, 26);
            this.central_btn.TabIndex = 17;
            this.central_btn.Text = "central";
            this.central_btn.UseVisualStyleBackColor = true;
            this.central_btn.Click += new System.EventHandler(this.central_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.Location = new System.Drawing.Point(6, 86);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(90, 26);
            this.forward_btn.TabIndex = 18;
            this.forward_btn.Text = "forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(26, 143);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(65, 26);
            this.clear_btn.TabIndex = 19;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // res_nd_err_txb
            // 
            this.res_nd_err_txb.Location = new System.Drawing.Point(192, 88);
            this.res_nd_err_txb.Name = "res_nd_err_txb";
            this.res_nd_err_txb.Size = new System.Drawing.Size(50, 23);
            this.res_nd_err_txb.TabIndex = 19;
            this.res_nd_err_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "II error:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "II deriv:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "I deriv:";
            // 
            // st_deriv_txb
            // 
            this.st_deriv_txb.Location = new System.Drawing.Point(72, 199);
            this.st_deriv_txb.Name = "st_deriv_txb";
            this.st_deriv_txb.Size = new System.Drawing.Size(43, 23);
            this.st_deriv_txb.TabIndex = 23;
            this.st_deriv_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nd_deriv_txb
            // 
            this.nd_deriv_txb.Location = new System.Drawing.Point(72, 231);
            this.nd_deriv_txb.Name = "nd_deriv_txb";
            this.nd_deriv_txb.Size = new System.Drawing.Size(43, 23);
            this.nd_deriv_txb.TabIndex = 24;
            this.nd_deriv_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 266);
            this.Controls.Add(this.nd_deriv_txb);
            this.Controls.Add(this.st_deriv_txb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.h_txb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.x_txb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_num_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2_num_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x3_num_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x4_num_txb);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Numerical differentiation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x4_num_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x3_num_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x2_num_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_num_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x_txb;
        private System.Windows.Forms.TextBox h_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox res_nd_deriv_txb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox res_st_deriv_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox res_st_err_txb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Button central_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox res_nd_err_txb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox st_deriv_txb;
        private System.Windows.Forms.TextBox nd_deriv_txb;
    }
}

