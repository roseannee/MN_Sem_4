using System;
using System.Windows.Forms;

namespace Numerical_differentiation
{
    public partial class Form1 : Form
    {
        double x4_num, x3_num, x2_num, x_num, num;
        double x, h;

        public Form1()
        {
            InitializeComponent();
        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            GetValues();

            st_deriv_txb.Text = FuncDeriv(x).ToString();
            nd_deriv_txb.Text = FuncDeriv2(x).ToString();

            res_st_deriv_txb.Text = St_Backward(x).ToString();
            res_nd_deriv_txb.Text = Nd_Backward(x).ToString();

            res_st_err_txb.Text = Math.Round(Math.Abs(St_Backward(x) - FuncDeriv(x)), 2).ToString();
            res_nd_err_txb.Text = Math.Round(Math.Abs(Nd_Backward(x) - FuncDeriv2(x)), 2).ToString();
        }

        private void central_btn_Click(object sender, EventArgs e)
        {
            GetValues();

            st_deriv_txb.Text = FuncDeriv(x).ToString();
            nd_deriv_txb.Text = FuncDeriv2(x).ToString();

            res_st_deriv_txb.Text = St_Central(x).ToString();
            res_nd_deriv_txb.Text = Nd_Central(x).ToString();

            res_st_err_txb.Text = Math.Round(Math.Abs(St_Central(x) - FuncDeriv(x)), 2).ToString();
            res_nd_err_txb.Text = Math.Round(Math.Abs(Nd_Central(x) - FuncDeriv2(x)), 2).ToString();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            GetValues();

            st_deriv_txb.Text = FuncDeriv(x).ToString();
            nd_deriv_txb.Text = FuncDeriv2(x).ToString();

            res_st_deriv_txb.Text = St_Forward(x).ToString();
            res_nd_deriv_txb.Text = Nd_Forward(x).ToString();

            res_st_err_txb.Text = Math.Round(Math.Abs(St_Forward(x) - FuncDeriv(x)), 2).ToString();
            res_nd_err_txb.Text = Math.Round(Math.Abs(Nd_Forward(x) - FuncDeriv2(x)), 2).ToString();
        }

        double Func(double x)
        {
            return x4_num * Math.Pow(x, 4) + x3_num * Math.Pow(x, 3) + x2_num * Math.Pow(x, 2) + x_num * x + num;
        }
        double FuncDeriv(double x)
        {
            return x4_num * 4 * Math.Pow(x, 3) + x3_num * 3 * Math.Pow(x, 2) + x2_num * 2 * x + x_num;
        }
        double FuncDeriv2(double x)
        {
            return x4_num * 12 * Math.Pow(x, 2) + x3_num * 6 * x + x2_num * 2;
        }

        double St_Backward(double x)
        {
            return (Func(x - 2 * h) - 4 * Func(x - h) + Func(x)) / (2 * h);
        }
        double St_Central(double x)
        {
            return (Func(x - 2 * h) - 8 * Func(x - h) + 8 * Func(x + h) - Func(x + 2 * h)) / (12 * h);
        }

        double St_Forward(double x)
        {
            return (-3 * Func(x) + 4 * Func(x + h) - Func(x + 2 * h)) / (2 * h);
        }

        double Nd_Backward(double x)
        {
            return (Func(x - 2 * h) - 2 * Func(x - h) + Func(x)) / Math.Pow(h, 2);
        }
        double Nd_Central(double x)
        {
            return (Func(x - h) - 2 * Func(x) + Func(x + h)) / Math.Pow(h, 2);
        }
        double Nd_Forward(double x)
        {
            return (Func(x) - 2 * Func(x + h) + Func(x + 2 * h)) / Math.Pow(h, 2);
        }

        public void GetValues()
        {
            x4_num = double.Parse(x4_num_txb.Text);
            x3_num = double.Parse(x3_num_txb.Text);
            x2_num = double.Parse(x2_num_txb.Text);
            x_num = double.Parse(x_num_txb.Text);
            num = double.Parse(num_txb.Text);

            x = double.Parse(x_txb.Text);
            h = double.Parse(h_txb.Text);
        }

        private void OnlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
