using System;
using System.Windows.Forms;

namespace Newton_Raphson_Method
{
    public partial class Form1 : Form
    {
        double x3_num, x2_num, x_num, num;
        double a, b;
        double epsilon;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_bt_Click(object sender, EventArgs e)
        {
            GetNums();

            answer_tb.Text = NewtonRaphson(Case()).ToString();
        }

        double Func(double x)
        {
            return x3_num * x * x * x + x2_num * x * x + x_num * x + num;
        }

        double DerivFunc(double x)
        {
            return x3_num * 3 * x * x + x2_num * 2 * x + x_num;
        }

        double NewtonRaphson(double x)
        {
            double h;

            do
            {
                h = x - (Func(x) / DerivFunc(x));
                x = h;
            } while (Math.Abs(Func(h)) > epsilon);

            return h;
        }

        double Case()
        {
            if (Func(a) < 0 && Func(b) > 0 && DerivFunc(b) > 0)
            {
                return b;
            }
            else if (Func(a) > 0 && Func(b) < 0 && DerivFunc(a) > 0)
            {
                return a;
            }
            else if (Func(a) > 0 && Func(b) < 0 && DerivFunc(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        private void clear_bt_Click(object sender, EventArgs e)
        {
            x3_num_tb.Text = "";
            x2_num_tb.Text = "";
            x_num_tb.Text = "";
            num_tb.Text = "";

            a_tb.Text = "";
            b_tb.Text = "";

            epsilon_tb.Text = "";

            answer_tb.Text = "";
        }

        public void GetNums()
        {
            x3_num = double.Parse(x3_num_tb.Text);
            x2_num = double.Parse(x2_num_tb.Text);
            x_num = double.Parse(x_num_tb.Text);
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
