namespace System_of_equations
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate_bt = new System.Windows.Forms.Button();
            this.random_bt = new System.Windows.Forms.Button();
            this.fill_bt = new System.Windows.Forms.Button();
            this.matrix_size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.matrix_B = new System.Windows.Forms.DataGridView();
            this.matrix_X = new System.Windows.Forms.DataGridView();
            this.matrix_A = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_A)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "x";
            // 
            // calculate_bt
            // 
            this.calculate_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_bt.Location = new System.Drawing.Point(190, 13);
            this.calculate_bt.Margin = new System.Windows.Forms.Padding(4);
            this.calculate_bt.Name = "calculate_bt";
            this.calculate_bt.Size = new System.Drawing.Size(100, 30);
            this.calculate_bt.TabIndex = 17;
            this.calculate_bt.Text = "Calculate";
            this.calculate_bt.UseVisualStyleBackColor = true;
            this.calculate_bt.Click += new System.EventHandler(this.calculate_bt_Click);
            // 
            // random_bt
            // 
            this.random_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random_bt.Location = new System.Drawing.Point(127, 250);
            this.random_bt.Margin = new System.Windows.Forms.Padding(4);
            this.random_bt.Name = "random_bt";
            this.random_bt.Size = new System.Drawing.Size(100, 30);
            this.random_bt.TabIndex = 16;
            this.random_bt.Text = "Random";
            this.random_bt.UseVisualStyleBackColor = true;
            this.random_bt.Click += new System.EventHandler(this.random_bt_Click);
            // 
            // fill_bt
            // 
            this.fill_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill_bt.Location = new System.Drawing.Point(19, 250);
            this.fill_bt.Margin = new System.Windows.Forms.Padding(4);
            this.fill_bt.Name = "fill_bt";
            this.fill_bt.Size = new System.Drawing.Size(100, 30);
            this.fill_bt.TabIndex = 15;
            this.fill_bt.Text = "Fill";
            this.fill_bt.UseVisualStyleBackColor = true;
            this.fill_bt.Click += new System.EventHandler(this.fill_bt_Click);
            // 
            // matrix_size
            // 
            this.matrix_size.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix_size.Location = new System.Drawing.Point(100, 18);
            this.matrix_size.Margin = new System.Windows.Forms.Padding(4);
            this.matrix_size.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.matrix_size.Name = "matrix_size";
            this.matrix_size.ReadOnly = true;
            this.matrix_size.Size = new System.Drawing.Size(75, 23);
            this.matrix_size.TabIndex = 14;
            this.matrix_size.ValueChanged += new System.EventHandler(this.matrix_size_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matrix size:";
            // 
            // matrix_B
            // 
            this.matrix_B.AllowUserToAddRows = false;
            this.matrix_B.AllowUserToDeleteRows = false;
            this.matrix_B.AllowUserToResizeColumns = false;
            this.matrix_B.AllowUserToResizeRows = false;
            this.matrix_B.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrix_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matrix_B.ColumnHeadersHeight = 25;
            this.matrix_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix_B.Location = new System.Drawing.Point(433, 61);
            this.matrix_B.Margin = new System.Windows.Forms.Padding(4);
            this.matrix_B.Name = "matrix_B";
            this.matrix_B.RowHeadersWidth = 30;
            this.matrix_B.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix_B.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix_B.RowTemplate.Height = 25;
            this.matrix_B.Size = new System.Drawing.Size(132, 127);
            this.matrix_B.TabIndex = 12;
            this.matrix_B.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.onlyNumbersValidation);
            // 
            // matrix_X
            // 
            this.matrix_X.AllowUserToAddRows = false;
            this.matrix_X.AllowUserToDeleteRows = false;
            this.matrix_X.AllowUserToResizeColumns = false;
            this.matrix_X.AllowUserToResizeRows = false;
            this.matrix_X.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrix_X.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matrix_X.ColumnHeadersHeight = 25;
            this.matrix_X.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix_X.Location = new System.Drawing.Point(271, 61);
            this.matrix_X.Margin = new System.Windows.Forms.Padding(4);
            this.matrix_X.Name = "matrix_X";
            this.matrix_X.ReadOnly = true;
            this.matrix_X.RowHeadersWidth = 30;
            this.matrix_X.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix_X.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix_X.RowTemplate.Height = 25;
            this.matrix_X.Size = new System.Drawing.Size(132, 127);
            this.matrix_X.TabIndex = 11;
            this.matrix_X.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.onlyNumbersValidation);
            // 
            // matrix_A
            // 
            this.matrix_A.AllowUserToAddRows = false;
            this.matrix_A.AllowUserToDeleteRows = false;
            this.matrix_A.AllowUserToResizeColumns = false;
            this.matrix_A.AllowUserToResizeRows = false;
            this.matrix_A.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrix_A.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrix_A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matrix_A.ColumnHeadersHeight = 25;
            this.matrix_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix_A.Location = new System.Drawing.Point(19, 61);
            this.matrix_A.Margin = new System.Windows.Forms.Padding(4);
            this.matrix_A.Name = "matrix_A";
            this.matrix_A.RowHeadersWidth = 30;
            this.matrix_A.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix_A.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix_A.RowTemplate.Height = 25;
            this.matrix_A.Size = new System.Drawing.Size(224, 127);
            this.matrix_A.TabIndex = 10;
            this.matrix_A.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.onlyNumbersValidation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate_bt);
            this.Controls.Add(this.random_bt);
            this.Controls.Add(this.fill_bt);
            this.Controls.Add(this.matrix_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrix_B);
            this.Controls.Add(this.matrix_X);
            this.Controls.Add(this.matrix_A);
            this.Name = "Form1";
            this.Text = "Systems of equations";
            ((System.ComponentModel.ISupportInitialize)(this.matrix_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate_bt;
        private System.Windows.Forms.Button random_bt;
        private System.Windows.Forms.Button fill_bt;
        private System.Windows.Forms.NumericUpDown matrix_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrix_B;
        private System.Windows.Forms.DataGridView matrix_X;
        private System.Windows.Forms.DataGridView matrix_A;
    }
}

