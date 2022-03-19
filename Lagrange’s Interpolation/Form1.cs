using System;
using System.Windows.Forms;

namespace Lagrange_s_Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            Data[] f = { new Data(int.Parse(x_0_txb.Text), int.Parse(y_0_txb.Text)),
                         new Data(int.Parse(x_1_txb.Text), int.Parse(y_1_txb.Text)),
                         new Data(int.Parse(x_2_txb.Text), int.Parse(y_2_txb.Text)),
                         new Data(int.Parse(x_3_txb.Text), int.Parse(y_3_txb.Text)) };

            result_txb.Text = Interpolate(f, double.Parse(x_asterisk_txb.Text)).ToString();
        }

        static double Interpolate(Data[] f, double x_asterisk)
        {
            double result = 0;

            for (int i = 0; i < 4; i++)
            {
                double term = f[i].y;

                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                    {
                        term = term * (x_asterisk - f[j].x) / (f[i].x - f[j].x);
                    }
                }

                result += term;
            }

            return result;
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

class Data
{
    public int x, y;

    public Data(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
