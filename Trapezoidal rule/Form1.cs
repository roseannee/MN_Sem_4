using System;
using System.Windows.Forms;

namespace Trapezoidal_rule
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

            result_txb.Text = Trapezoidal(a, b, n).ToString();
        }

        double Trapezoidal(double a, double b, double n)
        {
            double h = (b - a) / n;

            double sum = Func(a) + Func(b);

            for (int i = 1; i < n; i++)
            {
                sum += 2 * Func(a + i * h);
            }

            return (h / 2) * sum;

            /*double step = (b - a) / n;

            double integral = 0.5 * (Func(a) + Func(b));

            for (int i = 0; i < n; i++)
            {
                integral += Func(a + step * i);
            }

            integral *= step;

            return integral;*/
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
