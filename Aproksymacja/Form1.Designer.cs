namespace Aproksymacja
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
            this.points_rtxb = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.res_lbl = new System.Windows.Forms.Label();
            this.calc_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "points x and y";
            // 
            // points_rtxb
            // 
            this.points_rtxb.Location = new System.Drawing.Point(15, 29);
            this.points_rtxb.Name = "points_rtxb";
            this.points_rtxb.Size = new System.Drawing.Size(94, 160);
            this.points_rtxb.TabIndex = 1;
            this.points_rtxb.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res_lbl);
            this.groupBox1.Location = new System.Drawing.Point(115, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "result: W(x) = ";
            // 
            // res_lbl
            // 
            this.res_lbl.AutoSize = true;
            this.res_lbl.Location = new System.Drawing.Point(6, 60);
            this.res_lbl.Name = "res_lbl";
            this.res_lbl.Size = new System.Drawing.Size(0, 17);
            this.res_lbl.TabIndex = 3;
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(115, 160);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(84, 29);
            this.calc_btn.TabIndex = 4;
            this.calc_btn.Text = "calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(380, 167);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(52, 23);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 202);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.points_rtxb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Aproksymacja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox points_rtxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label res_lbl;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

