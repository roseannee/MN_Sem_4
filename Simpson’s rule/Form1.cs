using System;
using System.Windows.Forms;

namespace Simpson_s_rule
{
    public partial class Form1 : Form
    {
        double x3_num, x2_num, x_num, num;
        double a, b, n;

        public Form1()
        {
            InitializeComponent();
        }

        double Func(double x)
        {
            return x3_num * x * x * x - x2_num * x * x + x_num * x - num;
        }
        private void calc_btn_Click(object sender, EventArgs e)
        {
            GetNums();

            result_txb.Text = Simpsons(a, b, n).ToString();
        }

        double Simpsons(double a, double b, double n)
        {
            double h = (b - a) / n;

            double[] x = new double[10];
            double[] fx = new double[10];

            for (int i = 0; i <= n; i++)
            {
                x[i] = a + i * h;
                fx[i] = Func(x[i]);
            }

            double res = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    res += fx[i];
                }
                else if (i % 2 != 0)
                {
                    res += 4 * fx[i];
                }
                else
                {
                    res += 2 * fx[i];
                }
            }

            res *= (h / 3);

            return res;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            x3_num_txb.Text = "";
            x2_num_txb.Text = "";
            x_num_txb.Text = "";
            num_txb.Text = "";

            a_txb.Text = "";
            b_txb.Text = "";

            n_txb.Text = "";

            result_txb.Text = "";
        }

        public void GetNums()
        {
            x3_num = double.Parse(x3_num_txb.Text);
            x2_num = double.Parse(x2_num_txb.Text);
            x_num = double.Parse(x_num_txb.Text);
            num = double.Parse(num_txb.Text);

            a = double.Parse(a_txb.Text);
            b = double.Parse(b_txb.Text);

            n = double.Parse(n_txb.Text);
        }
        private void OnlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
