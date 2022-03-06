using System;
using System.Windows.Forms;

namespace System_of_equations
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int N;

        double[,] A;
        double[] B;
        double[] X;

        public Form1()
        {
            InitializeComponent();
        }

        private void matrix_size_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void ChangeSize()
        {
            N = (int)matrix_size.Value;

            matrix_A.RowCount = N;
            matrix_A.ColumnCount = N;

            matrix_X.RowCount = N;
            matrix_X.ColumnCount = 1;

            matrix_B.RowCount = N;
            matrix_B.ColumnCount = 1;
        }

        private void calculate_bt_Click(object sender, EventArgs e)
        {
            Read();

            int b = Gauss_Elimination.Solve(A, B, X, 1e-20);

            for (int j = 1; j <= N; j++)
            {
                matrix_X[0, j - 1].Value = X[j].ToString("0.00");
            }
        }

        private void Read()
        {
            A = new double[N + 1, N + 1];
            B = new double[N + 1];
            X = new double[N + 1];

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    A[i, j] = double.Parse(matrix_A[j - 1, i - 1].Value.ToString());
                    B[j] = double.Parse(matrix_B[0, j - 1].Value.ToString());
                }
            }
        }

        private void fill_bt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    double x = random.Next(-50, 50) + random.NextDouble();

                    matrix_A[i, j].Value = x.ToString("0.00");
                    matrix_B[0, i].Value = x.ToString("0.00");
                }
            }
        }

        private void random_bt_Click(object sender, EventArgs e)
        {
            double sum, Ax;

            for (int i = 1; i <= N; i++)
            {
                sum = 0;

                for (int j = 1; j <= N; j++)
                {
                    Ax = random.Next(1, 10);

                    if (i != j)
                    {
                        matrix_A[j - 1, i - 1].Value = Ax.ToString();

                        sum += Ax;
                    }
                    else
                    {
                        matrix_A[j - 1, i - 1].Value = (10.0 * Ax).ToString();

                        sum += 10.0 * Ax;
                    }
                }

                matrix_B[0, i - 1].Value = sum.ToString();
            }
        }

        private void onlyNumbersValidation(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Validation.OnlyNumbersInCells(e);
        }
    }
}
