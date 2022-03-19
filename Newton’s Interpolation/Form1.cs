using System;using System.Windows.Forms;

namespace Newton_s_Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double[] x = { double.Parse(x_0_txb.Text), double.Parse(x_1_txb.Text),
                           double.Parse(x_2_txb.Text), double.Parse(x_3_txb.Text) };

            double[,] y = new double[10, 10];
            y[0, 0] = double.Parse(y_0_txb.Text);
            y[1, 0] = double.Parse(y_1_txb.Text);
            y[2, 0] = double.Parse(y_2_txb.Text);
            y[3, 0] = double.Parse(y_3_txb.Text);

            DividedDiffTable(x, y);

            result_txb.Text = Math.Round(Interpolate(x, y, double.Parse(x_asterisk_txb.Text)), 3).ToString();
        }

        static double Interpolate(double[] x, double[,] y, double x_asterisk)
        {
            double sum = y[0, 0];

            for (int i = 1; i < 4; i++)
            {
                sum += (ProductTerm(i, x, x_asterisk) * y[0, i]);
            }

            return sum;
        }

        static void DividedDiffTable(double[] x, double[,] y)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    y[j, i] = (y[j, i - 1] - y[j + 1, i - 1]) / (x[j] - x[i + j]);
                }
            }
        }

        static double ProductTerm(int i, double[] x, double x_asterisk)
        {
            double pro = 1;

            for (int j = 0; j < i; j++)
            {
                pro *= (x_asterisk - x[j]);
            }

            return pro;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            x_0_txb.Text = "";
            x_1_txb.Text = "";
            x_2_txb.Text = "";
            x_3_txb.Text = "";

            y_0_txb.Text = "";
            y_1_txb.Text = "";
            y_2_txb.Text = "";
            y_3_txb.Text = "";

            x_asterisk_txb.Text = "";

            result_txb.Text = "";
        }

        private void onlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
