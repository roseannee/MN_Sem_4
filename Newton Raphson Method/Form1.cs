using System;
using System.Windows.Forms;

namespace Newton_Raphson_Method
{
    public partial class Form1 : Form
    {
        double x3_num, x2_num, x_num, num;
        double x_0;
        double epsilon;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_bt_Click(object sender, EventArgs e)
        {
            GetNums();

            answer_tb.Text = NewtonRaphson(x_0).ToString();
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
            /*double h = Func(x) / DerivFunc(x);

            while (Math.Abs(h) >= epsilon)
            {
                h = Func(x) / DerivFunc(x);

                x -= h;
            }

            return Math.Round(x * 100.0) / 100.0;*/

            double h;

            do
            {
                h = x - (Func(x) / DerivFunc(x));
                x = h;
            } while (Math.Abs(Func(h)) > epsilon);

            return h;
        }

        private void clear_bt_Click(object sender, EventArgs e)
        {
            x3_num_tb.Text = "";
            x2_num_tb.Text = "";
            x_num_tb.Text = "";
            num_tb.Text = "";

            x_0_tb.Text = "";

            epsilon_tb.Text = "";

            answer_tb.Text = "";
        }

        public void GetNums()
        {
            x3_num = double.Parse(x3_num_tb.Text);
            x2_num = double.Parse(x2_num_tb.Text);
            x_num = double.Parse(x_num_tb.Text);
            num = double.Parse(num_tb.Text);

            x_0 = double.Parse(x_0_tb.Text);

            epsilon = double.Parse(epsilon_tb.Text);
        }

        private void onlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
