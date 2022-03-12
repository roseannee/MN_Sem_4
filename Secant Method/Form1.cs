using System;
using System.Windows.Forms;

namespace Secant_Method
{
    public partial class Form1 : Form
    {
        double x3_num, sinx_num, num;
        double a, b;
        double x, x_0, x_n;
        double epsilon;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_bt_Click(object sender, EventArgs e)
        {
            GetNums();

            answer_tb.Text = Secant(a, b).ToString();
        }

        double Func(double x)
        {
            return x3_num * x * x * x + sinx_num * Math.Sin(x) + num;
        }

        double DerivFunc(double x)
        {
            return x3_num * 3 * x * x + sinx_num * Math.Cos(x);
        }

        double Secant(double x1, double x2)
        {
            double c;

            do
            {
                x_0 = (x1 * Func(x2) - x2 * Func(x1)) / (Func(x2) - Func(x1));

                c = Func(x1) * Func(x_0);

                x1 = x2;
                x2 = x_0;

                if (c == 0)
                {
                    break;
                }

                x_n = (x1 * Func(x2) - x2 * Func(x1)) / (Func(x2) - Func(x1));
            } while (Math.Abs(x_n - x_0) >= epsilon);

            return x_0;
        }

        /*double Secant_extra(double x1, double x2)
        {
            if (x_0 == a)
            {
                x = a;

                while (Math.Abs(Func(x)) > epsilon)
                {
                    x = b - ((Func(b) * (b - a)) / (Func(b) - Func(a)));
                    a = b;
                    b = x;
                }
            }
            else
            {
                x = b;

                while (Math.Abs(Func(x)) > epsilon)
                {

                }
            }
        }*/

        /*double Case()
        {
            if (Func(a) < 0 && Func(b) > 0 & DerivFunc(b) > 0)
            {
                return a;
            }
            else if (Func(a) > 0 && Func(b) < 0 & DerivFunc(a) > 0)
            {
                return b;
            }
            else if (Func(a) > 0 && Func(b) < 0 & DerivFunc(b) < 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }*/

        private void clear_bt_Click(object sender, EventArgs e)
        {
            x3_num_tb.Text = "";
            sinx_num_tb.Text = "";
            num_tb.Text = "";

            a_tb.Text = "";
            b_tb.Text = "";

            epsilon_tb.Text = "";

            answer_tb.Text = "";
        }

        public void GetNums()
        {
            x3_num = double.Parse(x3_num_tb.Text);
            sinx_num = double.Parse(sinx_num_tb.Text);
            num = double.Parse(num_tb.Text);

            a = double.Parse(a_tb.Text);
            b = double.Parse(b_tb.Text);

            epsilon = double.Parse(epsilon_tb.Text);
        }

        private void onlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
